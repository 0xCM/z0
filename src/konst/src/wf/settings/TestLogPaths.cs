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
        public FS.FolderPath LogDir {get;}

        public TestLogPaths(FS.FolderPath dir)
        {
            LogDir = dir;
        }
    }
}