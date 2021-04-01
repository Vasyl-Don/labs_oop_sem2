using System;

namespace oop_3
{
    class BoolArr
    {
        private bool[] array;   // Масив елементів булевого типу
        private bool logic_add; // Результат логічного додавання всіх елементів масиву
        private int length;     // Довжина масиву

        // Конструктор
        public BoolArr(int size)
        {
            Random random = new Random();
            this.array = new bool[size];
            for(int i = 0; i < size; i++)
            {
                this.array[i] = random.Next(2) == 1;
            }
            length = size;
        }

        // get для результату логічного додавання
        public bool LogicAdd
        {
            get
            {
                logic_add = false;
                foreach(bool item in this.array)
                    if(item)
                    {
                        logic_add = true;
                    }
                return logic_add;
            }
        }

        // Індексатор, що запобігає порушенню границі масиву та повертає
        // обернене значення заданого індексом елемента масиву
        public bool this[int index]
        {
            get
            {
                try
                {
                    if (Ok(index))
                    {
                        return !this.array[index];
                    }
                    else throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Границi масиву порушенi");
                    return false;
                }
            }
            set
            {
                try
                {
                    if (Ok(index))
                    {
                        this.array[index] = !value;
                    }
                    else throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Границi масиву порушенi!");
                }
            }
        }
        
        // Перевірка, чи не порушені границі масиву
        private bool Ok(int index)
        {
            if (index >= 0 && index < length) return true;
            return false;
        }
    }
}
