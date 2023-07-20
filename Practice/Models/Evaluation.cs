using System;

namespace Practice.Models
{
    public class Evaluation
    {
        public int RoundId { get; set; }
        public string ColumnName { get; set; }
        public bool Status { get; set; }
        public string DisplayName { get; set; }

    }
}