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

    public struct CmdOption : ICmdOption
    {
        public string Name;

        public string Value;

        [MethodImpl(Inline)]
        public CmdOption(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public CmdOption(string name)
        {
            Name = name;
            Value = EmptyString;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdOption(Pair<string> src)
            => new CmdOption(src.Left, src.Right);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.Setting, Name, Value);

        public override string ToString()
            => Format();

        string ICmdOption.Name
            => Name;

        string ICmdOption.Value
            => Value;
    }
}