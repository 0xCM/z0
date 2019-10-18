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
    using System.Runtime.Intrinsics;

    using static LogicOps;
    using static Cpu256Logic;    
    using static TernaryLogicOpKind;
    using static zfunc;

    public static class Cpu256Ops
    {
        public static Vector256<T> eval<T>(UnaryLogicOpKind op, Vector256<T> x)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicOpKind.Not:
                    return ginx.vnot(x);
                case UnaryLogicOpKind.Negate:
                    return ginx.vnegate<T>(x);
                default: return canteval(op,x);
            }
        }

        public static Vector256<T> eval<T>(ShiftOpKind op, Vector256<T> x, int offset)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return ginx.vsll<T>(x,(byte)offset);
                case ShiftOpKind.Srl:
                    return ginx.vsrl<T>(x,(byte)offset);
                case ShiftOpKind.Rotl:
                    return ginx.vrotl<T>(x,(byte)offset);
                case ShiftOpKind.Rotr:
                    return ginx.vrotr<T>(x,(byte)offset);
                default: return canteval(op,x);

            }
        }


        public static Vector256<T> eval<T>(BinaryLogicOpKind op, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicOpKind.And:
                    return Cpu256Logic.and(x,y);
                case BinaryLogicOpKind.Or:
                    return Cpu256Logic.or(x,y);
                case BinaryLogicOpKind.XOr:
                    return Cpu256Logic.xor(x,y);
                case BinaryLogicOpKind.Nand:
                    return Cpu256Logic.nand(x,y);
                case BinaryLogicOpKind.Nor:
                    return Cpu256Logic.nor(x,y);
                case BinaryLogicOpKind.Xnor:
                    return Cpu256Logic.xnor(x,y);
                default: return canteval(op,x,y);
            }
        }

        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(TernaryLogicOpKind op, Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => lookup<T>(op)(x,y,z);

        public static UnaryOp<Vector256<T>> lookup<T>(UnaryLogicOpKind id)
            where T : unmanaged            
        {
            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return identity;
                default: return dne<Vector256<T>>(id);            
            }

        }

       public static BinaryOp<Vector256<T>> lookup<T>(BinaryLogicOpKind id)
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
                default: return dne<Vector256<T>>(id);            
            }
        }

        public static TernaryOp<Vector256<T>> lookup<T>(TernaryLogicOpKind id)
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
                default: return select;

            }
        }

    }

}