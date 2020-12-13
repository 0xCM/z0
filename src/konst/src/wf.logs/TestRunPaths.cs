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

    public readonly struct TestRunPaths : ITestRunPaths
    {
        [MethodImpl(Inline), Op]
        public static ITestRunPaths define(FS.FolderPath root)
            => new TestRunPaths(root);

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public TestRunPaths(FS.FolderPath root)
            => Root = root;
    }
}