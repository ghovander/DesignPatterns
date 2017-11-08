using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingleResponsibilityPriniciple
{
    class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count; //memento
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }
    }
}
