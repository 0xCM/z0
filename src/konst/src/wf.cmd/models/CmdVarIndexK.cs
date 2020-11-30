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

    public readonly struct CmdVarIndex<K> : IIndex<CmdVar<K>>
        where K : unmanaged
    {
        readonly CmdVar<K>[] Data;

        [MethodImpl(Inline)]
        public CmdVarIndex(CmdVar<K>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdVarIndex<K>(CmdVar<K>[] src)
            => new CmdVarIndex<K>(src);

        public CmdVar<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdVar<K>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<CmdVar<K>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Length;
        }

        public ref CmdVar<K> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}