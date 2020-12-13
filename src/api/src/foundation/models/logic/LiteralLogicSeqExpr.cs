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
    /// Defines a sequence of literal bit values
    /// </summary>
    public readonly struct LiteralLogicSeqExpr : ILiteralLogicSeqExpr
    {
        public bit[] Terms {get;}

        [MethodImpl(Inline)]
        public LiteralLogicSeqExpr(bit[] src)
            => Terms = src;

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Terms[index];

            [MethodImpl(Inline)]
            set => Terms[index] = value;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Terms.Length;
        }

        public string Format()
            => BitFormatter.format(Terms);

        public override string ToString()
            => Format();
    }
}