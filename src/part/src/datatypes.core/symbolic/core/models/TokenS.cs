//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a kinded token
    /// </summary>
    public readonly struct Token<K>
        where K : unmanaged, Enum
    {
        readonly ushort Index;

        [MethodImpl(Inline)]
        public Token(ushort index)
        {
            Index = index;
        }

        ReadOnlySpan<Sym<K>> Syms
        {
            [MethodImpl(Inline)]
            get => SymCache<K>.get().View;
        }

        public SymExpr Expression
        {
            [MethodImpl(Inline)]
            get => skip(Syms, Index).Expr;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Index != 0;
        }

        public static Token<K> Empty => default;
    }
}