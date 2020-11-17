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

        public object Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(string name, object value)
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name) && Value is null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Name) || !(Value is null);
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.Setting, Name, Value);

        public override string ToString()
            => Format();

        string ICmdArg.Key
            => Name;

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(Pair<string> src)
            => new CmdArg(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg((string name, object value) src)
            => new CmdArg(src.name, src.value);

        public static CmdArg Empty
        {
            [MethodImpl(Inline)]
            get => new CmdArg(EmptyString, EmptyString);
        }
    }
}