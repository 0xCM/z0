//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct TestLogPaths : ITestLogPaths
    {
        public FS.FolderPath LogRoot {get;}

        public TestLogPaths(FS.FolderPath dir)
        {
            LogRoot = dir;
        }
    }

    public readonly struct TestLogPaths<A> : ITestLogPaths<A>
    {
        public FS.FolderPath LogRoot {get;}

        public TestLogPaths(FS.FolderPath dir)
        {
            LogRoot = dir;
        }
    }
}