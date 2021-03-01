using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    class DogsController
    {
        List<Dog> DogsDB = new List<Dog>();

        public List<Dog> GetAll()
        {
            return DogsDB;
        }

        public void Add(Dog dog)
        {
            DogsDB.Add(dog);
        }

        public void DeleteLast()
        {
            int index = DogsDB.Count - 1;
            DogsDB.RemoveAt(index);
        }

        public void DeleteByID(int id)
        {
            DogsDB.RemoveAt(id - 1);

        }
        public void UpdateByID(Dog dog)
        {
            for (int i = 0; i < DogsDB.Count; i++)
            {
                if (DogsDB[i].Id == dog.Id)
                {
                    DogsDB[i].Name = dog.Name;
                    DogsDB[i].Age = dog.Age;
                }
            }
        }
    }
}

