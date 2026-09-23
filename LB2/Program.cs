namespace LB2
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int groupsCount = rnd.Next(3, 6);
            int[][] grades = new int[groupsCount][];
            //Console.WriteLine(groupsCount);

            for(int i = 0; i < groupsCount; i++)
            {
                int studentsCount = rnd.Next(10, 31);
                grades[i] = new int[studentsCount];
                for (int j = 0; j < studentsCount; j++)
                {
                    grades[i][j] = rnd.Next(1, 101);
                }
            }
            for (int i = 0; i < grades.Length; i++)
            {
                double groupAvg = grades[i].Average();
                int groupMin = grades[i].Min();
                int groupMax = grades[i].Max();

                Console.WriteLine($"Група {i + 1} (студентів: {grades[i].Length}):");
                Console.WriteLine($"Середній бал: {groupAvg}");
                Console.WriteLine($"Мінімальна оцінка: {groupMin}");
                Console.WriteLine($"Максимальна оцінка: {groupMax}");
            }

            double totalSum = 0;
            int totalStudents = 0;
            int streamMin = 101; 
            int streamMax = 0;   


            for (int i = 0; i < grades.Length; i++)
            {
                for (int j = 0; j < grades[i].Length; j++)
                {
                    int currentGrade = grades[i][j];

                    totalSum += currentGrade;
                    totalStudents++;

                    if (currentGrade < streamMin)
                    {
                        streamMin = currentGrade;
                    }

                    if (currentGrade > streamMax)
                    {
                        streamMax = currentGrade;
                    }
                }
            }

            double streamAvg = totalSum / totalStudents;

            Console.WriteLine("==============================");
            Console.WriteLine("СТАТИСТИКА ПО ВСЬОМУ ПОТОКУ:");
            Console.WriteLine("==============================");
            Console.WriteLine($"Загальна кількість студентів: {totalStudents}");
            Console.WriteLine($"Середній бал: {streamAvg:F2}");
            Console.WriteLine($"Мінімальна оцінка: {streamMin}");
            Console.WriteLine($"Максимальна оцінка: {streamMax}");
        }
    }
}
