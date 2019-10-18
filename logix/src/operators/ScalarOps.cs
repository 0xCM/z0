//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static TernaryLogicOpKind;
    using static ScalarLogic;
    using static LogicOps;

    public static class ScalarOps
    {
        /// <summary>
        /// Advertises the supported scalar binary opeators
        /// </summary>
        public static IEnumerable<BinaryLogicOpKind> BinaryKinds
            => items(
                BinaryLogicOpKind.And, BinaryLogicOpKind.Or, BinaryLogicOpKind.XOr,
                BinaryLogicOpKind.Nand, BinaryLogicOpKind.Nor, BinaryLogicOpKind.Xnor
            );

        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public static IEnumerable<TernaryLogicOpKind> TernaryKinds
            => range((byte)1,(byte)X29).Cast<TernaryLogicOpKind>();

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
                default: return canteval(op,a,b);
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
                default: return canteval(op,a);
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
                default: return canteval(op,a);
            }
        }


        public static UnaryOp<T> lookup<T>(UnaryLogicOpKind id)
            where T : unmanaged            
        {
            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return ScalarLogic.identity;
                default: return dne<T>(id);            }

        }

        public static BinaryOp<T> lookup<T>(BinaryLogicOpKind id)
            where T : unmanaged
        {
            switch(id)
            {
                case BinaryLogicOpKind.And: return and;
                case BinaryLogicOpKind.Nand: return nand;
                case BinaryLogicOpKind.Or: return or;
                case BinaryLogicOpKind.Nor: return nor;
                case BinaryLogicOpKind.XOr: return xor;
                case BinaryLogicOpKind.Xnor: return xnor;
                default: return dne<T>(id);
            }
        }

        public static TernaryOp<T> lookup<T>(TernaryLogicOpKind id)
            where T : unmanaged
        {
            switch(id)
            {
                case X01: return f01;
                case X02: return f02;
                case X03: return f03;
                case X04: return f04;
                case X05: return f05;
                case X06: return f06;
                case X07: return f07;
                case X08: return f08;
                case X09: return f09;
                case X0A: return f0a;
                case X0B: return f0b;
                case X0C: return f0c;
                case X0D: return f0d;
                case X0E: return f0e;
                case X0F: return f0f;
                case X10: return f10;
                case X11: return f11;
                case X12: return f12;
                case X13: return f13;
                case X14: return f14;
                case X15: return f15;
                case X16: return f16;
                case X17: return f17;
                case X18: return f18;
                case X19: return f19;
                case X1A: return f1a;
                case X1B: return f1b;
                case X1C: return f1c;
                case X1D: return f1d;
                case X1E: return f1e;
                case X1F: return f1f;
                case X20: return f20;
                case X21: return f21;
                case X22: return f22;
                case X23: return f23;
                case X24: return f24;
                case X25: return f25;
                case X26: return f26;
                case X27: return f27;
                case X28: return f28;
                case X29: return f29;
                default: return dne<T>(id);
            }
        }
    }

}