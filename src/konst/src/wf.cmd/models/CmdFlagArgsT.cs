//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdFlagArgs<T> : IIndex<CmdFlagArg<T>>
        where T : unmanaged
    {
        readonly IndexedSeq<CmdFlagArg<T>> Data;

        [MethodImpl(Inline)]
        public CmdFlagArgs(CmdFlagArg<T>[] src)
            => Data = src;

        public CmdFlagArg<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdFlagArgs<T>(CmdFlagArg<T>[] src)
            => new CmdFlagArgs<T>(src);
    }
}