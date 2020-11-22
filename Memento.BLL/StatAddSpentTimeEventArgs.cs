﻿namespace Memento.BLL
{
    using System;
    using Memento.DAL;

    public class StatAddSpentTimeEventArgs : EventArgs
    {
        public StatAddSpentTimeEventArgs(TimeSpan time)
        {
            TimePassed = time;
        }

        public TimeSpan TimePassed { get; }
    }

    public class StatCardLearnedEventArgs : EventArgs
    {
        public StatCardLearnedEventArgs(Card card)
        {
            LearnedCard = new Card(card);
        }

        public Card LearnedCard { get; }
    }
}
