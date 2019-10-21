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
    using static ScalarOps;
    using static LogicOps;

    /// <summary>
    /// Services for scalar operators
    /// </summary>
    public static class ScalarOpApi
    {
        /// <summary>
        /// Advertises the supported scalar binary opeators
        /// </summary>
        public static IEnumerable<BinaryLogicOpKind> BinaryKinds
            => items(
                BinaryLogicOpKind.And, BinaryLogicOpKind.Or, BinaryLogicOpKind.XOr,
                BinaryLogicOpKind.Nand, BinaryLogicOpKind.Nor, BinaryLogicOpKind.Xnor,
                BinaryLogicOpKind.AndNot, BinaryLogicOpKind.True, BinaryLogicOpKind.False
            );

        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public static IEnumerable<TernaryLogicOpKind> TernaryKinds
            => range((byte)1,(byte)X4F).Cast<TernaryLogicOpKind>();

        [MethodImpl(Inline)]
        public static T eval<T>(BinaryLogicOpKind kind, T a, T b)
            where T : unmanaged
                => lookup<T>(kind)(a,b);

        [MethodImpl(Inline)]
        public static T eval<T>(TernaryLogicOpKind kind, T a, T b, T c)
            where T : unmanaged
                => lookup<T>(kind)(a,b,c);

        [MethodImpl(Inline)]
        public static T eval<T>(UnaryLogicOpKind kind, T a)
            where T : unmanaged
                => lookup<T>(kind)(a);

        [MethodImpl(Inline)]
        public static T eval<T>(ShiftOpKind op, T a, int offset)
            where T : unmanaged
                => lookup<T>(op)(a,offset);

        public static Shifter<T> lookup<T>(ShiftOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll;
                case ShiftOpKind.Srl: return srl;
                case ShiftOpKind.Rotl: return rotl;
                case ShiftOpKind.Rotr: return rotr;
                default: return dne<T>(kind);
            }
        }


        public static UnaryOp<T> lookup<T>(UnaryLogicOpKind id)
            where T : unmanaged            
        {
            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return ScalarOps.identity;
                case UnaryLogicOpKind.Negate: return negate;
                default: return dne<T>(id);            
            }

        }

        public static BinaryOp<T> lookup<T>(BinaryLogicOpKind id)
            where T : unmanaged
        {
            switch(id)
            {
                case BinaryLogicOpKind.False: return @false;
                case BinaryLogicOpKind.And: return and;
                case BinaryLogicOpKind.Nand: return nand;
                case BinaryLogicOpKind.Or: return or;
                case BinaryLogicOpKind.Nor: return nor;
                case BinaryLogicOpKind.XOr: return xor;
                case BinaryLogicOpKind.Xnor: return xnor;
                case BinaryLogicOpKind.AndNot: return andnot;
                case BinaryLogicOpKind.LeftProject: return left;
                case BinaryLogicOpKind.RightProject: return right;
                case BinaryLogicOpKind.RightNot: return rightnot;
                case BinaryLogicOpKind.LeftNot: return leftnot;
                case BinaryLogicOpKind.True: return @true;
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
                case X2A: return f2a;
                case X2B: return f2b;
                case X2C: return f2c;
                case X2D: return f2d;
                case X2E: return f2e;
                case X2F: return f2f;
                case X30: return f30;
                case X31: return f31;
                case X32: return f32;
                case X33: return f33;
                case X34: return f34;
                case X35: return f35;
                case X36: return f36;
                case X37: return f37;
                case X38: return f38;
                case X39: return f39;
                case X3A: return f3a;
                case X3B: return f3b;
                case X3C: return f3c;
                case X3D: return f3d;
                case X3E: return f3e;
                case X3F: return f3f;
                case X40: return f40;
                case X41: return f41;
                case X42: return f42;
                case X43: return f43;
                case X44: return f44;
                case X45: return f45;
                case X46: return f46;
                case X47: return f47;
                case X48: return f48;
                case X49: return f49;
                case X4A: return f4a;
                case X4B: return f4b;
                case X4C: return f4c;
                case X4D: return f4d;
                case X4E: return f4e;
                case X4F: return f4f;
               default: return dne<T>(id);
            }
        }
    }

}