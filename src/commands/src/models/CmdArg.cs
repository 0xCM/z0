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
        public uint Index {get;}

        public string Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(uint index, string value)
        {
            Index = index;
            Value = value;
            Name = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(uint index, string name, string value)
        {
            Index = index;
            Value = value;
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator string(CmdArg arg)
            => arg.Value;

        [MethodImpl(Inline)]
        public static implicit operator CmdArg((int index, string value) src)
            => new CmdArg((ushort)src.index, src.value);

        public static CmdArg Empty
            => new CmdArg(0, EmptyString);
    }
}