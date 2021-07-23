//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CmdOptions<K> : IIndexedView<CmdOptions<K>,ushort,CmdOption<K>>
        where K : unmanaged
    {
        readonly Index<CmdOption<K>> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdOption<K>[] src)
            => Data = src;

        public CmdOption<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdOption<K>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public string Format()
            => Seq.format(Storage);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions<K>(CmdOption<K>[] src)
            => new CmdOptions<K>(src);
    }
}