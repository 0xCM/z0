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

    public readonly struct CmdArgIndex<K,T> : ITextual, IIndex<CmdArg<K,T>>
        where K : unmanaged
    {
        readonly TableSpan<CmdArg<K,T>> Data;

        [MethodImpl(Inline)]
        public CmdArgIndex(CmdArg<K,T>[] src)
            => Data = src;

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
            => CmdFormat.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArgIndex<K,T>(CmdArg<K,T>[] src)
            => new CmdArgIndex<K,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator CmdArgIndex(CmdArgIndex<K,T> src)
            => new CmdArgIndex(src.Storage.Select(x => (CmdArg)x));
    }
}