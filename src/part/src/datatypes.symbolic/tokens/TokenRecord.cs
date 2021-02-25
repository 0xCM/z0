//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record]
    public struct TokenRecord : IRecord<TokenRecord>
    {
        public ushort Index;

        public Identifier Name;

        public string Value;

        public string Description;

        [MethodImpl(Inline)]
        public TokenRecord(ushort index, string id, string value, string description)
        {
            Index = index;
            Name = id ?? EmptyString;
            Value = value ?? EmptyString;
            Description = description ?? EmptyString;
        }
    }
}