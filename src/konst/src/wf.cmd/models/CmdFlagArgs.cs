//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdFlagArgs : IIndex<CmdFlagArg>
    {
        readonly Index<CmdFlagArg> Data;

        [MethodImpl(Inline)]
        public CmdFlagArgs(CmdFlagArg[] src)
            => Data = src;

        public CmdFlagArg[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdFlagArgs(CmdFlagArg[] src)
            => new CmdFlagArgs(src);
    }
}