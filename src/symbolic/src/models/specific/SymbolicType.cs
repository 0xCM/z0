//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct CodeSymbolModels
    {
        public readonly struct SymbolicType : ISymbolicArtifact<ClrType,TypeSymbol>
        {
            public ClrType Artifact {get;}

            public TypeSymbol Symbol {get;}

            [MethodImpl(Inline)]
            public SymbolicType(ClrType src, TypeSymbol sym)
            {
                Artifact = src;
                Symbol = sym;
            }

            [MethodImpl(Inline)]
            public static implicit operator SymbolicType((Type a, TypeSymbol s) src)
                => new SymbolicType(src.a, src.s);
        }
    }
}