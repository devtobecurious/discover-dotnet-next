using BenchmarkDotNet.Running;
using TestingSpan;

BenchmarkRunner.Run<TestWithArray>();

TestWithArray test = new();
test.Compute();