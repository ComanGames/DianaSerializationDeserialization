﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianaSerializationDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating our lesson Info
            string[] Questions = new[] {"What Serialization", "Whye we use it", "Where you will use it"};
            LessonInfo lessonInfo = new LessonInfo(120,"Seraializaion",Questions);
            string lessonPath = @"C:\Temp\lesson";

            //universal file Readar from abstarct Class
            LessonReaderWriter lessonReaderWriter;

            //Xml Serialization
            lessonReaderWriter   = new XmlLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath+".xml",lessonInfo);
            lessonReaderWriter.LoadLesson(lessonPath + ".xml");

            //Text Serialization
             lessonReaderWriter   = new TextLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath + ".txt", lessonInfo);
            lessonReaderWriter.LoadLesson(lessonPath + ".txt");

            //Binary Serialization
            lessonReaderWriter = new BinaryLessonReaderWriter();
            lessonReaderWriter.SaveLesson(lessonPath + ".lessonInfo", lessonInfo);
            lessonReaderWriter.LoadLesson(lessonPath + ".lessonInfo");

        }
    }
}