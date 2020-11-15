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

    public readonly struct ToolOptions<K> : IIndexedView<ToolOptions<K>,ushort,ToolOption<K>>
        where K : unmanaged
    {
        readonly IndexedView<ToolOption<K>> Data;

        [MethodImpl(Inline)]
        public ToolOptions(ToolOption<K>[] src)
            => Data = src;

        public ToolOption<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<ToolOption<K>> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolOptions<K>(ToolOption<K>[] src)
            => new ToolOptions<K>(src);
    }
}