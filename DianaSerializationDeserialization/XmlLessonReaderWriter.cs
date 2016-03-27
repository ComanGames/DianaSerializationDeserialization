using System;

namespace DianaSerializationDeserialization
{
    internal class XmlLessonReaderWriter : LessonReaderWriter
    {
        public override void SaveLesson(string path, LessonInfo lessonInfo)
        {
        }

        public override LessonInfo LoadLesson(string path)
        {
            throw new NotImplementedException();
        }
    }
}