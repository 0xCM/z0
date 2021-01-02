//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    readonly struct TestLogPaths : ITestLogPaths
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public TestLogPaths(FS.FolderPath root)
            => Root = root;
    }
}