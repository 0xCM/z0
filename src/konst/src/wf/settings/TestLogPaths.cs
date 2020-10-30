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
        public FS.FolderPath RuntimeData {get;}

        public FS.FolderPath RuntimeLogs {get;}

        public TestLogPaths(FS.FolderPath dir)
        {
            RuntimeLogs = dir;
            RuntimeData = dir;
        }
    }
}