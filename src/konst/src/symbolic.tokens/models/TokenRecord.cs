//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Record]
    public struct TokenRecord : IRecord<TokenRecord>
    {
        public Sequential Index;

        public string Identifier;

        public string Value;

        public string Description;

        [MethodImpl(Inline)]
        public TokenRecord(uint index, string id, string value, string description)
        {
            Index = index;
            Identifier = id ?? EmptyString;
            Value = value ?? EmptyString;
            Description = description ?? EmptyString;
        }
    }
}