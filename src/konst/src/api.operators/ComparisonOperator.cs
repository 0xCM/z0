//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z ;

    public readonly struct ComparisonOperator
    {
        public ComparisonKind Kind {get;}

        public byte Arity {get;}

        public Type OperandType {get;}

        public Type ResultType {get;}

        [MethodImpl(Inline)]
        public ComparisonOperator(ComparisonKind kind, byte arity, Type tOperand, Type tResult)
        {
            Kind = kind;
            Arity = arity;
            OperandType = tOperand;
            ResultType = tResult;
        }
    }
}