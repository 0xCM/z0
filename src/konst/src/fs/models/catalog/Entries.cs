//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FSO
    {
        public readonly struct Entries
        {
            public readonly FS.Entry Root;

            readonly FS.Entry[] Data;

            [MethodImpl(Inline)]
            public Entries(FS.Entry root, FS.Entry[] objects)
            {
                Root = root;
                Data = objects;
            }

            public ReadOnlySpan<FS.Entry> View
            {
                [MethodImpl(Inline)]
                get => Data;
            }
        }
    }
}