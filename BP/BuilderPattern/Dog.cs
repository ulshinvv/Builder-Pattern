using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _age;
        private List<string> _toys;

        private Dog()
        {
            _toys = new List<string>();
        }

        public string Name
        {
            get { return _name; }
        }

        public string Breed
        {
            get { return _breed; }
        }

        public int Age
        {
            get { return _age; }
        }

        public List<string> Toys
        {
            get { return new List<string>(_toys); }
        }

        public class Builder
        {
            private Dog _dog;

            public Builder()
            {
                _dog = new Dog();
            }

            public Builder SName(string name)
            {
                _dog._name = name;
                return this;
            }

            public Builder SBreed(string breed)
            {
                _dog._breed = breed;
                return this;
            }

            public Builder SAge(int age)
            {
                _dog._age = age;
                return this;
            }

            public Builder SToy(string toy)
            {
                _dog._toys.Add(toy);
                return this;
            }

            public Dog Build()
            {
                return _dog;
            }
        }

    }
}
