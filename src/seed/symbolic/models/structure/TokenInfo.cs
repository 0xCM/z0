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
        public readonly int Index;
        
        public readonly string Identifier;

        public readonly string Value;

        public readonly string Description;

        [MethodImpl(Inline)]
        public static TokenInfo Define<T>(T index, string id, string value, string description)
            where T : unmanaged, Enum
                => new TokenInfo(Enums.e32i(index),id, value, description);        

        [MethodImpl(Inline)]
        public TokenInfo(int index, string id, string value, string description)
        {
            Index = index;
            Identifier = id ?? text.Empty;
            Value = value ?? text.Empty;
            Description = description ?? text.Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier) || text.empty(Value);
        }

        public static TokenInfo Empty 
            => new TokenInfo(0,text.Empty, text.Empty, text.Empty);
    }
}