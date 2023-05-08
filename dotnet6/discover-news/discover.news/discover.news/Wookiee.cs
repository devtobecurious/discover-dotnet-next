using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discover.news
{
    internal class Wookiee
    {
        string? name;

        public Wookiee(string name)
        {
            this.Name = name;
        }

        [return: MaybeNull]
        string GetName()
        {
            return null;
        }

        [return: NotNullIfNotNull(nameof(name))]
        public string? GetState(string? name)
        {
            return null;
        }

        public string? Name { get => name; set => name = value ?? throw new ArgumentNullException("Value not set"); }

        [MaybeNull]
        public string Surname { get; set; }
    }
}
