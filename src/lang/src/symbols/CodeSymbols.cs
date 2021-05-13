//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.CodeAnalysis;

    using static Root;
    using static CodeSymbolics;

    public readonly partial struct CodeSymbolics
    {

    }

    [ApiHost]
    public readonly struct CodeSymbols
    {
        public static string format<T>(T src)
            where T : ICodeSymbol
                => src.Source?.ToDisplayString() ?? "<null>";

        [MethodImpl(Inline), Op]
        public static CodeSymbol from(ISymbol src)
            => new CodeSymbol(src);

        [MethodImpl(Inline), Op]
        public static AssemblySymbol from(IAssemblySymbol src)
            => new AssemblySymbol(src);

        [MethodImpl(Inline), Op]
        public static ModuleSymbol from(IModuleSymbol src)
            => new ModuleSymbol(src);

        [MethodImpl(Inline), Op]
        public static NamespaceSymbol from(INamespaceSymbol src)
            => new NamespaceSymbol(src);

        [MethodImpl(Inline), Op]
        public static NamedTypeSymbol from(INamedTypeSymbol src)
            => new NamedTypeSymbol(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> convert<T>(ReadOnlySpan<CodeSymbol> src)
            where T : ICodeSymbol
                => memory.recover<CodeSymbol,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> materialize<S,T>(ReadOnlySpan<S> src, T target = default)
            where S : ISymbol
            where T : ICodeSymbol
                => memory.recover<S,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<CodeSymbol> materialize<S>(ReadOnlySpan<S> src)
            where S : ISymbol
                => memory.recover<S,CodeSymbol>(src);

        [MethodImpl(Inline)]
        public static CodeSymbols<T> index<T>(T[] src)
            where T : ISymbol
                => src;

        [MethodImpl(Inline)]
        public static CodeSymbol<T> define<T>(T src)
            where T : ISymbol
                => new CodeSymbol<T>(src);
    }
}