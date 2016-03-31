using System;
using System.Collections.Generic;
using System.IO;

namespace SerializationLibery
{
    public class TextLessonReaderWriter : LessonReaderWriter
    {
        public override void SaveLesson(string path, LessonInfo lessonInfo)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(lessonInfo.LessonTime.ToString());
                writer.WriteLine(lessonInfo.LessonTopic);
                for (int i = 0; i < lessonInfo.LessonQuestions.Count; i++)
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
                lessonInfo.LessonTime = TimeSpan.Parse(reader.ReadLine());
                lessonInfo.LessonTopic = reader.ReadLine();
                string lessonQuestion = reader.ReadLine();
                List<string> questionList = new List<string>();
                while (lessonQuestion != string.Empty)
                {
                    questionList.Add(lessonQuestion);
                    lessonQuestion = reader.ReadLine();
                }
                lessonInfo.LessonQuestions = questionList;
            }
                return lessonInfo;
        }
    }
}