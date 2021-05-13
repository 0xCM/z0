//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.CodeAnalysis;

    using static Part;

    public readonly struct CodeSymbol<H,T> : ICodeSymbol<H,T>
        where T : ICodeSymbol
        where H : ICodeSymbols<H,T>, new()
    {
        readonly CodeSymbols<H,T> Source;

        readonly uint Index;

        [MethodImpl(Inline)]
        internal CodeSymbol(CodeSymbols<H,T> src, uint index)
        {
            Source  = src;
            Index = index;
        }

        public T Symbol
        {
            [MethodImpl(Inline)]
            get => Source.Subject(Index);
        }

        ISymbol ICodeSymbol.Symbol
            => Symbol.Symbol;

        [MethodImpl(Inline)]
        public static implicit operator CodeSymbol<T>(CodeSymbol<H,T> src)
            => new CodeSymbol<T>(src.Symbol);
    }
}