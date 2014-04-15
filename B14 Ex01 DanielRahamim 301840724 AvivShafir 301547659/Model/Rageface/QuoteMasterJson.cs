using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Rageface
{
    class QuoteMasterJson
    {
        public string text { get; set; }
        public int charCount { get; set; }
        public string author { get; set; }
        public string sourceUrl { get; set; }
        public int positiveVotes { get; set; }
        public int negativeVotes { get; set; }
        public int totalVotes { get; set; }

    }
}