using System;

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
            LessonReaderWriter lessonReaderWriter;

            //Xml Serialization
            lessonReaderWriter = new XmlLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath+".xml",lessonInfo);
            lessonReaderWriter.LoadLesson(lessonPath + ".xml");

            //Binary Serialization
            lessonReaderWriter = new BinaryLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath + ".lessonInfo", lessonInfo);
            lessonReaderWriter.LoadLesson(lessonPath + ".lessonInfo");

            //Text Serialization
            lessonReaderWriter   = new TextLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath + ".txt", lessonInfo);
            lessonReaderWriter.LoadLesson(lessonPath + ".txt");

            Console.ReadKey();
        }
    }
}
