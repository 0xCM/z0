//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

   /// <summary>
   /// Defines a natural-length sequence of literal bit values
   /// </summary>
   public readonly struct LiteralLogicSeqExpr<N> : ILiteralLogicSeqExpr
        where N : unmanaged, ITypeNat
    {
        Index<bit> _Terms {get;}

        [MethodImpl(Inline)]
        public LiteralLogicSeqExpr(bit[] terms)
            => _Terms = terms;

        public bit[] Terms
        {
            [MethodImpl(Inline)]
            get => _Terms.Storage;
        }
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => _Terms[index];

            [MethodImpl(Inline)]
            set => _Terms[index] = value;
        }

        public int Length
            => _Terms.Length;

        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

        public string Format()
            => BitRender.format(_Terms);

        public override string ToString()
            => Format();
    }
}