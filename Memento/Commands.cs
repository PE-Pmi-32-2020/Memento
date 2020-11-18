// <copyright file="Commands.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Memento
{
    using System.Windows.Input;
    using Memento.UserControls;

    /// <summary>
    /// Command definitions.
    /// </summary>
    internal class Commands
    {
        public static readonly RoutedCommand NewCardCommand = new RoutedUICommand("New Card", nameof(NewCardCommand), typeof(DeckEditorUserControl));

        public static readonly RoutedCommand NewExistingCardCommand = new RoutedUICommand("New Existing Card", nameof(NewExistingCardCommand), typeof(DeckEditorUserControl));

        public static readonly RoutedCommand RemoveCardCommand = new RoutedUICommand("Remove Card", nameof(RemoveCardCommand), typeof(DeckEditorUserControl));

        public static readonly RoutedCommand SaveCardCommand = new RoutedUICommand("Save Card", nameof(SaveCardCommand), typeof(DeckEditorUserControl));

        public static readonly RoutedCommand RemoveDeckCommand = new RoutedUICommand("Remove Deck", nameof(RemoveDeckCommand), typeof(DeckEditorUserControl));

        public static readonly RoutedCommand GoBackCommand = new RoutedUICommand(
            "Back",
            nameof(GoBackCommand),
            typeof(StatisticsUserControl),
            new InputGestureCollection(new InputGesture[]
            {
                new KeyGesture(Key.Escape),
            }));

        public static readonly RoutedCommand ExitCommand = new RoutedUICommand("Exit", nameof(ExitCommand), typeof(MainPageUserControl));

        public static readonly RoutedCommand StartLearningCommand = new RoutedUICommand("Start", nameof(StartLearningCommand), typeof(MainPageUserControl));

        public static readonly RoutedCommand HelpCommand = new RoutedUICommand("Help", nameof(HelpCommand), typeof(MainPageUserControl));
    }
}
