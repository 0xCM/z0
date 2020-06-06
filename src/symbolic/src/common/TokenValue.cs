//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public enum TokenContentKind : byte
    {
        None = 0,

        U8 = 1,
        
        C8 = 2,

        C16 = 3
    }

    public readonly struct TokenValue
    {
        [MethodImpl(Inline)]
        public static TokenValue Define(byte[] content, TokenContentKind kind = TokenContentKind.C8)
            => new TokenValue(content, kind);
        
        public byte[] Content {get;}

        public TokenContentKind ContentKind {get;}

        [MethodImpl(Inline)]
        public TokenValue(byte[] src, TokenContentKind kind)
        {
            Content = src;
            ContentKind = kind;
        }
    }
    
    public readonly struct TokenValue<T>
    {
        public readonly T[] Content;

        [MethodImpl(Inline)]
        public TokenValue(T[] src)
        {
            Content = src;
        }
    }
}