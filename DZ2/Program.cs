using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("__Приклад роботи Counter__");
            Counter counter = new Counter(0);

            Console.WriteLine($"Counter зараз: {counter.Value}");

            counter.Increment();
            Console.WriteLine($"Counter після Increment: {counter.Value}");

            counter.Decrement();
            Console.WriteLine($"Counter після Decrement:{counter.Value}");

            counter.TryDecrement();
            Console.WriteLine($"Counter після TryDecrement:{counter.Value}");

            counter.Increment();
            counter.Increment();
            counter.Increment();
            Console.WriteLine($"Сбільшили Counter три рази Increment-ом: {counter.Value}");
            counter.Reset();
            Console.WriteLine($"Counter після Reset:  {counter.Value}");



            Console.WriteLine("__Приклад роботи TodoItem__");
            TodoItem todoItem = new TodoItem("Кушац", true);

            Console.WriteLine($"Назва: {todoItem.Title}, виконана: {todoItem.IsDone}");

            todoItem.MarkDone();
            Console.WriteLine($"Після MarkDone: Назва: {todoItem.Title}, виконана: {todoItem.IsDone}");

            todoItem.MarkUndone();
            Console.WriteLine($"Після MarkUndone: Назва: {todoItem.Title}, виконана: {todoItem.IsDone}");

            bool renamed = todoItem.TryRename("Не Кушац");
            Console.WriteLine($"TryRename успішно: {renamed}, нова назва: {todoItem.Title}");

            renamed = todoItem.TryRename("   ");
            Console.WriteLine($"TryRename успішно: {renamed}, назва залишилась: {todoItem.Title}");


        }
    }
}
