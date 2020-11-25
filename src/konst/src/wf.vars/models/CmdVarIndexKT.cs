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

    public readonly struct CmdVarIndex<K,T> : IIndex<CmdVar<K,T>>
        where K : unmanaged
    {
        readonly CmdVar<K,T>[] Data;

        [MethodImpl(Inline)]
        public CmdVarIndex(CmdVar<K,T>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdVarIndex<K,T>(CmdVar<K,T>[] src)
            => new CmdVarIndex<K,T>(src);

        public CmdVar<K,T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdVar<K,T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<CmdVar<K,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Length;
        }

        public ref CmdVar<K,T> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}