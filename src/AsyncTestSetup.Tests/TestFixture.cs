using System;
using System.Threading.Tasks;
using Xunit;

namespace AsyncTestSetup.Tests
{
    public class TestFixture : IAsyncLifetime, IDisposable
    {
        public string HeaderText { get; set; }

        public Task InitializeAsync() 
        {            
            Init2();
            return Task.CompletedTask;
        }

        private void Init1() => HeaderText = "Async init successful";
        private void Init2() => HeaderText = "Async init unsuccessful";

        public Task DisposeAsync() => Task.CompletedTask;

        public void Dispose()
        {
            HeaderText = string.Empty;
        }
    }
}