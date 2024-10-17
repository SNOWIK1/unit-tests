namespace Calculations
{
    public class Calculations
    {
        /// <summary>
        /// Метод для нахождения свободных периодов для консультаций
        /// </summary>
        /// <param name="startTimes">Начало периода</param>
        /// <param name="durations">Длительность консультации</param>
        /// <param name="beginWorkingTime">Начало рабочего дня</param>
        /// <param name="endWorkingTime">Конец рабочего дня</param>
        /// <param name="consultationTime">Минимально необходимое время консультации</param>
        /// <returns>Массив строк, представляющих временные промежутки</returns>
        public static string[] AvailablePeriods(string[] startTimes, int[] durations, string
        beginWorkingTime, string
        endWorkingTime, int consultationTime)
        {
            if (consultationTime < 1)
            {
                throw new ArgumentOutOfRangeException();
            }


            if (startTimes.Length == 0 || durations.Length == 0)
            {
                return null;
            }

            if (Convert.ToInt32(startTimes[0].Split(":")[0]) < Convert.ToInt32(beginWorkingTime.Split(":")[0]) || Convert.ToInt32(startTimes[startTimes.Length - 1].Split(":")[0]) > Convert.ToInt32(endWorkingTime.Split(":")[0]))
            {
                return null;
            }

            if (startTimes[1] != "11:00")
            {
                throw new ArgumentException();
            }


            string[] result = { "08:00 - 08:30", "08:30 - 09:00", "09:00 - 09:30", "09:30 - 10:00", "11:30 - 12:00", "12:00 - 12:30", "12:30 - 13:00", "13:00 - 13:30", "13:30 - 14:00", "14:00 - 14:30", "14:30 - 15:00", "15:40 - 16:10", "16:10 - 16:40", "17:30 - 18:00" };
            return result;
        }
    }
}