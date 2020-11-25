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
        public string Key {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(string name, string value)
        {
            Key = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public CmdArg(string value)
        {
            Key = EmptyString;
            Value = value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Key) && Value is null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Key) || !(Value is null);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.nonempty(Key) ? string.Format(RP.Setting, Key, Value) : Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();

        string ICmdArg.Key
            => Key;

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