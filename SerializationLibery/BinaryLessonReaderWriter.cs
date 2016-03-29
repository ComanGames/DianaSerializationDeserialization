using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationLibery
{
    public class BinaryLessonReaderWriter : LessonReaderWriter
    { 
        public override void SaveLesson(string path, LessonInfo lessonInfo)
        {
            BinaryFormatter myBinFormatter = new BinaryFormatter();
            using (Stream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                myBinFormatter.Serialize(fileStream, lessonInfo);
            }
        }

        public override LessonInfo LoadLesson(string path)
        {
            LessonInfo lessonInfo;
            BinaryFormatter mBinaryFormatter = new BinaryFormatter();
            using (Stream fileStream = File.OpenRead(path))
            {
                lessonInfo = (LessonInfo) mBinaryFormatter.Deserialize(fileStream);
            }
            return lessonInfo;
        }
    }
}