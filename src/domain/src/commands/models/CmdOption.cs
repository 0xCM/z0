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

    public readonly struct CmdOption
    {
        public ulong Id {get;}

        public BinaryCode Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(ulong kind, BinaryCode value)
        {
            Id = kind;
            Value = value;
        }
    }
}