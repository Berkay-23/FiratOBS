using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LessonListing
    {
        public List<List<string>> LessonList { get; set; }

        private readonly List<string> _periods = new List<string>(){"20-21","19-20","18-19","17-18"};
        private readonly List<string> _season = new List<string>(){" Bahar Dönemi"," Güz Dönemi"};

        public LessonListing(List<List<string>> lessonList)
        {
            LessonList = lessonList;
        }

        public List<string> GetLessons(int period)
        {
            return LessonList[(LessonList.Count-1)-period];
        }

        public string GetLessonsName(int period)
        {
            List<string> seasons = new List<string>();
            int periodIndex = 0;

            for (int index = 0; index < LessonList.Count; index++)
            {
                if (LessonList.Count % 2 == 0)
                {
                    if (index % 2 == 0)
                    {
                        seasons.Add(_periods[index: periodIndex] + _season[0]);
                    }

                    if (index % 2 != 0)
                    {
                        seasons.Add(_periods[index: periodIndex] + _season[1]);
                        periodIndex++;
                    }
                }
                else
                {
                    if (index == 1 || index % 2 != 0)
                        periodIndex++;

                    if (index % 2 == 0)
                    {
                        seasons.Add(_periods[periodIndex] + _season[1]);
                    }

                    if (index % 2 != 0)
                    {
                        seasons.Add(_periods[periodIndex] + _season[0]);
                    }
                }

            }
            return seasons[period];
        }

    }
}
