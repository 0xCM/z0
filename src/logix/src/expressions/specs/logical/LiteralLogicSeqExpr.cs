//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a sequence of literal bit values
    /// </summary>
    public readonly struct LiteralLogicSeqExpr : ILiteralLogicSeqExpr
    {
        public Bit32[] Terms {get;}

        [MethodImpl(Inline)]
        internal LiteralLogicSeqExpr(Bit32[] terms)
        {
            this.Terms = terms;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

        public Bit32 this[int index]
        {
            [MethodImpl(Inline)]
            get => Terms[index];

            [MethodImpl(Inline)]
            set => Terms[index] = value;
        }

        public int Length
            => Terms.Length;

        public BitString ToBitString()
            => BitString.load(Terms);

        public string Format()
            => ToBitString().Format();

        public override string ToString()
            => Format();
    }
}