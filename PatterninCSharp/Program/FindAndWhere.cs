using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class FindAndWhere
    {
        public static void FindAndWhereDiff()
        {
            List<Employee> oList = new List<Employee>
            {
                new Employee{ID=1,Name="John"},
                new Employee{ID=2,Name="Jacob"},
                new Employee{ID=3,Name="Lisa"},
                new Employee{ID=4,Name="Rony"},
                new Employee{ID=4,Name="John"},
            };

            var emp = oList.Where(e => e.Name == "John");// return two list 
            var emfp = oList.Where(e => e.Name == "John").FirstOrDefault();

            var emp1 = oList.Find(e => e.Name == "John"); // return 1 list

            #region Answer 
            //The Where and FirstOrDefault methods are applicable against multiple kinds
            //of sequences, including List<T>, T[], Collection< T >, etc.Any sequence
            //that implements IEnumerable<T> can use these methods.Find is available only
            //for the List< T >.Methods that are generally more applicable, are then more
            //reusable and have a greater impact. 

            //Find is only implemented in List<T>, while Where().FirstOrDefault()
            //works with all IEnumerable<T>.
            #endregion

        }
        public class Employee
        {
            public int ID { get; set; }
            public string? Name { get; set; }
        }
    }
}
