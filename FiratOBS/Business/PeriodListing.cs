using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PeriodListing
    {
        public List<List<string>> LessonList { get; set; }

        private readonly List<string> _periods = new List<string>(){"20-21","19-20","18-19","17-18"};
        private readonly List<string> _season = new List<string>(){" Bahar Dönemi"," Güz Dönemi"};

        public PeriodListing(List<List<string>> lessonList)
        {
            LessonList = lessonList;
        }

        public List<string> GetPeriods(int period)
        {
            return LessonList[(LessonList.Count-1)-period];
        }

        public string GetPeriodsName(int period)
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

        public List<string> GetPeriods()
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
            return seasons;
        }

        public int PeriodsToInt(string period)
        {
            List<int> indexList = new List<int>();
            List<string> periodList = GetPeriods();

            for (int i = periodList.Count-1; i >= 0; i--)
            {
                indexList.Add(i);
            }
            return indexList[periodList.IndexOf(period)];
        }

        public string ConvertPeriodName(string selectPeriod)
        {
            char[] chars = selectPeriod.ToCharArray();
            string period = null;

            for (int i = 0; i < 5; i++)
            {
                period += chars[i];
            }

            return period;
        }

        public string ConvertSeasonName(string selectSeason)
        {
            char[] chars = selectSeason.ToCharArray();
            string season = null;

            for (int i = 6; i < chars.Length; i++)
            {
                season += chars[i];
            }

            if (season.Equals("Bahar Dönemi"))
            {
                season = "Spring";
            }
            else
            {
                season = "Autumn";
            }
            return season;
        }
    }
}
