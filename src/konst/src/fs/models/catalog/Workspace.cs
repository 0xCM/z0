//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        public readonly struct Workspace
        {
            public readonly Entry Root;

            public readonly Entry[] Files;

            [MethodImpl(Inline)]
            public Workspace(Entry root, Entry[] files)
            {
                Root = root;
                Files = files;
            }
        }
    }
}