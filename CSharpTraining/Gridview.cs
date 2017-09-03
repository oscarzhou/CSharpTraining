using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharpTraining
{
    public partial class Gridview : Form
    {
        public Gridview()
        {
            InitializeComponent();
            List<Employee> lstEmployees = new List<Employee>();
            foreach (DataGridViewRow row in dgvTest1.Rows)
            {
                Employee e = new Employee()
                {
                    //id = Convert.ToInt32(row["id"]`),
                    //name = row["name"],
                    //dipId = Convert.ToInt32(row["dipid"]) 
              
                };
                lstEmployees.Add(e);
            }
            var nameList = (from e in lstEmployees where e.dipId == 10 select e.name) ;

            foreach (string s in nameList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
