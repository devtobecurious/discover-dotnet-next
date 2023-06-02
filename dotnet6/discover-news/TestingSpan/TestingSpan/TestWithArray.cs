using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSpan
{
    [MemoryDiagnoser()]
    public class TestWithArray
    {
        private int[] array = new int[10000];

        [Benchmark()]
        public void Compute()
        {
            this.Fill();
        }

        [Benchmark()]
        public void Fill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 100;
            }
        }

        [Benchmark()]
        public void FillWithSpan()
        {
            Span<int> span = new Span<int>(array);

            span.Fill(10);
        }
    }
}
