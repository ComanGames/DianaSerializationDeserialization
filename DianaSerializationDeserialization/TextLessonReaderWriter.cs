using System.IO;


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