using System;
using System.Threading.Tasks;
using Xunit;

namespace AsyncTestSetup.Tests
{
    public class TestFixture : IAsyncLifetime, IDisposable
    {
        public string HeaderText { get; set; }
        private Func<string, TestFixture, Task> _initMethod;
        private string _initMethodInput;


        public TestFixture(Func<string, TestFixture, Task> initMethod, string initMethodInput)
        {
            _initMethod = initMethod;
            _initMethodInput = initMethodInput;
        }

        public Task InitializeAsync()
        {            
            _initMethod(_initMethodInput, this);
            return Task.CompletedTask;
        }

        public Task DisposeAsync() => Task.CompletedTask;

        public void Dispose()
        {
            HeaderText = string.Empty;
        }


        public static Task Init(string text, TestFixture testFixture) 
        {
            testFixture.HeaderText = text;
            return Task.CompletedTask;
        }
    }
}