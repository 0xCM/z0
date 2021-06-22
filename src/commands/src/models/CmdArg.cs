//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CmdArg
    {
        public ushort Index {get;}

        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(ushort index, dynamic value)
        {
            Index = index;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdArg((int index, dynamic value) src)
            => new CmdArg((ushort)src.index, src.value);

        public static CmdArg Empty
            => new CmdArg(0, EmptyString);
    }
}