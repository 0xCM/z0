//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Linq;

    using static Konst;
    using static Memories;
    using static LogicSig;
    using static NumericLogix;

    using BLK = BinaryLogicKind;
    using TLK = TernaryBitLogicKind;
    using ULK = UnaryBitLogicKind;
    using UAR = UnaryArithmeticApiKeyKind;
    using BAR = BinaryArithmeticApiKeyKind;
    using BCK = BinaryComparisonApiKeyKind;
    using BSK = BitShiftApiKeyKind;

    /// <summary>
    /// Defines the canonical shape of a 2-argument function over a parametric domain and boolean codomain
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <typeparam name="T">The domain over which the predicate is evaluated</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPred<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a bitwise shift function
    /// </summary>
    /// <param name="a">The source value</param>
    /// <param name="count">The shift amount, typically in bits</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Shifter<T>(T a, byte count)
        where T : unmanaged;

    [ApiHost]
    public readonly struct NumericLogixHost : IApiHost<NumericLogixHost>
    {
        /// <summary>
        /// Advertises the supported unary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<ULK> UnaryLogicKinds
            => Enums.literals<ULK>();

        /// <summary>
        /// Advertises the supported binary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<BLK> BinaryLogicKinds
            => Enums.literals<BLK>();

        /// <summary>
        /// Advertises the supported ternary bitlogic opeators
        /// </summary>
        public static ReadOnlySpan<TLK> TernaryLogicKinds
            => gmath.range((byte)1,(byte)TLK.X5F).Cast<TLK>().ToArray();

        /// <summary>
        /// Advertises the supported unary arithmetic operators
        /// </summary>
        public static ReadOnlySpan<UAR> UnaryAritmeticKinds
            => Enums.literals<UAR>();

        /// <summary>
        /// Advertises the supported binary arithmetic operators
        /// </summary>
        public static ReadOnlySpan<BAR> BinaryArithmeticKinds
            => Enums.literals<BAR>();

        /// <summary>
        /// Advertises the supported comparison operators
        /// </summary>
        public static ReadOnlySpan<BCK> BinaryComparisonKinds
            => Enums.literals<BCK>();


        [Closures(Integers)]
        public static bit eval<T>(BCK kind, T a, T b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BCK.Eq: return gmath.eq(a,b);
                case BCK.Neq: return gmath.neq(a,b);
                case BCK.Lt: return gmath.lt(a,b);
                case BCK.LtEq: return gmath.lteq(a,b);
                case BCK.Gt: return gmath.gt(a,b);
                case BCK.GtEq: return gmath.gteq(a,b);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Closures(Integers)]
        public static BinaryPred<T> lookup<T>(BCK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BCK.Eq: return gmath.eq;
                case BCK.Neq: return gmath.neq;
                case BCK.Lt: return gmath.lt;
                case BCK.LtEq: return gmath.lteq;
                case BCK.Gt: return gmath.gt;
                case BCK.GtEq: return gmath.gteq;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }


        [NumericClosures(Integers)]
        public static T eval<T>(BLK kind, T a, T b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true(a,b);
                case BLK.False: return @false(a,b);
                case BLK.And: return and(a,b);
                case BLK.Nand: return nand(a,b);
                case BLK.Or: return or(a,b);
                case BLK.Nor: return nor(a,b);
                case BLK.Xor: return xor(a,b);
                case BLK.Xnor: return xnor(a,b);
                case BLK.LProject: return left(a,b);
                case BLK.RProject: return right(a,b);
                case BLK.LNot: return lnot(a,b);
                case BLK.RNot: return rnot(a,b);
                case BLK.Impl: return impl(a,b);
                case BLK.NonImpl: return nonimpl(a,b);
                case BLK.CImpl: return cimpl(a,b);
                case BLK.CNonImpl: return cnonimpl(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [NumericClosures(Integers)]
        public static T eval<T>(ULK kind, T a)
            where T : unmanaged
        {
            switch(kind)
            {
                case ULK.Not: return not(a);
                case ULK.Identity: return identity(a);
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
        [NumericClosures(Integers)]
        public static T eval<T>(TLK kind, T a, T b, T c)
            where T : unmanaged
        {
            switch(kind)
            {
                case TLK.X01: return f01(a, b, c);
                case TLK.X02: return f02(a, b, c);
                case TLK.X03: return f03(a, b, c);
                case TLK.X04: return f04(a, b, c);
                case TLK.X05: return f05(a, b, c);
                case TLK.X06: return f06(a, b, c);
                case TLK.X07: return f07(a, b, c);
                case TLK.X08: return f08(a, b, c);
                case TLK.X09: return f09(a, b, c);
                case TLK.X0A: return f0a(a, b, c);
                case TLK.X0B: return f0b(a, b, c);
                case TLK.X0C: return f0c(a, b, c);
                case TLK.X0D: return f0d(a, b, c);
                case TLK.X0E: return f0e(a, b, c);
                case TLK.X0F: return f0f(a, b, c);
                case TLK.X10: return f10(a, b, c);
                case TLK.X11: return f11(a, b, c);
                case TLK.X12: return f12(a, b, c);
                case TLK.X13: return f13(a, b, c);
                case TLK.X14: return f14(a, b, c);
                case TLK.X15: return f15(a, b, c);
                case TLK.X16: return f16(a, b, c);
                case TLK.X17: return f17(a, b, c);
                case TLK.X18: return f18(a, b, c);
                case TLK.X19: return f19(a, b, c);
                case TLK.X1A: return f1a(a, b, c);
                case TLK.X1B: return f1b(a, b, c);
                case TLK.X1C: return f1c(a, b, c);
                case TLK.X1D: return f1d(a, b, c);
                case TLK.X1E: return f1e(a, b, c);
                case TLK.X1F: return f1f(a, b, c);
                case TLK.X20: return f20(a, b, c);
                case TLK.X21: return f21(a, b, c);
                case TLK.X22: return f22(a, b, c);
                case TLK.X23: return f23(a, b, c);
                case TLK.X24: return f24(a, b, c);
                case TLK.X25: return f25(a, b, c);
                case TLK.X26: return f26(a, b, c);
                case TLK.X27: return f27(a, b, c);
                case TLK.X28: return f28(a, b, c);
                case TLK.X29: return f29(a, b, c);
                case TLK.X2A: return f2a(a, b, c);
                case TLK.X2B: return f2b(a, b, c);
                case TLK.X2C: return f2c(a, b, c);
                case TLK.X2D: return f2d(a, b, c);
                case TLK.X2E: return f2e(a, b, c);
                case TLK.X2F: return f2f(a, b, c);
                case TLK.X30: return f30(a, b, c);
                case TLK.X31: return f31(a, b, c);
                case TLK.X32: return f32(a, b, c);
                case TLK.X33: return f33(a, b, c);
                case TLK.X34: return f34(a, b, c);
                case TLK.X35: return f35(a, b, c);
                case TLK.X36: return f36(a, b, c);
                case TLK.X37: return f37(a, b, c);
                case TLK.X38: return f38(a, b, c);
                case TLK.X39: return f39(a, b, c);
                case TLK.X3A: return f3a(a, b, c);
                case TLK.X3B: return f3b(a, b, c);
                case TLK.X3C: return f3c(a, b, c);
                case TLK.X3D: return f3d(a, b, c);
                case TLK.X3E: return f3e(a, b, c);
                case TLK.X3F: return f3f(a, b, c);
                case TLK.X40: return f40(a, b, c);
                case TLK.X41: return f41(a, b, c);
                case TLK.X42: return f42(a, b, c);
                case TLK.X43: return f43(a, b, c);
                case TLK.X44: return f44(a, b, c);
                case TLK.X45: return f45(a, b, c);
                case TLK.X46: return f46(a, b, c);
                case TLK.X47: return f47(a, b, c);
                case TLK.X48: return f48(a, b, c);
                case TLK.X49: return f49(a, b, c);
                case TLK.X4A: return f4a(a, b, c);
                case TLK.X4B: return f4b(a, b, c);
                case TLK.X4C: return f4c(a, b, c);
                case TLK.X4D: return f4d(a, b, c);
                case TLK.X4E: return f4e(a, b, c);
                case TLK.X4F: return f4f(a, b, c);
                case TLK.X50: return f50(a, b, c);
                case TLK.X51: return f51(a, b, c);
                case TLK.X52: return f52(a, b, c);
                case TLK.X53: return f53(a, b, c);
                case TLK.X54: return f54(a, b, c);
                case TLK.X55: return f55(a, b, c);
                case TLK.X56: return f56(a, b, c);
                case TLK.X57: return f57(a, b, c);
                case TLK.X58: return f58(a, b, c);
                case TLK.X59: return f59(a, b, c);
                case TLK.X5A: return f5a(a, b, c);
                case TLK.X5B: return f5b(a, b, c);
                case TLK.X5C: return f5c(a, b, c);
                case TLK.X5D: return f5d(a, b, c);
                case TLK.X5E: return f5e(a, b, c);
                case TLK.X5F: return f5f(a, b, c);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [NumericClosures(UnsignedInts)]
        public static T eval<T>(BSK kind, T a, byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case BSK.Sll: return sll(a, count);
                case BSK.Srl: return srl(a, count);
                case BSK.Rotl: return rotl(a, count);
                case BSK.Rotr: return rotr(a, count);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [NumericClosures(Integers)]
        public static Shifter<T> lookup<T>(BSK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BSK.Sll: return sll;
                case BSK.Srl: return srl;
                case BSK.Rotl: return rotl;
                case BSK.Rotr: return rotr;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }


        [NumericClosures(Integers)]
        public static UnaryOp<T> lookup<T>(ULK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ULK.Not: return not;
                case ULK.Identity: return identity;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        public static BinaryOp<T> lookup<T>(BLK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true;
                case BLK.False: return @false;
                case BLK.And: return and;
                case BLK.Nand: return nand;
                case BLK.Or: return or;
                case BLK.Nor: return nor;
                case BLK.Xor: return xor;
                case BLK.Xnor: return xnor;
                case BLK.LProject: return left;
                case BLK.RProject: return right;
                case BLK.LNot: return lnot;
                case BLK.RNot: return rnot;
                case BLK.Impl: return impl;
                case BLK.NonImpl: return nonimpl;
                case BLK.CImpl: return cimpl;
                case BLK.CNonImpl: return cnonimpl;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        public static TernaryOp<T> lookup<T>(TLK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case TLK.X01: return f01;
                case TLK.X02: return f02;
                case TLK.X03: return f03;
                case TLK.X04: return f04;
                case TLK.X05: return f05;
                case TLK.X06: return f06;
                case TLK.X07: return f07;
                case TLK.X08: return f08;
                case TLK.X09: return f09;
                case TLK.X0A: return f0a;
                case TLK.X0B: return f0b;
                case TLK.X0C: return f0c;
                case TLK.X0D: return f0d;
                case TLK.X0E: return f0e;
                case TLK.X0F: return f0f;
                case TLK.X10: return f10;
                case TLK.X11: return f11;
                case TLK.X12: return f12;
                case TLK.X13: return f13;
                case TLK.X14: return f14;
                case TLK.X15: return f15;
                case TLK.X16: return f16;
                case TLK.X17: return f17;
                case TLK.X18: return f18;
                case TLK.X19: return f19;
                case TLK.X1A: return f1a;
                case TLK.X1B: return f1b;
                case TLK.X1C: return f1c;
                case TLK.X1D: return f1d;
                case TLK.X1E: return f1e;
                case TLK.X1F: return f1f;
                case TLK.X20: return f20;
                case TLK.X21: return f21;
                case TLK.X22: return f22;
                case TLK.X23: return f23;
                case TLK.X24: return f24;
                case TLK.X25: return f25;
                case TLK.X26: return f26;
                case TLK.X27: return f27;
                case TLK.X28: return f28;
                case TLK.X29: return f29;
                case TLK.X2A: return f2a;
                case TLK.X2B: return f2b;
                case TLK.X2C: return f2c;
                case TLK.X2D: return f2d;
                case TLK.X2E: return f2e;
                case TLK.X2F: return f2f;
                case TLK.X30: return f30;
                case TLK.X31: return f31;
                case TLK.X32: return f32;
                case TLK.X33: return f33;
                case TLK.X34: return f34;
                case TLK.X35: return f35;
                case TLK.X36: return f36;
                case TLK.X37: return f37;
                case TLK.X38: return f38;
                case TLK.X39: return f39;
                case TLK.X3A: return f3a;
                case TLK.X3B: return f3b;
                case TLK.X3C: return f3c;
                case TLK.X3D: return f3d;
                case TLK.X3E: return f3e;
                case TLK.X3F: return f3f;
                case TLK.X40: return f40;
                case TLK.X41: return f41;
                case TLK.X42: return f42;
                case TLK.X43: return f43;
                case TLK.X44: return f44;
                case TLK.X45: return f45;
                case TLK.X46: return f46;
                case TLK.X47: return f47;
                case TLK.X48: return f48;
                case TLK.X49: return f49;
                case TLK.X4A: return f4a;
                case TLK.X4B: return f4b;
                case TLK.X4C: return f4c;
                case TLK.X4D: return f4d;
                case TLK.X4E: return f4e;
                case TLK.X4F: return f4f;
                case TLK.X50: return f50;
                case TLK.X51: return f51;
                case TLK.X52: return f52;
                case TLK.X53: return f53;
                case TLK.X54: return f54;
                case TLK.X55: return f55;
                case TLK.X56: return f56;
                case TLK.X57: return f57;
                case TLK.X58: return f58;
                case TLK.X59: return f59;
                case TLK.X5A: return f5a;
                case TLK.X5B: return f5b;
                case TLK.X5C: return f5c;
                case TLK.X5D: return f5d;
                case TLK.X5E: return f5e;
                case TLK.X5F: return f5f;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T identity<T>(T a)
        //     where T : unmanaged
        //         => gmath.identity(a);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @false<T>()
        //     where T:unmanaged
        //         => gmath.@false<T>();

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @false<T>(T a)
        //     where T:unmanaged
        //         => gmath.@false(a);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @false<T>(T a, T b)
        //     where T:unmanaged
        //         => gmath.@false(a,b);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @false<T>(T a, T b, T c)
        //     where T:unmanaged
        //         => gmath.@false(a,b,c);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @true<T>()
        //     where T:unmanaged
        //         => gmath.@true<T>();

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @true<T>(T a)
        //     where T:unmanaged
        //         => gmath.@true(a);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @true<T>(T a, T b)
        //     where T:unmanaged
        //         => gmath.@true(a, b);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T @true<T>(T a, T b, T c)
        //     where T:unmanaged
        //         => gmath.@true(a, b, c);

        // [MethodImpl(Inline), Op, Closures(Integers)]
        // public static T not<T>(T a)
        //     where T : unmanaged
        //         => gmath.not(a);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T xor1<T>(T a)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte))
        //         return generic<T>((byte)(uint8(a) ^ byte.MaxValue));
        //     else if(typeof(T) == typeof(ushort))
        //         return generic<T>(uint16(a)^ ushort.MaxValue);
        //     else if(typeof(T) == typeof(uint))
        //         return generic<T>(uint32(a)^ uint.MaxValue);
        //     else if(typeof(T) == typeof(ulong))
        //         return generic<T>(uint64(a)^ ulong.MaxValue);
        //     else
        //         throw Unsupported.define<T>();
        // }

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static bit testc<T>(T a)
        //     where T : unmanaged
        //         => gbits.pop(a) == bitsize<T>();

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T and<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.and(a,b);

        // [MethodImpl(Inline)]
        // public static T nand<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.nand(a,b);

        // [MethodImpl(Inline)]
        // public static T or<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.or(a,b);

        // [MethodImpl(Inline)]
        // public static T nor<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.nor(a,b);

        // [MethodImpl(Inline)]
        // public static T xor<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.xor(a,b);

        // [MethodImpl(Inline)]
        // public static T xnor<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.xnor(a,b);

        // [MethodImpl(Inline)]
        // public static T left<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.left(a,b);

        // [MethodImpl(Inline)]
        // public static T right<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.right(a,b);

        // [MethodImpl(Inline)]
        // public static T lnot<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.lnot(a,b);

        // [MethodImpl(Inline)]
        // public static T rnot<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.rnot(a,b);

        // [MethodImpl(Inline)]
        // public static T impl<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.impl(a,b);

        // [MethodImpl(Inline)]
        // public static T nonimpl<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.nonimpl(a,b);

        // [MethodImpl(Inline)]
        // public static T cimpl<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.cimpl(a,b);

        // [MethodImpl(Inline)]
        // public static T cnonimpl<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.cnonimpl(a,b);

        // [MethodImpl(Inline)]
        // public static T xornot<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.xornot(a,b);

        // [MethodImpl(Inline)]
        // public static T add<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.add(a,b);

        // [MethodImpl(Inline)]
        // public static T sub<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.sub(a,b);

        // [MethodImpl(Inline)]
        // public static T div<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.div(a,b);

        // [MethodImpl(Inline)]
        // public static T mod<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.mod(a,b);

        // [MethodImpl(Inline)]
        // public static T negate<T>(T a)
        //     where T : unmanaged
        //         => gmath.negate(a);

        // [MethodImpl(Inline)]
        // public static T inc<T>(T a)
        //     where T : unmanaged
        //         => gmath.inc(a);

        // [MethodImpl(Inline)]
        // public static T dec<T>(T a)
        //     where T : unmanaged
        //         => gmath.dec(a);

        // [MethodImpl(Inline)]
        // public static T equals<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.eq(a,b).Promote<T>();

        // [MethodImpl(Inline)]
        // public static T neq<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.neq(a,b).Promote<T>();

        // [MethodImpl(Inline)]
        // public static T lt<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.lt(a,b).Promote<T>();

        // [MethodImpl(Inline)]
        // public static T lteq<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.lteq(a,b).Promote<T>();

        // [MethodImpl(Inline)]
        // public static T gt<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.gt(a,b).Promote<T>();

        // [MethodImpl(Inline)]
        // public static T gteq<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.gteq(a,b).Promote<T>();

        // [MethodImpl(Inline)]
        // public static bit same<T>(T a, T b)
        //     where T : unmanaged
        //         => gmath.eq(a,b);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T sll<T>(T a, byte count)
        //     where T : unmanaged
        //         => gmath.sll(a, count);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T srl<T>(T a, byte count)
        //     where T : unmanaged
        //         => gmath.srl(a, count);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T rotl<T>(T a, byte count)
        //     where T : unmanaged
        //         => gbits.rotl(a, count);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T rotr<T>(T a, byte count)
        //     where T : unmanaged
        //         => gbits.rotr(a, count);


        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T select<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => gmath.select(a,b,c);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f00<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => default;

        // // a nor (b or c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f01<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => nor(a, or(b,c));

        // // c and (b nor a)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f02<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(c, nor(b,a));

        //  // b nor a
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f03<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(b,a);

        // // b and (a nor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f04<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(b, nor(a,c));

        // // c nor a
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f05<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(c,a);

        // // not a and (b xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f06<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(a), xor(b,c));

        // // not a and (b xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f07<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(a, and(b,c));

        // // (not a and b) and c
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f08<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(and(not(a),b), c);

        // // a nor (b xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f09<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(a, xor(b,c));

        // // c and (not a)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f0a<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(c, not(a));

        // // not a and ((b xor 1) or c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f0b<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(a), or(xor1(b),  c));

        // // b and (not a)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f0c<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(b, not(a));

        // // not a and (b or (c xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f0d<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(a), or(b, xor1(c)));

        // // not a and (b or c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f0e<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(a),or(b,c));

        // // not a
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f0f<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => not(a);

        // // a and (b nor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f10<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(a, nor(b, c));

        // // c nor b
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f11<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(c,b);

        // // not b and (a xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f12<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(b), xor(a,c));

        // // b nor (a and c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f13<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(b, and(a,c));

        // // not c and (a xor b)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f14<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(c), xor(a,b));

        // // c nor (b and a)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f15<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(c, and(a,b));

        // // a ? (b nor c) : (b xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f16<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(a, nor(b,c), xor(b,c));

        // // not(a ? (b or c) : (b and c))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f17<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => not(select(a, or(b,c), and(b,c)));

        // // (a xor b) and (a xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f18<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(xor(a,b), xor(a,c));

        // // not(((B xor C) xor (A and (B and C))))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f19<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => not(xor(xor(b,c), and(a, and(b,c))));

        // // not ((A and B)) and (A xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f1a<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(and(a,b)), xor(a,c));

        // // c ? not a : not b
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f1b<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(c, not(a), not(b));

        // //not ((a and c)) and (a xor b)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f1c<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(and(a,c)), xor(a,b));

        // //b ? (not a) : (not c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f1d<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(b, not(a), not(c));

        // //a xor (b or c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f1e<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(a, or(b,c));

        // // a nand (b or c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f1f<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nand(a, or(b,c));

        // //((not b) and a) and C
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f20<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(and(not(b),a),c);

        // // b nor (a xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f21<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nor(b, xor(a,c));

        // // c and (not b)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f22<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => cnonimpl(c,b);

        // // not (B) and ((A xor 1) or C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f23<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(b), or(not(a),c));

        // // (a xor b) and (b xor c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f24<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(xor(a,b), xor(b,c));

        // // (not ((A and B)) and (A xor (C xor 1)))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f25<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(and(a,b)), xor(a, not(c)));

        // // not ((A and B)) and (B xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f26<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(and(a,b)),xor(b,c));

        // //C ? not (B) : not (A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f27<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(c,not(b), not(a));

        // //C and (B xor A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f28<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(c,xor(b,a));

        // // C ? (B xor A) : (B nor A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f29<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(c, xor(b,a),nor(b,a));

        // // C and (B nand A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f2a<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(c,nand(b,a));

        // // C ? (B nand A) : (B nor A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f2b<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(c,nand(b,a), nor(b,a));

        // // (B or C) and (A xor B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f2c<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(or(b,c), xor(a,b));

        // // A xor (B or not (C))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f2d<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(a, or(b, not(c)));

        // // (B or C) xor (A and B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f2e<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(or(b,c),and(a,b));

        // // not (A) or (not (B) and C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f2f<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => or(not(a),(and(not(b),c)));

        // // a and not(b)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f30<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => cnonimpl(a,b);

        // // not (B) and (A or (C xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f31<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(b), or(a,not(c)));

        // //not (B) and (A or C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f32<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(b),or(a,c));

        // // not (B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f33<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => not(b);

        // // not ((B and C)) and (A xor B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f34<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => and(not(and(b,c)), xor(a,b));

        // // A ? not (B) : not (C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f35<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => select(a,not(b),not(c));

        // // B xor (A or C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f36<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => xor(b,or(a,c));

        // // B nand (A or C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f37<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => nand(b,or(a,c));

        // // (A or C) and (A xor B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f38<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => and(or(a,c), xor(a,b));

        // // B xor (A or (C xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f39<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(b, or(a, not(c)));

        // // A ? not (B) : C
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f3a<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => select(a, not(b), c);

        // // (not (A) and C) or (B xor 1)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f3b<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => or(and(not(a),c),xor1(b));

        // // B xor A
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f3c<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(b,a);

        // // ((A xor B) or (A nor C))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f3d<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => or(xor(b,a),nor(a,c));

        // // (not (A) and C) or (A xor B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f3e<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => or(and(not(a),c),xor(a,b));

        // // B nand A
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f3f<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => nand(b,a);

        // // (not (C) and A) and B
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f40<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(and(not(c),a),b);

        // // C nor (B xor A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f41<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => nor(c,xor(b,a));

        // // (A xor C) and (B xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f42<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(xor(a,c),xor(b,c));

        // // not ((A and C)) and (A xor (B xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f43<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(and(a,c)), xor(a,xor1(b)));

        // // B and not (C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f44<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => cnonimpl(b,c);

        // // not (C) and ((A xor 1) or B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f45<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => and(not(c), or(xor1(a), b));

        // // not ((A and C)) and (B xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f46<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => and(not(and(a,c)),xor(b,c));

        // // B ? not (C) : not (A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f47<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => select(b,not(c),not(a));

        // // B and (A xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f48<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => and(b,xor(a,c));

        // // B ? (A xor C) : (A nor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f49<T>(T a, T b, T c)
        //     where T : unmanaged
        //     => select(b,xor(a,c),nor(a,c));

        // // (B or C) and (A xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f4a<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(or(b,c), xor(a,c));

        //  // A xor (not (B) or C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f4b<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(a, or(not(b), c));

        // // B and (A nand C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f4c<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(b, nand(a,c));

        // // B ? (A nand C) : (A nor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f4d<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(b, nand(a,c),nor(a,c));

        // // C ? not (A) : B
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f4e<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(c, not(a), b);

        // // not (A) or (B and not (C))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f4f<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => or(not(a),cnonimpl(b,c));

        // // A and not (C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f50<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => cnonimpl(a,c);

        // // not (C) and (A or (B xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f51<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(c),or(a,xor1(b)));

        // // not ((B and C)) and (A xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f52<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(and(b,c)),xor(a,c));

        // // A ? not (C) : not (B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f53<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(a, not(c), not(b));

        // // not (C) and (A or B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f54<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(not(c), or(a,b));

        // // not (C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f55<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => not(c);

        // // C xor (B or A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f56<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(c,or(b,a));

        // // C nand (B or A)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f57<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nand(c,or(b,a));

        // // (A or B) and (A xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f58<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => and(or(a,b),xor(a,c));

        // // C xor (A or (B xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f59<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(c, or(a, not(b)));

        // // C xor A
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f5a<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => xor(c,a);

        // //((A xor C) or ((A or B) xor 1))
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f5b<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => or(xor(a,c), xor(or(a,b), maxval<T>()));

        // //(A ? not (C) : B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f5c<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(a,not(c), b);

        // // not (C) or (not (A) and B)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f5d<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => or(not(c), and(not(a), b));

        // // (not (C) and B) or (A xor C)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f5e<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => or(and(not(c),b),(xor(a,c)));

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f5f<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => nand(c,a);

        // // a ? (b xnor c) : (b nand c)
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static T f97<T>(T a, T b, T c)
        //     where T : unmanaged
        //         => select(c, xnor(b,c), nand(b,c));
    }
}