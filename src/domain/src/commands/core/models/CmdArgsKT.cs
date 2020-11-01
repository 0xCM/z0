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

    using api = Cmd;

    public readonly struct CmdOptions<K,T> : ITextual
        where K : unmanaged
    {
        readonly TableSpan<CmdArg<K,T>> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdArg<K,T>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions<K,T>(CmdArg<K,T>[] src)
            => new CmdOptions<K,T>(src);

        public ReadOnlySpan<CmdArg<K,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref CmdArg<K,T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}