﻿using Memento.DAL;
using System;

namespace Memento.BLL
{
    public class DeckEditorAddCardEventArgs : EventArgs
    {
        public DeckEditorAddCardEventArgs(Card card)
        {
            Card = new Card(card);
        }

        public Card Card { get; set; }
    }

    public class DeckEditorRemoveCardEventArgs : EventArgs
    {
        public DeckEditorRemoveCardEventArgs(Card card)
        {
            Card = new Card(card);
        }

        public Card Card { get; set; }
        public bool CardRemoved { get; set; }
    }

    public class DeckEditorDeckEventArgs : EventArgs
    {
        public DeckEditorDeckEventArgs(Deck deck)
        {
            Deck = new Deck(deck);
        }

        public Deck Deck { get; set; }
    }

    public class ExitDeckEditorEventArgs : EventArgs
    {
        public ExitDeckEditorEventArgs()
        { }

        public bool Exited { get; set; }
    }
}