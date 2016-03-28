using System.IO;
using System.Xml.Serialization;

namespace DianaSerializationDeserialization
{
    internal class XmlLessonReaderWriter : LessonReaderWriter
    {
        public override void SaveLesson(string path, LessonInfo lessonInfo)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof (LessonInfo));
            using (Stream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                myXmlSerializer.Serialize(fileStream, lessonInfo);
            }
        }

        public override LessonInfo LoadLesson(string path)
        {
            XmlSerializer newSerializer = new XmlSerializer(typeof (LessonInfo));
            LessonInfo lessonInfo;
            using (Stream reader = new FileStream(path, FileMode.Open))
            {
                lessonInfo = (LessonInfo) newSerializer.Deserialize(reader);
            }
            return lessonInfo;
        }
    }
}