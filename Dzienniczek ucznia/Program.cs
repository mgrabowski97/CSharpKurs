using System;

namespace Studentdiary 
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDiary.Diary diary = new StudentDiary.Diary();
            //diary.AddRating(5);
            //diary.AddRating(9.5f);
            //diary.AddRating(8);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.pobierzmaxrating();
            //float min = diary.pobierzminrating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1-10: ");

                float rating; 
               bool result = float.TryParse(Console.ReadLine(), out rating);

              

                if (rating == 11)

                {
                    break;
                }
                if (result)
                {
                    if (rating > 0 && rating <=10 )
                    {
                        diary.AddRating(rating);
                    }
                    else
                    
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zakresu 1-10 ");
                    }
                }
            }
            Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.pobierzmaxrating());
            Console.WriteLine("Najniższa ocena to: " + diary.pobierzminrating());
            Console.ReadKey();




            


        }
        }
    }

