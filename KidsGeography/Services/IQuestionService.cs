using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    public interface IQuestionService
    {
        Task<List<QuestionGroup>> BuildQuestions(GeoData data, int easyCount, int mediumCount, int hardCount);
    }
}
