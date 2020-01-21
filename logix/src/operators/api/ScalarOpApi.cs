//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static TernaryBitLogicKind;
    using static ScalarOps;
    using static OpHelpers;

    /// <summary>
    /// Services for scalar operators
    /// </summary>
    public static class ScalarOpApi
    {
        public static IEnumerable<UnaryBitwiseOpKind> UnaryBitwiseKinds
            => new UnaryBitwiseOpKind[]{
                UnaryBitwiseOpKind.Not, UnaryBitwiseOpKind.Identity, UnaryBitwiseOpKind.Negate
                };

        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitwiseOpKind> BinaryBitwiseKinds
            => BinaryOpKindData.As<BinaryBitwiseOpKind>();

        static ReadOnlySpan<byte> BinaryOpKindData
            => new byte[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

        public static UnaryArithmeticOpKind[] UnaryAritmeticKinds
            => new UnaryArithmeticOpKind[]{
                UnaryArithmeticOpKind.Inc, UnaryArithmeticOpKind.Dec, UnaryArithmeticOpKind.Negate
            };


        public static BinaryArithmeticOpKind[] BinaryArithmeticKinds
            => new BinaryArithmeticOpKind[]{
                BinaryArithmeticOpKind.Add, BinaryArithmeticOpKind.Sub, 
            };


        /// <summary>
        /// Specifies the supported comparison operators
        /// </summary>
        public static ComparisonKind[] ComparisonKinds
            => new ComparisonKind[]{
                ComparisonKind.Eq, ComparisonKind.Neq, 
                ComparisonKind.Lt, ComparisonKind.LtEq, 
                ComparisonKind.Gt, ComparisonKind.GtEq, 
            };


        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public static IEnumerable<TernaryBitLogicKind> TernaryBitwiseKinds
            => range((byte)1,(byte)X5F).Cast<TernaryBitLogicKind>();


        [Op, PrimalClosures(PrimalKind.Integers)]
        public static T eval<T>(BinaryBitwiseOpKind kind, T a, T b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true(a,b);
                case BinaryBitwiseOpKind.False: return @false(a,b);
                case BinaryBitwiseOpKind.And: return and(a,b);
                case BinaryBitwiseOpKind.Nand: return nand(a,b);
                case BinaryBitwiseOpKind.Or: return or(a,b);
                case BinaryBitwiseOpKind.Nor: return nor(a,b);
                case BinaryBitwiseOpKind.XOr: return xor(a,b);
                case BinaryBitwiseOpKind.Xnor: return xnor(a,b);
                case BinaryBitwiseOpKind.LeftProject: return left(a,b);
                case BinaryBitwiseOpKind.RightProject: return right(a,b);
                case BinaryBitwiseOpKind.LeftNot: return lnot(a,b);
                case BinaryBitwiseOpKind.RightNot: return rnot(a,b);
                case BinaryBitwiseOpKind.Implication: return impl(a,b);                    
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl(a,b);
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl(a,b);                    
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl(a,b);
                default: return dne<BinaryBitwiseOpKind,T>(kind);
            }
        }

        [Op, PrimalClosures(PrimalKind.Integers)]
        public static T eval<T>(UnaryBitwiseOpKind kind, T a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not(a);
                case UnaryBitwiseOpKind.Identity: return ScalarOps.identity(a);
                case UnaryBitwiseOpKind.Negate: return negate(a);
                default: return dne<UnaryBitwiseOpKind,T>(kind);            
            }
        }

        [Op, PrimalClosures(PrimalKind.Integers)]
        public static T eval<T>(ComparisonKind kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals(a,b);
                case ComparisonKind.Neq: return neq(a,b);
                case ComparisonKind.Lt: return lt(a,b);
                case ComparisonKind.LtEq: return lteq(a,b);
                case ComparisonKind.Gt: return gt(a,b);
                case ComparisonKind.GtEq: return gteq(a,b);
                default: return dne<ComparisonKind,T>(kind);
            }
        }


        /// <summary>
        /// Evaluates an identified ternary operator
        /// </summary>
        /// <param name="op">The ternary operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [Op, PrimalClosures(PrimalKind.Integers)]
        public static T eval<T>(TernaryBitLogicKind kind, T a, T b, T c)
            where T : unmanaged
        {
            switch(kind)
            {
                case X01: return f01(a, b, c);
                case X02: return f02(a, b, c);
                case X03: return f03(a, b, c);
                case X04: return f04(a, b, c);
                case X05: return f05(a, b, c);
                case X06: return f06(a, b, c);
                case X07: return f07(a, b, c);
                case X08: return f08(a, b, c);
                case X09: return f09(a, b, c);
                case X0A: return f0a(a, b, c);
                case X0B: return f0b(a, b, c);
                case X0C: return f0c(a, b, c);
                case X0D: return f0d(a, b, c);
                case X0E: return f0e(a, b, c);
                case X0F: return f0f(a, b, c);
                case X10: return f10(a, b, c);
                case X11: return f11(a, b, c);
                case X12: return f12(a, b, c);
                case X13: return f13(a, b, c);
                case X14: return f14(a, b, c);
                case X15: return f15(a, b, c);
                case X16: return f16(a, b, c);
                case X17: return f17(a, b, c);
                case X18: return f18(a, b, c);
                case X19: return f19(a, b, c);
                case X1A: return f1a(a, b, c);
                case X1B: return f1b(a, b, c);
                case X1C: return f1c(a, b, c);
                case X1D: return f1d(a, b, c);
                case X1E: return f1e(a, b, c);
                case X1F: return f1f(a, b, c);
                case X20: return f20(a, b, c);
                case X21: return f21(a, b, c);
                case X22: return f22(a, b, c);
                case X23: return f23(a, b, c);
                case X24: return f24(a, b, c);
                case X25: return f25(a, b, c);
                case X26: return f26(a, b, c);
                case X27: return f27(a, b, c);
                case X28: return f28(a, b, c);
                case X29: return f29(a, b, c);
                case X2A: return f2a(a, b, c);
                case X2B: return f2b(a, b, c);
                case X2C: return f2c(a, b, c);
                case X2D: return f2d(a, b, c);
                case X2E: return f2e(a, b, c);
                case X2F: return f2f(a, b, c);
                case X30: return f30(a, b, c);
                case X31: return f31(a, b, c);
                case X32: return f32(a, b, c);
                case X33: return f33(a, b, c);
                case X34: return f34(a, b, c);
                case X35: return f35(a, b, c);
                case X36: return f36(a, b, c);
                case X37: return f37(a, b, c);
                case X38: return f38(a, b, c);
                case X39: return f39(a, b, c);
                case X3A: return f3a(a, b, c);
                case X3B: return f3b(a, b, c);
                case X3C: return f3c(a, b, c);
                case X3D: return f3d(a, b, c);
                case X3E: return f3e(a, b, c);
                case X3F: return f3f(a, b, c);
                case X40: return f40(a, b, c);
                case X41: return f41(a, b, c);
                case X42: return f42(a, b, c);
                case X43: return f43(a, b, c);
                case X44: return f44(a, b, c);
                case X45: return f45(a, b, c);
                case X46: return f46(a, b, c);
                case X47: return f47(a, b, c);
                case X48: return f48(a, b, c);
                case X49: return f49(a, b, c);
                case X4A: return f4a(a, b, c);
                case X4B: return f4b(a, b, c);
                case X4C: return f4c(a, b, c);
                case X4D: return f4d(a, b, c);
                case X4E: return f4e(a, b, c);
                case X4F: return f4f(a, b, c);
                case X50: return f50(a, b, c);
                case X51: return f51(a, b, c);
                case X52: return f52(a, b, c);
                case X53: return f53(a, b, c);
                case X54: return f54(a, b, c);
                case X55: return f55(a, b, c);
                case X56: return f56(a, b, c);
                case X57: return f57(a, b, c);
                case X58: return f58(a, b, c);
                case X59: return f59(a, b, c);
                case X5A: return f5a(a, b, c);
                case X5B: return f5b(a, b, c);
                case X5C: return f5c(a, b, c);
                case X5D: return f5d(a, b, c);
                case X5E: return f5e(a, b, c);
                case X5F: return f5f(a, b, c);
                default: return canteval<T,TernaryBitLogicKind>(kind);
            }
        }

        [Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static T eval<T>(ShiftOpKind kind, T a, byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll(a, count);
                case ShiftOpKind.Srl: return srl(a, count);
                case ShiftOpKind.Rotl: return rotl(a, count);
                case ShiftOpKind.Rotr: return rotr(a, count);
                default: return dne<ShiftOpKind,T>(kind);
            }
        }
            
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

        public static BinaryOp<T> lookup<T>(ComparisonKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals;
                case ComparisonKind.Neq: return neq;
                case ComparisonKind.Lt: return lt;
                case ComparisonKind.LtEq: return lteq;
                case ComparisonKind.Gt: return gt;
                case ComparisonKind.GtEq: return gteq;
                default: return dne<T>(kind);
            }
        }

        public static UnaryOp<T> lookup<T>(UnaryBitwiseOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not;
                case UnaryBitwiseOpKind.Identity: return ScalarOps.identity;
                case UnaryBitwiseOpKind.Negate: return negate;
                default: return dne<T>(kind);            
            }
        }

        public static BinaryOp<T> lookup<T>(BinaryBitwiseOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true;
                case BinaryBitwiseOpKind.False: return @false;
                case BinaryBitwiseOpKind.And: return and;
                case BinaryBitwiseOpKind.Nand: return nand;
                case BinaryBitwiseOpKind.Or: return or;
                case BinaryBitwiseOpKind.Nor: return nor;
                case BinaryBitwiseOpKind.XOr: return xor;
                case BinaryBitwiseOpKind.Xnor: return xnor;
                case BinaryBitwiseOpKind.LeftProject: return left;
                case BinaryBitwiseOpKind.RightProject: return right;
                case BinaryBitwiseOpKind.LeftNot: return lnot;
                case BinaryBitwiseOpKind.RightNot: return rnot;
                case BinaryBitwiseOpKind.Implication: return impl;
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl;
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl;
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl;
                default: return dne<T>(kind);
            }
        }

        public static TernaryOp<T> lookup<T>(TernaryBitLogicKind id)
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
                case X50: return f50;
                case X51: return f51;
                case X52: return f52;
                case X53: return f53;
                case X54: return f54;
                case X55: return f55;
                case X56: return f56;
                case X57: return f57;
                case X58: return f58;
                case X59: return f59;
                case X5A: return f5a;
                case X5B: return f5b;
                case X5C: return f5c;
                case X5D: return f5d;
                case X5E: return f5e;
                case X5F: return f5f;
                default: return dne<T>(id);
            }
        }
    }

}