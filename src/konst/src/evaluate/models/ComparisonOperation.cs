//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes a comparison operation
    /// </summary>
    public readonly struct ComparisonOperation
    {
        /// <summary>
        /// The sort of comparison effected by the operator
        /// </summary>
        public ComparisonKind Kind {get;}

        /// <summary>
        /// The operator arity
        /// </summary>
        public byte Arity {get;}

        /// <summary>
        /// The source operand(s) type
        /// </summary>
        public Type OperandType {get;}

        /// <summary>
        /// The result type
        /// </summary>
        public Type ResultType {get;}

        [MethodImpl(Inline)]
        public ComparisonOperation(ComparisonKind kind, byte arity, Type tOperand, Type tResult)
        {
            Kind = kind;
            Arity = arity;
            OperandType = tOperand;
            ResultType = tResult;
        }
    }
}