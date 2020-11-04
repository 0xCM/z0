//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

   /// <summary>
   /// Defines a natural-length sequence of literal bit values
   /// </summary>
   public readonly struct LiteralLogicSeqExpr<N> : ILiteralLogicSeqExpr
        where N : unmanaged, ITypeNat
    {
        public Bit32[] Terms {get;}

        [MethodImpl(Inline)]
        public LiteralLogicSeqExpr(Bit32[] terms)
            => Terms = terms;

        public Bit32 this[int index]
        {
            [MethodImpl(Inline)]
            get => Terms[index];

            [MethodImpl(Inline)]
            set => Terms[index] = value;
        }

        public int Length
            => Terms.Length;

        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

        public string Format()
            => BitFormatter.format(Terms);

        public override string ToString()
            => Format();
    }
}