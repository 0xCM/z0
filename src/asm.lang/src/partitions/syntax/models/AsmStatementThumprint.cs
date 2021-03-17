//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatementThumbprint : IComparable<AsmStatementThumbprint>
    {
        public MemoryAddress BaseAddress {get;}

        public Address16 Offset {get;}

        public AsmStatementExpr Statement {get;}

        public AsmThumbprint Thumbprint {get;}

        [MethodImpl(Inline)]
        public AsmStatementThumbprint(MemoryAddress @base, Address16 offset, AsmStatementExpr expr, AsmThumbprint thumbprint)
        {
            BaseAddress = @base;
            Offset = offset;
            Statement = expr;
            Thumbprint = thumbprint;
        }

        public Key<AsmStatementExpr,AsmThumbprint> Key()
            => root.paired(Statement, Thumbprint);

        public override int GetHashCode()
            => (int)Key().Hash;

        public int CompareTo(AsmStatementThumbprint src)
            => Thumbprint.CompareTo(src.Thumbprint);
    }
}