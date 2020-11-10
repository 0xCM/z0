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

    public readonly struct CmdArgs<K,T> : ITextual
        where K : unmanaged
    {
        readonly TableSpan<CmdArg<K,T>> Data;

        [MethodImpl(Inline)]
        public CmdArgs(CmdArg<K,T>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdArgs<K,T>(CmdArg<K,T>[] src)
            => new CmdArgs<K,T>(src);

        public ReadOnlySpan<CmdArg<K,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public CmdArg<K,T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
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