using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    public class Question
    {
        /// <summary>
        /// Question answer
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// True when the question is done
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// question text
        /// </summary>
        public string Text { get; set; }
    }
}
