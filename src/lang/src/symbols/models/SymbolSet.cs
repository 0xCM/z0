//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Microsoft.CodeAnalysis;

    using static Root;

    using api = CodeSymbols;

    partial struct CodeSymbolics
    {
        public ref struct SymbolSet
        {
            public static SymbolSet create(params MetadataReference[] metadata)
                => new SymbolSet();


            SymbolSet(params MetadataReference[] metadata)
                : this()
            {
                Metadata = metadata;
            }

            public ReadOnlySpan<CodeSymbol> Untyped {get; private set;}

            public ReadOnlySpan<MetadataReference> Metadata {get;}

            public ReadOnlySpan<AssemblySymbol> Assemblies {get; private set;}

            public ReadOnlySpan<TypeSymbol> Types {get; private set;}

            public ReadOnlySpan<MethodSymbol> Methods {get; private set;}

            public SymbolSet Replace(ReadOnlySpan<CodeSymbol> src)
            {
                Untyped = src;
                return this;
            }

            public SymbolSet Replace(ReadOnlySpan<AssemblySymbol> src)
            {
                Assemblies = src;
                return this;
            }

            public SymbolSet Replace(ReadOnlySpan<TypeSymbol> src)
            {
                Types = src;
                return this;
            }

            public SymbolSet Replace(ReadOnlySpan<MethodSymbol> src)
            {
                Methods = src;
                return this;
            }


            public static SymbolSet Empty => default;
        }
    }
}