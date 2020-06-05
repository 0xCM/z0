//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct Token
    {        
        public readonly int Index;
        
        public readonly string Identifier;

        public readonly string Value;

        public readonly string Description;

        public static Token Empty => new Token(0,text.Empty, text.Empty, text.Empty);

        [MethodImpl(Inline)]
        public static Token Define<T>(T index, string id, string value, string description)
            where T : unmanaged, Enum
                => new Token(Enums.i32(index),id, value, description);        

        [MethodImpl(Inline)]
        public static Token Define(int index, string id, string value, string description)
            => new Token(index,id,value, description);        

        [MethodImpl(Inline)]
        public Token(int index, string id, string value, string description)
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
    }
}