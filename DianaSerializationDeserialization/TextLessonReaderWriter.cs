using System;
using System.Collections.Generic;
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
                for (int i = 0; i < lessonInfo.LessonQuestions.Length; i++)
                {
                    writer.WriteLine(lessonInfo.LessonQuestions[i]);
                }
            }
        }

        public override LessonInfo LoadLesson(string path)
        {
            LessonInfo lessonInfo = new LessonInfo();
            using (StreamReader reader = File.OpenText(path))
            {
                lessonInfo.LessonTime = Int32.Parse(reader.ReadLine());
                lessonInfo.LessonTopic = reader.ReadLine();
                string lessonQuestion = reader.ReadLine();
                List<string> qestionList = new List<string>();
                while (lessonQuestion != string.Empty)
                {
                    qestionList.Add(lessonQuestion);
                    lessonQuestion = reader.ReadLine();
                }
                lessonInfo.LessonQuestions = qestionList.ToArray();
            }
                return lessonInfo;
        }
    }
}