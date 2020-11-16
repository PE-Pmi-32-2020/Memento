﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Memento.DAL
{
    class TagToCardModel
    {
        public TagToCardModel()
        { }

        public TagToCardModel(int cardId, string tag)
        {
            CardID = cardId;
            TagName = tag;
        }

        [Column("tag_name")]
        public string TagName { get; set; }

        [Column("card_id")]
        public int CardID { get; set; }

        [NotMapped]
        public int CardId { get; set; }

        public CardModel Card { get; set; }

    }
}
