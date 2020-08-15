//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public enum TokenField : ushort
    {
        Index = 8,

        Identifier = 32,

        Value = 32,

        Description = 120
    }

    public readonly struct TokenModel : ITable<TokenField,TokenModel>
    {        
        public readonly int Index;
        
        public readonly StringRef Identifier;

        public readonly StringRef Value;

        public readonly StringRef Description;

        [MethodImpl(Inline)]
        public TokenModel(int index, string id, string value, string description)
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
        
        public static TokenModel Empty 
            => new TokenModel(0, EmptyString, EmptyString, EmptyString);
    }
}