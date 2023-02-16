using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class FormGeneric : Form
    {
        public FormGeneric()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            string[] names = new string[3];
            names[0] = "Davi";
            names[1] = "Rodrigues";
            names[2] = "Diniz";

            List<string> names2= new List<string>();
            // names2.Add("Davi");
            //names2.Add("Rodrigues");

            names2.AddRange(names);

            /*if (names2.Contains("Rodrigues"))
            {
                MessageBox.Show("Contain");
            }
            else
            {
                MessageBox.Show("Not contain");
            }
            */
            //MessageBox.Show($"Number of objects: {names2.Count}");
            //names2.Sort(); 
            //names2.Remove("Davi"); 

            names2.Insert(0, "Rasta");
            names2.RemoveAt(0);
            names2.Clear();

            MessageBox.Show($"Davi is in the index: {names2.IndexOf("Davi")}");
            foreach (var i in names2)
            {
                list.Items.Add(i);
            }
          

        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            HashSet<string> vehicles = new HashSet<string>()
            {
                "Car",
                "Motorbike",
                "Airplane",
                "Helicopter",
                "Boat"
            };

            //vehicles.Add("Horse");

            //if (vehicles.Add("Horse"))
            //{
            //    MessageBox.Show("Added!");
            //}
            //else
            //{
            //    MessageBox.Show("Not added");
            //}
            vehicles.Remove(""); 
            vehicles.Contains(""); 
            int num = vehicles.Count; 
            MessageBox.Show(vehicles.ElementAt(1));
            vehicles.First();

            foreach (var i in vehicles)
            {
                list.Items.Add(i);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> student = new Dictionary<int, string>()
            {
                {150, "Roger"},{200, "Alpha"},{80, "Lima"}
            };

            student.Add(100, "Davi");

            foreach (KeyValuePair<int,string> i in student)
            {
                list.Items.Add(i.Value);
            }
            //student.ContainsKey();
            //student.ContainsValue();


        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            list.Items.Clear();

            SortedList<int, string> student = new SortedList<int, string>()
            {
                {27,"Davi" },{10,"Orion"},{17,"John"}
            };

            //student.Remove(27);
            //student.RemoveAt(0);

            student.Add(14, "Darian");
            foreach (var i in student.Reverse()) 
            {
                list.Items.Add("Value = " + i.Value + " | Key = " + i.Key);
            }



        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> student = new SortedDictionary<int, string>()
            {
                { 4512, "Davi" }, { 1542, "Arthur"}, { 2145, "Patek"}
            };

            student.Add(5478, "Serj");
            student.ContainsKey(4512);

            foreach(KeyValuePair<int,string> item in student.Reverse())
            {
                list.Items.Add(item);
            }

        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            list.Items.Clear ();
            SortedSet<string> names = new SortedSet<string>() { 
                "Davi","Serj","Limma","West","Taylor"            
            };

            foreach(string item in names)
            {
                list.Items.Add(item);
            }

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Queue<string> Queue_ = new Queue<string>();

            Queue_.Enqueue("Davi");
            Queue_.Enqueue("Dragon");
            Queue_.Enqueue("Union");


            MessageBox.Show(Queue_.Count().ToString());

            foreach (string item in Queue_)
            {
                list.Items.Add(item);
            }
            //MessageBox.Show("Queue first element -> " + Queue_.Peek()); returns without remove
            //MessageBox.Show(Queue_.Count().ToString());

            /*MessageBox.Show("Queue remove object -> " + Queue_.Dequeue()); //remove first object
            MessageBox.Show(Queue_.Count().ToString());

            MessageBox.Show("Queue first object -> " + Queue_.First()); //return first object
            MessageBox.Show(Queue_.Count().ToString());

            MessageBox.Show("Queue last object -> " + Queue_.Last()); //return last object
            MessageBox.Show(Queue_.Count().ToString());
            */
            //Queue_.Clear();

            list.Items.Clear();

            foreach (string item in Queue_)
            {
                list.Items.Add(item);
            }

        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            Stack<string> Stack_ = new Stack<string>();

            Stack_.Push("Davi");
            Stack_.Push("Dragon");
            Stack_.Push("Rocky");

            MessageBox.Show(Stack_.Count().ToString());

            foreach (string item in Stack_)
            {
                list.Items.Add(item);
            }

            MessageBox.Show(Stack_.Peek()); 
            //Stack_.Pop();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }
    }
}
