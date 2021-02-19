using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JPN_SentenceAPI.Core.Models
{
    /// <summary>
    /// Represents one specific example sentence.
    /// </summary>
    public class Sentence
    {
        /// <summary>
        /// Unique identifier, SQL ID
        /// </summary>
        [Required]
        public int SentenceID { get; set; }

        /// <summary>
        /// The sentence's definition in Japanese.
        /// </summary>
        public string Japanese { get; set; }

        /// <summary>
        /// The sentence's definition in English. 
        /// </summary>
        public string English { get; set; }
    }
}
