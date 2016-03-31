using System;
using System.Collections.Generic;
using SerializationLibery;


namespace DianaSerializationDeserialization
{
    class Utilities
    {
        public string topic;
        public List<string> questionsList;
        public TimeSpan ts;


        public string AddTopic()
        {
            Console.WriteLine("Please write down topic of current lesson");
            topic = Console.ReadLine();
            Console.Clear();
            return topic;
        }

        public List<string> CreatArrayOfQuestions()
        {
            Console.WriteLine("Type in new question");
            questionsList.Add(Console.ReadLine());

            return questionsList;
        }

        public TimeSpan SetTime()
        {
            Console.WriteLine("Write duration of your lesson");
            try
            {
                ts = TimeSpan.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad Format");
            }
           return ts;
        }

        class Program
        {
            static void Main()
            {
                //Creating our lesson Info
                Utilities newUtilities = new Utilities();
                newUtilities.AddTopic();
                Console.Clear();
                Console.WriteLine("Please put in lesson question");
                newUtilities.CreatArrayOfQuestions();
                Console.Clear();
                Console.WriteLine("If you would like to add more questions, press Y. Otherwise press N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    do
                    {
                      newUtilities.CreatArrayOfQuestions();
                    }
                    while (Console.ReadKey().Key == ConsoleKey.Y);

                }
                else
                {
                    newUtilities.SetTime();
                    Console.Clear();

                }
                
                LessonInfo lessonInfo = new LessonInfo(newUtilities.SetTime(), newUtilities.AddTopic(), newUtilities.CreatArrayOfQuestions());
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
}
