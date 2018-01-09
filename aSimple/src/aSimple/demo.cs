using System;

namespace Playground {
    // Abstract class
    public abstract class Animal {
        // Property get and set
        public string name { get; set; }

        // Constructor
        public Animal(string name) {
            this.name = name;
        }

        public abstract void bark();

        public void log() {
            Console.WriteLine("Animal class " + name);
        }
    }

    // Public inheritance only
    public class Dog: Animal {
        // Constructor
        public Dog(string name) : base(name) { }

        // Override bark function
        public override void bark() {
            Console.WriteLine("Wang Wang");
        }

        // Explicitly hide log function from Animal class
        public new void log() {
            Console.WriteLine("Dog class " + name);
        }
    }

    // Public inheritance only
    public class Cat: Animal {
        // Constructor
        public Cat(string name) : base(name) { }

        // Override bark function
        public override void bark() {
            Console.WriteLine("Miao Miao");
        }

        // Explicitly hide log function from Animal class
        public new void log() {
            Console.WriteLine("Cat class " + name);
        }
    }

    class Program {
        static void Main(string[] args) {
            new Dog("").bark(); // output: Wang Wang
            new Cat("").bark(); // output: Miao Miao

            //////////////////
            // Polymorphism //
            //////////////////
            Animal ptr1 = new Dog("Dog #1");
            ptr1.bark(); // output: Wang Wang

            Animal ptr2 = new Cat("Cat #1");
            ptr2.bark(); // output: Miao Miao

            new Dog("Dog #2").log(); // output: Dog class Dog #2
            new Cat("Cat #2").log(); // output: Cat class Cat #2
            ptr1.log(); // output: Animal class Dog #1
            ptr2.log(); // output: Animal class Cat #1

            ptr1.name = "Dog name changed";
            ptr1.log(); // output: Animal class Dog name Changed
        }
    }
}
