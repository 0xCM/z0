//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdArgs<K,T> : IIndex<CmdArg<K,T>>
        where K : unmanaged
    {
        readonly Index<CmdArg<K,T>> Data;

        [MethodImpl(Inline)]
        public CmdArgs(CmdArg<K,T>[] src)
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
            => Cmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArgs<K,T>(CmdArg<K,T>[] src)
            => new CmdArgs<K,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ToolCmdArgs(CmdArgs<K,T> src)
            => new ToolCmdArgs(src.Storage.Select(x => (ToolCmdArg)x));
    }
}