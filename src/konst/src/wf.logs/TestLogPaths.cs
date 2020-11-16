//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TestLogPaths : ITestLogPaths
    {
        [MethodImpl(Inline), Op]
        public static ITestLogPaths define(FS.FolderPath root)
            => new TestLogPaths(root);

        public FS.FolderPath LogRoot {get;}

        [MethodImpl(Inline)]
        public TestLogPaths(FS.FolderPath dir)
        {
            LogRoot = dir;
        }
    }

    public readonly struct TestLogPaths<A> : ITestLogPaths<A>
    {
        public FS.FolderPath LogRoot {get;}

        [MethodImpl(Inline)]
        public TestLogPaths(FS.FolderPath dir)
        {
            LogRoot = dir;
        }
    }
}