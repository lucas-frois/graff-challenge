﻿using Graff.Api.Entities.ValueObjects;

namespace Graff.Api.Entities
{
    public class Person : Entity
    { 
        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
