//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PathSetting : ITextual
    {
        public string Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public PathSetting(string name, string value)
        {
            Name = name;
            Value = value ?? EmptyString;
        }

        [MethodImpl(Inline)]
        public string Format(bool json)
            => json ? TextFormatter.format(RP.JsonProp, Name, Value) : Value;

        [MethodImpl(Inline)]
        public string Format()
            => Format(false);


        public override string ToString()
            => Format();
    }
}