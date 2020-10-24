﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Memento.DAL;

namespace Memento.BLL
{
    public class Statistics
    {
        public Statistics()
        {
            TimeSpentToday = new TimeSpan();
            AvarageTimePerDay = new TimeSpan();
            CardsLearnedToday = new List<Card>();
        }
        public TimeSpan TimeSpentToday { get; set; }
        public TimeSpan AvarageTimePerDay { get; set; }
        public List<Card> CardsLearnedToday { get; set; }

    }
}
