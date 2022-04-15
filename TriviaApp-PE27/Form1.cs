using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PeopleAppGlobals;
using PeopleLib;
using System.IO;
using System.Net;

namespace TriviaApp_PE27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globals.AddPeopleSampleData();

            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();

            foreach(KeyValuePair<string, Person> keyValuePair in Globals.people.sortedList)
            {
                if(keyValuePair.Value.GetType() == typeof(Teacher))
                {
                    teachers.Add((Teacher)keyValuePair.Value);
                }
                else
                {
                    students.Add((Student)keyValuePair.Value);
                }
            }

            string s = JsonConvert.SerializeObject(students);
            string t = JsonConvert.SerializeObject(teachers);


            StreamWriter teachWriter = new StreamWriter("D:/teachers.json");
            teachWriter.Write(t);
            teachWriter.Close();

            StreamWriter studWriter = new StreamWriter("D:/students.json");
            studWriter.Write(s);
            studWriter.Close();

            StreamReader studReader = new StreamReader("D:/students.json");
            s = studReader.ReadToEnd();
            studReader.Close();

            StreamReader teachReader = new StreamReader("D:/teachers.json");
            t = teachReader.ReadToEnd();
            teachReader.Close();

            students = JsonConvert.DeserializeObject<List<Student>>(s);
            teachers = JsonConvert.DeserializeObject<List<Teacher>>(t);

            SortedList<string, Person> people = new SortedList<string, Person>();
            foreach(Student student in students)
            {
                people[student.email] = student;
            }

            foreach (Teacher teacher in teachers)
            {
                people[teacher.email] = teacher;
            }

            string url = "http://people.rit.edu/dxsigm/json.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            t = reader.ReadToEnd();
            reader.Close();
            response.Close();

            teachers = JsonConvert.DeserializeObject<List<Teacher>>(t);


        }
    }
}
