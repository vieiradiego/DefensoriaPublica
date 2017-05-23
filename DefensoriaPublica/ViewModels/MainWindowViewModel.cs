using DefensoriaPublicaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefensoriaPublica.ViewModels
{
    public class MainWindowViewModel
    {
        public List<Person> Persons { get; set; }

        public MainWindowViewModel()
        {
            //this.Persons = new DefensoriaPublicaDBContext().Persons.Where(person => person.Age > 15).ToList() ;

            this.Persons = new DefensoriaPublicaDBContext().Persons.ToList();
            
        }
    }
}
