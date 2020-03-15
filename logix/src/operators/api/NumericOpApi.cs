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
    
    using static TernaryBitLogicOpKind;
    using static NumericOps;
    using static OpHelpers;

    /// <summary>
    /// Services for scalar operators
    /// </summary>
    //[ApiHost("scalar.api", ApiHostKind.Generic)]
    public static class NumericOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<UnaryBitLogicOpKind> UnaryBitLogicKinds
            => Enums.literals<UnaryBitLogicOpKind>();

        /// <summary>
        /// Advertises the supported binary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicOpKind> BinaryBitLogicKinds
            => Enums.literals<BinaryBitLogicOpKind>();

        /// <summary>
        /// Advertises the supported ternary bitlogic opeators
        /// </summary>
        public static ReadOnlySpan<TernaryBitLogicOpKind> TernaryBitLogicKinds
            => Numeric.range((byte)1,(byte)X5F).Cast<TernaryBitLogicOpKind>().ToArray();

        /// <summary>
        /// Advertises the supported unary arithmetic operators
        /// </summary>
        public static ReadOnlySpan<UnaryArithmeticKindId> UnaryAritmeticKinds
            => Enums.literals<UnaryArithmeticKindId>();

        /// <summary>
        /// Advertises the supported binary arithmetic operators
        /// </summary>
        public static ReadOnlySpan<BinaryArithmeticKindId> BinaryArithmeticKinds
            => Enums.literals<BinaryArithmeticKindId>();

        /// <summary>
        /// Advertises the supported comparison operators
        /// </summary>
        public static ReadOnlySpan<ComparisonOpKindId> ComparisonKinds
            => Enums.literals<ComparisonOpKindId>();


        [Op, NumericClosures(NumericKind.Integers)]
        public static T eval<T>(BinaryBitLogicOpKind kind, T a, T b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true(a,b);
                case BinaryBitLogicOpKind.False: return @false(a,b);
                case BinaryBitLogicOpKind.And: return and(a,b);
                case BinaryBitLogicOpKind.Nand: return nand(a,b);
                case BinaryBitLogicOpKind.Or: return or(a,b);
                case BinaryBitLogicOpKind.Nor: return nor(a,b);
                case BinaryBitLogicOpKind.Xor: return xor(a,b);
                case BinaryBitLogicOpKind.Xnor: return xnor(a,b);
                case BinaryBitLogicOpKind.LProject: return left(a,b);
                case BinaryBitLogicOpKind.RProject: return right(a,b);
                case BinaryBitLogicOpKind.LNot: return lnot(a,b);
                case BinaryBitLogicOpKind.RNot: return rnot(a,b);
                case BinaryBitLogicOpKind.Impl: return impl(a,b);                    
                case BinaryBitLogicOpKind.NonImpl: return nonimpl(a,b);
                case BinaryBitLogicOpKind.CImpl: return cimpl(a,b);                    
                case BinaryBitLogicOpKind.CNonImpl: return cnonimpl(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static T eval<T>(UnaryBitLogicOpKind kind, T a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not(a);
                case UnaryBitLogicOpKind.Identity: return NumericOps.identity(a);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static T eval<T>(ComparisonOpKindId kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return equals(a,b);
                case ComparisonOpKindId.Neq: return neq(a,b);
                case ComparisonOpKindId.Lt: return lt(a,b);
                case ComparisonOpKindId.LtEq: return lteq(a,b);
                case ComparisonOpKindId.Gt: return gt(a,b);
                case ComparisonOpKindId.GtEq: return gteq(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified ternary operator
        /// </summary>
        /// <param name="op">The ternary operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [Op, NumericClosures(NumericKind.Integers)]
        public static T eval<T>(TernaryBitLogicOpKind kind, T a, T b, T c)
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
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T eval<T>(ShiftOpKindId kind, T a, byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKindId.Sll: return sll(a, count);
                case ShiftOpKindId.Srl: return srl(a, count);
                case ShiftOpKindId.Rotl: return rotl(a, count);
                case ShiftOpKindId.Rotr: return rotr(a, count);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
            
        [Op, NumericClosures(NumericKind.Integers)]
        public static Shifter<T> lookup<T>(ShiftOpKindId kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ShiftOpKindId.Sll: return sll;
                case ShiftOpKindId.Srl: return srl;
                case ShiftOpKindId.Rotl: return rotl;
                case ShiftOpKindId.Rotr: return rotr;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.All)]
        public static BinaryOp<T> lookup<T>(ComparisonOpKindId kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return equals;
                case ComparisonOpKindId.Neq: return neq;
                case ComparisonOpKindId.Lt: return lt;
                case ComparisonOpKindId.LtEq: return lteq;
                case ComparisonOpKindId.Gt: return gt;
                case ComparisonOpKindId.GtEq: return gteq;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static UnaryOp<T> lookup<T>(UnaryBitLogicOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not;
                case UnaryBitLogicOpKind.Identity: return NumericOps.identity;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<T> lookup<T>(BinaryBitLogicOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true;
                case BinaryBitLogicOpKind.False: return @false;
                case BinaryBitLogicOpKind.And: return and;
                case BinaryBitLogicOpKind.Nand: return nand;
                case BinaryBitLogicOpKind.Or: return or;
                case BinaryBitLogicOpKind.Nor: return nor;
                case BinaryBitLogicOpKind.Xor: return xor;
                case BinaryBitLogicOpKind.Xnor: return xnor;
                case BinaryBitLogicOpKind.LProject: return left;
                case BinaryBitLogicOpKind.RProject: return right;
                case BinaryBitLogicOpKind.LNot: return lnot;
                case BinaryBitLogicOpKind.RNot: return rnot;
                case BinaryBitLogicOpKind.Impl: return impl;
                case BinaryBitLogicOpKind.NonImpl: return nonimpl;
                case BinaryBitLogicOpKind.CImpl: return cimpl;
                case BinaryBitLogicOpKind.CNonImpl: return cnonimpl;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        public static TernaryOp<T> lookup<T>(TernaryBitLogicOpKind kind)
            where T : unmanaged
        {
            switch(kind)
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
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}