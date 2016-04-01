﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OutOfProcessXunitTest.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace OutOfProcessXunitTest
{
    public class Tests
    {
        private readonly ITestOutputHelper _Output;

        public Tests(ITestOutputHelper output)
        {
            _Output = output;
        }

        [OutOfProcessFact]
        public void OutOfProcess()
        {
            _Output.WriteLine("Process name: " + Process.GetCurrentProcess().ProcessName);
            Assert.Equal(5, 3);
        }

        [Fact]
        public void InProcess()
        {
            _Output.WriteLine("Process name: " + Process.GetCurrentProcess().ProcessName);
            Assert.Equal(5, 3);
        }
    }
}
