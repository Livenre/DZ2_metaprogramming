using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public sealed class TodoItem
    {
        private string _title;
        private bool _isDone;

        public string Title
        {
            get { return this._title; }
        }

        public bool IsDone
        {
            get { return this._isDone; }
        }

        public TodoItem(string title) : this(title, false) { }

        public TodoItem(string title, bool isDone)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Задача пуста або написана пробілами", nameof(title));
            }
            this._title = title;
            this._isDone = isDone;
        }

        public void MarkDone()
        {
            this._isDone = true;
        }

        public void MarkUndone()
        {
            this._isDone = false;
        }

        public bool TryRename(string newTitle)
        {
            if (string.IsNullOrWhiteSpace(newTitle))
            {
                return false;
            }
            this._title = newTitle;
            return true;
        }
    }
}








