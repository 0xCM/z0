//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public static class ScalarOpEval
    {
        public static T eval<T>(BinaryLogicOpKind op, T a, T b)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicOpKind.And:
                    return gmath.and(a,b);
                case BinaryLogicOpKind.Or:
                    return gmath.or(a,b);
                case BinaryLogicOpKind.XOr:
                    return gmath.xor(a,b);
                case BinaryLogicOpKind.Nand:
                    return gmath.nand(a,b);
                case BinaryLogicOpKind.Nor:
                    return gmath.nor(a,b);
                case BinaryLogicOpKind.Xnor:
                    return gmath.xnor(a,b);
                default:
                    return unhandled(op,a);
            }
        }

        public static T eval<T>(UnaryLogicOpKind op, T a)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicOpKind.Not:
                    return gmath.not(a);
                case UnaryLogicOpKind.Negate:
                    return gmath.negate(a);
                default:
                    return unhandled(op,a);
            }
        }

        public static T eval<T>(ShiftOpKind op, T a, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return gmath.sll(a,rhs);
                case ShiftOpKind.Srl:
                    return gmath.srl(a,rhs);
                case ShiftOpKind.Rotl:
                    return gbits.rotl(a,rhs);
                case ShiftOpKind.Rotr:
                    return gbits.rotr(a,rhs);
                default:
                    return unhandled(op,a);
            }
        }

        static T unhandled<E,T>(E op, T a)
            where T : unmanaged
            where E : Enum
                => throw new Exception($"{op} unhandled");

    }

}