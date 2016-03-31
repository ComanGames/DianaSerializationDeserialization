using System;
using SerializationLibery;


namespace DianaSerializationDeserialization
{
    class Program
    {
        static void Main()
        {
            //Creating our lesson Info
                Utilities newUtilities = new Utilities();
                Console.WriteLine("Please write down topic of current lesson");
                newUtilities.AddTopic(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Please put in lesson question");
                newUtilities.CreatArrayOfQuestions(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("If you would like to add more questions, press Y. Otherwise press N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    do
                    {
                      newUtilities.CreatArrayOfQuestions(Console.ReadLine());
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);

                }
                else
                {
                    newUtilities.SetTime(Console.ReadLine());
                    Console.Clear();

                }
                
                LessonInfo lessonInfo = newUtilities.CreateLessonInfo();
            string lessonPath = @"C:\Temp\lesson";
            //Universal file Reader from abstract Class
            LessonReaderWriter lessonReaderWriter;

            //Text Serialization
                lessonReaderWriter = new TextLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath + ".txt", lessonInfo);
//            lessonReaderWriter.LoadLesson(lessonPath + ".txt");

            //Xml Serialization
            lessonReaderWriter = new XmlLessonReaderWriter();
                lessonReaderWriter.SaveLesson(lessonPath + ".xml", lessonInfo);
            //            lessonReaderWriter.LoadLesson(lessonPath + ".xml");

            //Binary Serialization
            lessonReaderWriter = new BinaryLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath + ".lessonInfo", lessonInfo);
            //            lessonReaderWriter.LoadLesson(lessonPath + ".lessonInfo");


            Console.ReadKey();
        }
    }

}
