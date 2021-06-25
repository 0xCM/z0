//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct CmdSpec<K>
        where K : unmanaged
    {
        public K Id {get;}

        public StringIndex Args {get;}

        [MethodImpl(Inline)]
        public CmdSpec(K id, StringIndex args)
        {
            Id = id;
            Args = args;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => u64(Id) == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => u64(Id) != 0;
        }

        public static CmdSpec<K> Empty
        {
            [MethodImpl(Inline)]
            get => new CmdSpec<K>(default, StringIndex.Empty);
        }
    }
}