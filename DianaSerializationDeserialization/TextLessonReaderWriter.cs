using System;
using System.IO;


namespace DianaSerializationDeserialization
{
    internal class TextLessonReaderWriter : LessonReaderWriter
    {
        public override void SaveLesson(string path, LessonInfo lessonInfo)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(lessonInfo.LessonTime.ToString());
                writer.WriteLine(lessonInfo.LessonTopic);
                writer.WriteLine(lessonInfo.LessonQuestions);
            }
        }

        public override LessonInfo LoadLesson(string path)
        {
            LessonInfo lessonInfo = new LessonInfo();
            using (StreamReader reader = File.OpenText(path))
            {
                string input;
                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            return lessonInfo;
        }
    }
}