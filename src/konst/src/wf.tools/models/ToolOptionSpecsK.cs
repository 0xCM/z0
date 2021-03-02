//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ToolOptionSpecs<K> : IIndexedView<ToolOptionSpecs<K>,ushort,ToolOptionSpec<K>>
        where K : unmanaged
    {
        readonly Index<ToolOptionSpec<K>> Data;

        [MethodImpl(Inline)]
        public ToolOptionSpecs(ToolOptionSpec<K>[] src)
            => Data = src;

        public ToolOptionSpec<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<ToolOptionSpec<K>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public string Format()
            => Seq.format(Storage);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolOptionSpecs<K>(ToolOptionSpec<K>[] src)
            => new ToolOptionSpecs<K>(src);
    }
}