﻿// <copyright file="RemoveDeckEditorDeckEventArgs.cs" company="lnu.edu.ua">
// Copyright (c) lnu.edu.ua. All rights reserved.
// </copyright>

using System;

using Memento.DAL;

namespace Memento.BLL.DeckEditorEventArgs
{
    /// <summary>
    /// Event arguments for deleting a deck.
    /// </summary>
    public class RemoveDeckEditorDeckEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveDeckEditorDeckEventArgs"/> class.
        /// </summary>
        /// <param name="deck">The deck to be removed.</param>
        public RemoveDeckEditorDeckEventArgs(Deck deck)
        {
            Deck = new Deck(deck);
            Removed = false;
        }

        /// <summary>
        /// Gets the deck to be removed.
        /// </summary>
        public Deck Deck { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the card was removed or not.
        /// </summary>
        public bool Removed { get; set; }
    }
}
