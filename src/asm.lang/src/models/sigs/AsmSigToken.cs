//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSigToken : IAsmSigToken
    {
        public string Symbol {get;}

        public AsmSigOpKind Kind {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public AsmSigToken(string symbol, AsmSigOpKind kind, string description)
        {
            Symbol = symbol;
            Kind = kind;
            Description = description;
        }
    }

    public readonly struct AsmSigToken<T> : IAsmSigToken<AsmSigToken<T>>
        where T : unmanaged, IAsmSigToken<T>
    {
        public T Token {get;}

        public string Symbol
        {
            [MethodImpl(Inline)]
            get => Token.Symbol;
        }

        public AsmSigOpKind Kind
        {
           [MethodImpl(Inline)]
            get => Token.Kind;
        }

        public string Description
        {
           [MethodImpl(Inline)]
            get => Token.Description;
        }

        [MethodImpl(Inline)]
        public AsmSigToken(T token)
        {
            Token = token;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmSigToken<T>(T src)
            => new AsmSigToken<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigToken(AsmSigToken<T> src)
            => new AsmSigToken(src.Symbol, src.Kind, src.Description);
    }
}