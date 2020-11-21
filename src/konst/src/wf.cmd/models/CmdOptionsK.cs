//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdOptions<K> : IIndexedView<CmdOptions<K>,ushort,CmdOption<K>>
        where K : unmanaged
    {
        readonly IndexedView<CmdOption<K>> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdOption<K>[] src)
            => Data = src;

        public CmdOption<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdOption<K>> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions<K>(CmdOption<K>[] src)
            => new CmdOptions<K>(src);
    }
}