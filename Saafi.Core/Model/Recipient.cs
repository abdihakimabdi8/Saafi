﻿using SQLite;
using System;

namespace Saafi.Core.Models
{
    /// <summary>
    /// This class uses attributes that SQLite.Net can recognize
    /// and use to create the table schema.
    /// </summary>
    [Table(nameof(Recipient))]
    public class Recipient
    {
        [PrimaryKey, AutoIncrement]
        public int RecipientId { get; set; }

        [NotNull, MaxLength(250)]
        public string RecipientName { get; set; }

        [NotNull]
        public string RecipientPhoneNumber { get; set; }


        public Recipient()
        {
            RecipientName = string.Empty;
            RecipientPhoneNumber = string.Empty;
        }
        public override string ToString()
        {
            return $"{RecipientId} ({RecipientName})";
        }
        public bool IsValid()
        {
            return (!String.IsNullOrWhiteSpace(RecipientName) && !String.IsNullOrWhiteSpace(RecipientPhoneNumber));
        }
    }
}