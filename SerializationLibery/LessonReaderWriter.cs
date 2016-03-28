namespace SerializationLibery
{
    public abstract class LessonReaderWriter
    {
        public abstract void SaveLesson(string path, LessonInfo lessonInfo);
        public abstract LessonInfo LoadLesson(string path);

    }
}