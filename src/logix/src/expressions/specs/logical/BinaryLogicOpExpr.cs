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
    /// Definesan untyped binary logical operator expression
    /// </summary>
    public readonly struct BinaryLogicOpExpr : IBinaryLogicOpExpr
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryBitLogicKind ApiClass {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr RightArg {get;}

        [MethodImpl(Inline)]
        public BinaryLogicOpExpr(BinaryBitLogicKind op, ILogicExpr lhs, ILogicExpr rhs)
        {
            ApiClass = op;
            LeftArg = lhs;
            RightArg = rhs;
        }

        public string Format()
            => ApiClass.Format(LeftArg,RightArg);

        public override string ToString()
            => Format();
    }
}