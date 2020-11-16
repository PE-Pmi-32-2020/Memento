﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Memento.UserControls;
using Memento.BLL;
using Memento.DAL;
using System.Diagnostics;

namespace Memento
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Content = MainPage = new MainPageUserControl()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
            };

            MainPage.StartEditingEvent += StartEditing;
            MainPage.OpenSettingsEvent += OpenSettings;
            MainPage.OpenStatisticsEvent += OpenStatistics;

            IsInEditor = false;
            IsInLearningProcess = false;
        }

        public bool IsInEditor { get; private set; }
        public bool IsInLearningProcess { get; private set; }

        public AppHandler LearningProcess { get; private set; }
        public DeckEditor DeckEditor { get; set; }
        public Settings AppSettings { get; set; }
        public Statistics AppStatistics { get; set; }

        public MainPageUserControl MainPage { get; set; }
        public DeckEditorUserControl DeckEditorPage { get; set; }
        public SettingsUserControl SettingsPage { get; set; }
        public StatisticsUserControl StatisticsPage { get; set; }

        private void StartLearning(object sender, RoutedEventArgs e)
        {
            LearningProcess = new AppHandler((int)((Button)sender).Tag);
            LearningProcess.Start(SettingsPage.AppSettings.CardOrder, SettingsPage.AppSettings.ShowImages);
        }

        private void StartEditing(object sender, StartEditingEventArgs e)
        {
            Content = DeckEditorPage = new DeckEditorUserControl(e.DeckId)
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
            };

            DeckEditorPage.MakeMainPageVisible += GoToMainPageFromDeckEditor;
            DeckEditorPage.TitleChanged += ChangeMainTitle;

            if (e.DeckId == -1)
            {
                Title = "Memento - Deck Editor -";
            }
            else
            {
                Title = $"Memento - Deck Editor - {DeckEditorPage.DeckEditor.Deck.DeckName}";
            }
        }

        private void GoToMainPageFromDeckEditor(object sender, EventArgs e)
        {
            DeckEditorPage.MakeMainPageVisible -= GoToMainPageFromDeckEditor;
            DeckEditorPage.TitleChanged -= ChangeMainTitle;
            Content = MainPage;
            Title = "Memento";
        }

        private void ChangeMainTitle(object sender, ChangeTitleEventArgs e)
        {
            Title = e.Title;
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            if (AppSettings is null)
            {
                AppSettings = new Settings();
            }
            Content = SettingsPage = new SettingsUserControl(AppSettings)
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
 
            SettingsPage.MakeMainPageVisible += GoToMainPageFromSettings;
            Title = "Memento - Settings";
        }

        private void GoToMainPageFromSettings(object sender, EventArgs e)
        {
            SettingsPage.MakeMainPageVisible -= GoToMainPageFromSettings;
            Content = MainPage;
            Title = "Memento";
        }

        private void OpenStatistics(object sender, EventArgs e)
        {   
            if (AppStatistics is null)
            {
                AppStatistics = new Statistics();
            }

            if (AppSettings is null)
            {
                AppSettings = new Settings();
                Content = StatisticsPage = new StatisticsUserControl(1.5, 3, 26, AppSettings)
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch
                };
            }
            else
            {
                Content = StatisticsPage = new StatisticsUserControl(1.5, 3, 26, SettingsPage.AppSettings)
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch
                };
            }

            
            StatisticsPage.MakeMainPageVisible += GoToMainPageFromStatistics;
            Title = "Memento - Statistics";
        }

        public void GoToMainPageFromStatistics(object sender, EventArgs e)
        {
            StatisticsPage.MakeMainPageVisible -= GoToMainPageFromStatistics;
            Content = MainPage;
            Title = "Memento";
        }
    }
}
