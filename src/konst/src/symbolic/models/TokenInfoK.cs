//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TokenInfo<K>
        where K : unmanaged
    {
        public readonly Sequential Index;

        public readonly Kind<K> Kind;

        public readonly StringRef Identifier;

        public readonly StringRef Value;

        public readonly StringRef Description;

        [MethodImpl(Inline)]
        public TokenInfo(uint index, K kind, string id, string value, string description)
        {
            Index = index;
            Kind = kind;
            Identifier = id ?? EmptyString;
            Value = value;
            Description = description ?? EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Index != 0;
        }

        public string Format()
            => Render.format(Index, Kind, Identifier, Value, Description);
    }
}