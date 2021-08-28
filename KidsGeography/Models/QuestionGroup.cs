using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    public class QuestionGroup
    {
        public QuestionGroup()
        {
            Questions = new List<Question>();
        }

        /// <summary>
        /// Done
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// group name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Questions
        /// </summary>
        public List<Question> Questions { get; set; }
    }
}
