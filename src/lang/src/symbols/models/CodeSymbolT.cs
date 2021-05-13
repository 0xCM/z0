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

    public readonly struct CodeSymbol<T>
        where T : ICodeSymbol
    {
        public T Subject {get;}

        [MethodImpl(Inline)]
        public CodeSymbol(T src)
        {
            Subject = src;
        }

        public ISymbol Untyped
        {
            [MethodImpl(Inline)]
            get => Subject.Symbol;
        }

        public SymbolKind Kind
        {
            [MethodImpl(Inline)]
            get => Untyped.Kind;
        }

        public string Language
        {
            [MethodImpl(Inline)]
            get => Untyped.Language;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Untyped.Name;
        }

        public string MetadataName
        {
            [MethodImpl(Inline)]
            get => Untyped.MetadataName;
        }

        [MethodImpl(Inline)]
        public static implicit operator CodeSymbol(CodeSymbol<T> src)
            => new CodeSymbol(src.Untyped);
    }
}