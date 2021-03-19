//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatementThumbprint : IComparable<AsmStatementThumbprint>
    {
        public Address16 Offset {get;}

        public AsmStatementExpr Statement {get;}

        public AsmThumbprintExpr Thumbprint {get;}

        [MethodImpl(Inline)]
        public AsmStatementThumbprint(Address16 offset, AsmStatementExpr expr, AsmThumbprintExpr thumbprint)
        {
            Offset = offset;
            Statement = expr;
            Thumbprint = thumbprint;
        }

        public Key<AsmStatementExpr,AsmThumbprintExpr> Key()
            => root.paired(Statement, Thumbprint);

        public override int GetHashCode()
            => (int)Key().Hash;

        public int CompareTo(AsmStatementThumbprint src)
            => Thumbprint.CompareTo(src.Thumbprint);
    }
}