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

    public struct CmdArg : ICmdArg
    {
        public string Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public CmdArg(string name)
        {
            Name = name;
            Value = EmptyString;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.Setting, Name, Value);

        public override string ToString()
            => Format();

        string ICmdArg.Key
            => Name;

        string ICmdArg.Value
            => Value;

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(Pair<string> src)
            => new CmdArg(src.Left, src.Right);
    }
}