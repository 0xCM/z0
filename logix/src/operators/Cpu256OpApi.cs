//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static LogicOps;
    using static Cpu256Ops;    
    using static TernaryLogicOpKind;
    using static zfunc;

    /// <summary>
    /// Defines services for 256-bit instrinsic operators
    /// </summary>
    public static class Cpu256OpApi
    {
        public static Vector256<T> eval<T>(UnaryLogicOpKind kind, Vector256<T> x)
            where T : unmanaged
                => lookup<T>(kind)(x);

        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(ShiftOpKind kind, Vector256<T> x, int offset)
            where T : unmanaged
                => lookup<T>(kind)(x,offset);

        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(BinaryLogicOpKind kind, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
            => lookup<T>(kind)(x,y);

        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(TernaryLogicOpKind kind, Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => lookup<T>(kind)(x,y,z);

        public static UnaryOp<Vector256<T>> lookup<T>(UnaryLogicOpKind id)
            where T : unmanaged            
        {
            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return identity;
                case UnaryLogicOpKind.Negate: return negate;
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
                case BinaryLogicOpKind.AndNot: return andnot;
                default: return dne<Vector256<T>>(id);            
            }
        }

       public static Shifter<Vector256<T>> lookup<T>(ShiftOpKind id)
            where T : unmanaged
        {
            switch(id)
            {
                case ShiftOpKind.Sll: return sll;
                case ShiftOpKind.Srl: return srl;
                case ShiftOpKind.Rotl: return rotl;
                case ShiftOpKind.Rotr: return rotr;
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
                default: return dne<Vector256<T>>(id);            

            }
        }

    }

}