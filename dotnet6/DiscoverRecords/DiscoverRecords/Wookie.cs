using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverRecords
{
    public record Wookie1(int Id, string Surname)
    {
        public int NbPoils { get; init; } = default!;
    };

    public record Wookie2()
    {
        public int Id { get; init; } = default;

        public string Surname { get; init; } = default!;
    }
}
