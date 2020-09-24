//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TokenInfo
    {
        public readonly Sequential Index;

        public readonly StringRef Identifier;

        public readonly StringRef Value;

        public readonly StringRef Description;

        [MethodImpl(Inline)]
        public TokenInfo(uint index, string id, string value, string description)
        {
            Index = index;
            Identifier = id ?? EmptyString;
            Value = value;
            Description = description ?? EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Identifier) || text.blank(Value);
        }

        public string Format()
            => string.Concat(Identifier, " := ", Value, "; ", Description);

        public static TokenInfo Empty
            => default;
    }
}