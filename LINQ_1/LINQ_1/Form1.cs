using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {

        List<string> list_names; //Values
        List<int> list_numbers;
        Dictionary<string, double> list_products;
        Dictionary<string, string> list_states;

        public Form1()
        {
            InitializeComponent();

            #region Listanames

            list_names = new List<string>();
            list_names.Add("Davi");
            list_names.Add("John");
            list_names.Add("Taylor");
            list_names.Add("Ronaldo");
            list_names.Add("Cristiano");
            list_names.Add("Messi");
            list_names.Add("Max");
            list_names.Add("Billie");
            list_names.Add("Edson");
            list_names.Add("Nick");
            list_names.Add("Chester");
            list_names.Add("Sophia");
            list_names.Add("Anne");
            list_names.Add("Jhonson");
            list_names.Add("CJ");
            list_names.Add("Lewis");
            list_names.Add("Will");
            list_names.Add("Whinderson");

            #endregion

            #region ListaNumbers

            list_numbers= new List<int>();
            list_numbers.Add(187);
            list_numbers.Add(329);
            list_numbers.Add(226);
            list_numbers.Add(123);
            list_numbers.Add(921);
            list_numbers.Add(12);
            list_numbers.Add(7);
            list_numbers.Add(5);
            list_numbers.Add(13);
            list_numbers.Add(9);
            list_numbers.Add(2);
            list_numbers.Add(93);
            list_numbers.Add(3);

            #endregion

            #region ListProducts

            list_products = new Dictionary<string, double>();
            list_products.Add("Monitor", 799.99);
            list_products.Add("Keyboard", 159.99);
            list_products.Add("SSD 500gb", 200.90);
            list_products.Add("Mouse", 120.70);
            list_products.Add("Processor", 1299.00);
            list_products.Add("RAM 8gb", 150.10);
            list_products.Add("RTX 3060", 2700.00);
            list_products.Add("Case", 299.99);
            list_products.Add("Chair", 1150.25);


            #endregion

            #region ListStates

            list_states = new Dictionary<string, string>();
            list_states.Add("São Paulo", "Brazil");
            list_states.Add("New York", "USA");
            list_states.Add("Paris", "French");
            list_states.Add("Tokyo", "Japan");
            list_states.Add("Pequim", "China");
            list_states.Add("Pyongyang", "North Corea");
            list_states.Add("New méxico", "USA");

            #endregion

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
           
            //foreach (int item in list_numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        list.Items.Add(item); //Slow
            //    }
            //}


            #region linq list_numbers
            //var res = from num in list_numbers where num % 2 == 0 select num; ou
            //IEnumerable<int> res = from num in list_numbers where num % 2 == 0 select num;

            //foreach (int n in res)
            //{
            //    list.Items.Add(n); 
            //}
            #endregion

            #region Linq list_names
            string txt = txtSearch.Text.ToLower();
            IEnumerable<string> res2 = from name in list_names where name.ToLower().StartsWith(txt) select name;

            list.Items.AddRange(res2.ToArray());

            //foreach (string name in list_names)
            //{
            //    list.Items.Add(name);
            //}
            #endregion

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            list.Items.Clear();

            string txt = txtSearch.Text.ToLower();
            var res = from name in list_names 
                      where name.ToLower().Contains(txt)
                      select name;

            list.Items.AddRange(res.ToArray());


        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {

            list.Items.Clear();
            string txt = txtSearch.Text.ToLower();

            //var res = from num in list_numbers 
            //          orderby num descending //
            //          where num <= 10 
            //          select num;


            var res = from num in list_products orderby num.Value select num;

            foreach (var item in res)
            {
                list.Items.Add(item);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        { 
            list.Items.Clear();
            string txt = txtSearch.Text.ToLower();

            var res = from state in list_states
                      group state by state.Value;

            foreach (var group in res)
            { 
                list.Items.Add(group.Key);
                foreach (var state in group)
                {
                    list.Items.Add(" -> "+state.Key);
                }
            }


        }

        private void btnAggregate_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            int cont1 = list_names.Count();
            int cont2 = (from name in list_names where name.StartsWith("G") select name).Count(); 

            list.Items.Add(cont1 + " names!");
            list.Items.Add(cont2 + " names starts with 'G'");

            double average = list_numbers.Average(); 
            list.Items.Add(average + " average");

            int sum = list_numbers.Sum();
            list.Items.Add(sum + " values sum");

            list.Items.Add(" ");
            list.Items.Add(list_numbers.Min()+" Minimum value");
            list.Items.Add(list_numbers.Max() + " Maximum value");
            list.Items.Add(" ");

            string biggerName = list_names.Aggregate((bigger, next) =>
            {
                if(bigger.Length > next.Length)
                {
                    return bigger;
                } else
                {
                    return next;
                }

            });

            list.Items.Add(biggerName + " is the bigger name in the list");

            int bigSmall = list_numbers.Aggregate((s1, s2) => s1+s2);
            list.Items.Add(bigSmall + " total sum");
            list.Items.Add(" ");
            int smallSumBig = list_numbers.Min() + list_numbers.Max();
            list.Items.Add(smallSumBig + " bigger and smaller number sum");

        }

        private void btnElement_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            int first = list_numbers.FirstOrDefault();
            list.Items.Add(first);
            int last = list_numbers.LastOrDefault();
            list.Items.Add(last);

            int element = list_numbers.ElementAtOrDefault(3); 
            //OrDefault
            //IEnumerable can be used with LINQ
            list.Items.Add(element);


        }

        private void btnLinqLambda_Click(object sender, EventArgs e)
        {
            list.Items.Clear();

            var const1 = from name in list_names select name; 

            //var const1 = list_names.Select(name => name); //Lambda
            //list.Items.AddRange(const1.ToArray());

            //var const2 = from name in list_names where name.StartsWith("G") select name;
            //var const2L = list_names.Where(name => name.StartsWith("G")); //Lambda
            //list.Items.AddRange(const2L.ToArray());

            //var const3 = from name in list_names orderby name select name;
            //var const3L = list_names.OrderBy(name => name);
            //var const3L2 = list_names.OrderByDescending(name => name);

            //list.Items.AddRange(const3L2.ToArray());

            //var const4 = from state in list_states group state by state.Value;

            var const4L = list_states.GroupBy(state => state.Value);

            foreach (var group in const4L)
            {
                list.Items.Add(group.Key);
                foreach (var item in group)
                {
                    list.Items.Add(" -> " + item.Key);
                }
            }


        }
    }
}
