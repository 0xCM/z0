//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using Microsoft.CodeAnalysis;

    using static Root;

    using static CodeSymbolics;

    public readonly struct Compilation<T>
        where T : Compilation
    {
        public T Source {get;}

        [MethodImpl(Inline)]
        public Compilation(T src)
        {
            Source = src;
        }

        public AssemblySymbol GetAssemblySymbol(MetadataReference src)
            => new AssemblySymbol((IAssemblySymbol)Source.GetAssemblyOrModuleSymbol(src));

        [MethodImpl(Inline)]
        public static implicit operator Compilation<T>(T src)
            => new Compilation<T>(src);
    }
}