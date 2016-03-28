using System;
using System.Diagnostics;

namespace DianaSerializationDeserialization
{
    class Program
    {
        static void Main()
        {
            //Creating our lesson Info
            string[] questions = new[] {"What Serialization", "Why we use it", "Where you will use it"};
            LessonInfo lessonInfo = new LessonInfo(120,"Serialization",questions);
            string lessonPath = @"C:\Temp\lesson";
            //Universal file Reader from abstract Class
            Stopwatch sw = new Stopwatch();
            LessonReaderWriter lessonReaderWriter;

            //Text Serialization
            lessonReaderWriter   = new TextLessonReaderWriter();
            sw.Start();
            lessonReaderWriter.SaveLesson(lessonPath + ".txt", lessonInfo);
            sw.Stop();
            Console.WriteLine($"Text serialization teke {sw.ElapsedMilliseconds} ");
//            lessonReaderWriter.LoadLesson(lessonPath + ".txt");

            //Xml Serialization
            lessonReaderWriter = new XmlLessonReaderWriter();
            sw.Reset();
            sw.Start();
            lessonReaderWriter.SaveLesson(lessonPath+".xml",lessonInfo);
            sw.Stop();
            Console.WriteLine($"XML serialization teke {sw.ElapsedMilliseconds} ");

            //            lessonReaderWriter.LoadLesson(lessonPath + ".xml");

            //Binary Serialization
            lessonReaderWriter = new BinaryLessonReaderWriter();
            sw.Reset();
            sw.Start();
            lessonReaderWriter.SaveLesson(lessonPath + ".lessonInfo", lessonInfo);
            sw.Stop();
            Console.WriteLine($"Binary serialization teke {sw.ElapsedMilliseconds} ");

            //            lessonReaderWriter.LoadLesson(lessonPath + ".lessonInfo");


            Console.ReadKey();
        }
    }
}
