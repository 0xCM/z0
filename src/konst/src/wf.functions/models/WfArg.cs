//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfArg
    {
        public readonly string Name;

        public readonly string Value;

        [MethodImpl(Inline)]
        public WfArg(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public bool IsEmpty
            => string.IsNullOrWhiteSpace(Value);

        public bool IsNonEmpty
            => !IsEmpty;

        [MethodImpl(Inline)]
        public static implicit operator WfArg((string name, string value) src)
            => new WfArg(src.name, src.value);

        public static WfArg Empty
            => new WfArg("", "");
    }
}

