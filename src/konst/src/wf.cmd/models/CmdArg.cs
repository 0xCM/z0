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
        public string Prefix {get;}

        public string Name {get;}

        public string Value {get;}

        public string Qualifier {get;}

        [MethodImpl(Inline)]
        public CmdArg(string prefix, string name, string value)
        {
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(string prefix, string name, string specifier, string value)
        {
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = specifier;
        }

        [MethodImpl(Inline)]
        public CmdArg(string name, string value)
        {
            Name = name;
            Value = value;
            Prefix = EmptyString;
            Qualifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(string value)
        {
            Name = EmptyString;
            Value = value;
            Prefix = EmptyString;
            Qualifier = EmptyString;
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
            => text.nonempty(Name) ? string.Format(RP.Setting, Name, Value) : Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(Pair<string> src)
            => new CmdArg(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg((string name, string value) src)
            => new CmdArg(src.name, src.value);

        public static CmdArg Empty
        {
            [MethodImpl(Inline)]
            get => new CmdArg(EmptyString, EmptyString);
        }
    }
}