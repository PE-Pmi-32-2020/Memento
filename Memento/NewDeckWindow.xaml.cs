﻿// <copyright file="NewDeckWindow.xaml.cs" company="lnu.edu.ua">
// Copyright (c) lnu.edu.ua. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Memento
{
    /// <summary>
    /// Interaction logic for NewDeckWindow.xaml.
    /// </summary>
    public partial class NewDeckWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewDeckWindow"/> class.
        /// </summary>
        public NewDeckWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the name of the deck.
        /// </summary>
        public string DeckName { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the tag name of the deck.
        /// </summary>
        public string TagName { get; set; } = String.Empty;

        private async void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (DeckNameTextBox.Text.Trim() == String.Empty)
            {
                ColorAnimation ca = new ColorAnimation(Colors.Black, Colors.Red, new Duration(TimeSpan.FromMilliseconds(500)));
                DeckNameTextBlock.Foreground = new SolidColorBrush(Colors.Black);
                DeckNameTextBlock.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, ca);

                await Task.Delay(500);

                ColorAnimation ca1 = new ColorAnimation(Colors.Red, Colors.Black, new Duration(TimeSpan.FromMilliseconds(500)));
                DeckNameTextBlock.Foreground = new SolidColorBrush(Colors.Red);
                DeckNameTextBlock.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, ca1);

                return;
            }

            DeckName = DeckNameTextBox.Text.Trim();
            TagName = TagNameTextBox.Text.Trim();

            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
