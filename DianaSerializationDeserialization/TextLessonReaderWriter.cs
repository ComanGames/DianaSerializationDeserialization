using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DianaSerializationDeserialization
{
    internal class TextLessonReaderWriter : LessonReaderWriter
    {
        public override void SaveLesson(string path, LessonInfo lessonInfo)
        {
            File.WriteAllText(path, lessonInfo.ToString());
        }

        public override LessonInfo LoadLesson(string path)
        {
            LessonInfo lessonInfo = new LessonInfo();
            File.ReadAllText(path);
            return lessonInfo;
        }
    }
}