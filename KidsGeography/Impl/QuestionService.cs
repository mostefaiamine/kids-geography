using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    public class QuestionService : IQuestionService
    {
        /// <summary>
        /// adds capitals
        /// </summary>
        /// <param name="group"></param>
        /// <param name="data"></param>
        /// <param name="easyCount"></param>
        /// <param name="v"></param>
        private void AddCapitals(QuestionGroup group, GeoData data, int count, string level)
        {
            var source = data.Countries.Where(e => e.Level == level).ToList();
            BuildQuestionsFrommSource(group, count, source, c => new Question { Text = c.Name, Answer = c.Capital });
        }

        /// <summary>
        /// adds currencies from source data
        /// </summary>
        /// <param name="group"></param>
        /// <param name="data"></param>
        /// <param name="count"></param>
        /// <param name="level"></param>
        private void AddCurrencies(QuestionGroup group, GeoData data, int count, string level)
        {
            var source = data.Countries.Where(e => e.Level == level).ToList();
            BuildQuestionsFrommSource(group, count, source, c => new Question { Text = c.Name, Answer = c.Currency });
        }

        /// <summary>
        ///  adds towns from source data
        /// </summary>
        /// <param name="group"></param>
        /// <param name="data"></param>
        /// <param name="count"></param>
        /// <param name="level"></param>
        private void AddTowns(QuestionGroup group, GeoData data, int count, string level)
        {
            var source = data.Towns.Where(e => e.Level == level).ToList();

            BuildQuestionsFrommSource(group, count, source, t =>
            {
                var country = data.Countries.FirstOrDefault(c => c.Id == t.CountryCode);
                return new Question { Text = t.Name, Answer = country != null ? country.Name : t.CountryCode };
            });
        }

        private static void BuildQuestionsFrommSource<T>(QuestionGroup group, int count, List<T> source, Func<T, Question> func)
        {
            var random = new Random();
            while (source.Count > count)
            {
                var idx = random.Next(source.Count);
                source.RemoveAt(idx);
            }
            foreach (var elt in source)
            {
                var q = func(elt);
                group.Questions.Add(q);
            }
        }

      



        public Task<List<QuestionGroup>> BuildQuestions(GeoData data, int easyCount, int mediumCount, int hardCount)
        {
            var group1 = new QuestionGroup
            {
                Name = "Capitals",
                Questions = new List<Question>()
            };
            AddCapitals(group1, data, easyCount, "Easy");
            AddCapitals(group1, data, mediumCount, "Medium");
            AddCapitals(group1, data, hardCount, "Hard");
            var group2 = new QuestionGroup
            {
                Name = "Towns",
                Questions = new List<Question>()
            };
            AddTowns(group2, data, easyCount, "Easy");
            AddTowns(group2, data, mediumCount, "Medium");
            AddTowns(group2, data, hardCount, "Hard");
            var group3 = new QuestionGroup
            {
                Name = "Currencies",
                Questions = new List<Question>()
            };
            AddCurrencies(group3, data, easyCount, "Easy");
            AddCurrencies(group3, data, mediumCount, "Medium");
            AddCurrencies(group3, data, hardCount, "Hard");
            var list = new List<QuestionGroup> { group1, group2, group3 };
            return Task.FromResult(list);
        }


    }
}
