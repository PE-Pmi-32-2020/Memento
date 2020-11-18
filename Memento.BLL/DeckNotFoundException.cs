﻿// <copyright file="DeckNotFoundException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Memento.BLL
{
    using System;

    class DeckNotFoundException : Exception
    {
        public DeckNotFoundException(string message = "No such deck could be found in the database")
        {
            this.Message = message;
        }

        public override string Message { get; }
    }
}
