//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static Core;
    using static TernaryBitLogicKind;
    using static OpHelpers;
    using static VectorizedOps;

    /// <summary>
    /// Defines services for 128-bit instrinsic operators
    /// </summary>
    //[ApiHost("vector.api", ApiHostKind.Generic)]
    public static partial class VectorOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<UnaryBitLogicKind> UnaryBitLogicKinds
            => NumericOpApi.UnaryBitLogicKinds;

        /// <summary>
        /// Advertises the supported binary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicKind> BinaryBitLogicKinds
            => NumericOpApi.BinaryBitLogicKinds;

        /// <summary>
        /// Advertises the supported ternary bitlogic opeators
        /// </summary>
        public static ReadOnlySpan<TernaryBitLogicKind> TernaryBitLogicKinds
            => Numeric.range((byte)1,(byte)X18).Cast<TernaryBitLogicKind>().ToArray();

        /// <summary>
        /// Specifies the supported comparison operators
        /// </summary>
        public static ReadOnlySpan<BinaryComparisonKind> ComparisonKinds
            => array(BinaryComparisonKind.Eq, BinaryComparisonKind.Lt, BinaryComparisonKind.Gt);            

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> eval<T>(UnaryBitLogicKind kind, Vector128<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not(a);
                case UnaryBitLogicKind.Identity: return identity(a);
                case UnaryBitLogicKind.False: return @false(a);
                case UnaryBitLogicKind.True: return @true(a);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> eval<T>(UnaryBitLogicKind kind, Vector256<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not(a);
                case UnaryBitLogicKind.Identity: return identity(a);
                case UnaryBitLogicKind.False: return @false(a);
                case UnaryBitLogicKind.True: return @true(a);
                default: throw new NotSupportedException(sig<T>(kind));
             }
        }

        /// <summary>
        /// Evaluates a comparison operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> eval<T>(BinaryComparisonKind kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BinaryComparisonKind.Eq: return equals(a,b);
                case BinaryComparisonKind.Lt: return lt(a,b);
                case BinaryComparisonKind.Gt: return gt(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }         
        }

        /// <summary>
        /// Evaluates a comparison operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> eval<T>(BinaryComparisonKind kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BinaryComparisonKind.Eq: return equals(a,b);
                case BinaryComparisonKind.Lt: return lt(a,b);
                case BinaryComparisonKind.Gt: return gt(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }         
        }

        /// <summary>
        /// Evaluates an identified binary bitwise operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> eval<T>(BinaryBitLogicKind kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true(a,b);
                case BinaryBitLogicKind.False: return @false(a,b);
                case BinaryBitLogicKind.And: return and(a,b);
                case BinaryBitLogicKind.Nand: return nand(a,b);
                case BinaryBitLogicKind.Or: return or(a,b);
                case BinaryBitLogicKind.Nor: return nor(a,b);
                case BinaryBitLogicKind.Xor: return xor(a,b);
                case BinaryBitLogicKind.Xnor: return xnor(a,b);
                case BinaryBitLogicKind.LProject: return left(a,b);
                case BinaryBitLogicKind.RProject: return right(a,b);
                case BinaryBitLogicKind.LNot: return lnot(a,b);
                case BinaryBitLogicKind.RNot: return rnot(a,b);
                case BinaryBitLogicKind.Impl: return impl(a,b);
                case BinaryBitLogicKind.NonImpl: return nonimpl(a,b);
                case BinaryBitLogicKind.CImpl: return cimpl(a,b);
                case BinaryBitLogicKind.CNonImpl: return cnonimpl(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified binary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> eval<T>(BinaryBitLogicKind kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true(a,b);
                case BinaryBitLogicKind.False: return @false(a,b);
                case BinaryBitLogicKind.And: return and(a,b);
                case BinaryBitLogicKind.Nand: return nand(a,b);
                case BinaryBitLogicKind.Or: return or(a,b);
                case BinaryBitLogicKind.Nor: return nor(a,b);
                case BinaryBitLogicKind.Xor: return xor(a,b);
                case BinaryBitLogicKind.Xnor: return xnor(a,b);
                case BinaryBitLogicKind.LProject: return left(a,b);
                case BinaryBitLogicKind.RProject: return right(a,b);
                case BinaryBitLogicKind.LNot: return lnot(a,b);
                case BinaryBitLogicKind.RNot: return rnot(a,b);
                case BinaryBitLogicKind.Impl: return impl(a,b);
                case BinaryBitLogicKind.NonImpl: return nonimpl(a,b);
                case BinaryBitLogicKind.CImpl: return cimpl(a,b);
                case BinaryBitLogicKind.CNonImpl: return cnonimpl(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an ternary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> eval<T>(TernaryBitLogicKind kind, Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => lookup<T>(n128,kind)(x,y,z);

        /// <summary>
        /// Evaluates an ternary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> eval<T>(TernaryBitLogicKind kind, Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => lookup<T>(n256,kind)(x,y,z);

        /// <summary>
        /// Evaluates an identified shift operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The subject</param>
        /// <param name="count">The shift bit count</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> eval<T>(ShiftOpKind kind, Vector128<T> a, [Imm] byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll(a,count);
                case ShiftOpKind.Srl: return srl(a,count);
                case ShiftOpKind.Rotl: return rotl(a,count);
                case ShiftOpKind.Rotr: return rotr(a,count);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified shift operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The subject</param>
        /// <param name="count">The shift amount</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> eval<T>(ShiftOpKind kind, Vector256<T> a, [Imm] byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll(a,count);
                case ShiftOpKind.Srl: return srl(a,count);
                case ShiftOpKind.Rotl: return rotl(a,count);
                case ShiftOpKind.Rotr: return rotr(a,count);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> eval<T>(BinaryArithmeticKind kind, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryArithmeticKind.Add: return add(x,y);
                case BinaryArithmeticKind.Sub: return sub(x,y);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> eval<T>(BinaryArithmeticKind kind, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryArithmeticKind.Add: return add(x,y);
                case BinaryArithmeticKind.Sub: return sub(x,y);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static UnaryOp<Vector128<T>> lookup<T>(N128 w, UnaryBitLogicKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not;
                case UnaryBitLogicKind.Identity: return identity;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static UnaryOp<Vector256<T>> lookup<T>(N256 w, UnaryBitLogicKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not;
                case UnaryBitLogicKind.Identity: return identity;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector128<T>> lookup<T>(N128 w,BinaryComparisonKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryComparisonKind.Eq: return equals;
                case BinaryComparisonKind.Lt: return lt;
                case BinaryComparisonKind.Gt: return gt;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector256<T>> lookup<T>(N256 w, BinaryComparisonKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryComparisonKind.Eq: return equals;
                case BinaryComparisonKind.Lt: return lt;
                case BinaryComparisonKind.Gt: return gt;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Shifter<Vector128<T>> lookup<T>(N128 w, ShiftOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll;
                case ShiftOpKind.Srl: return srl;
                case ShiftOpKind.Rotl: return rotl;
                case ShiftOpKind.Rotr: return rotr;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Shifter<Vector256<T>> lookup<T>(N256 w, ShiftOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll;
                case ShiftOpKind.Srl: return srl;
                case ShiftOpKind.Rotl: return rotl;
                case ShiftOpKind.Rotr: return rotr;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector128<T>> lookup<T>(N128 w, BinaryBitLogicKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true;
                case BinaryBitLogicKind.False: return @false;
                case BinaryBitLogicKind.And: return and;
                case BinaryBitLogicKind.Nand: return nand;
                case BinaryBitLogicKind.Or: return or;
                case BinaryBitLogicKind.Nor: return nor;
                case BinaryBitLogicKind.Xor: return xor;
                case BinaryBitLogicKind.Xnor: return xnor;
                case BinaryBitLogicKind.LProject: return left;
                case BinaryBitLogicKind.RProject: return right;
                case BinaryBitLogicKind.LNot: return lnot;
                case BinaryBitLogicKind.RNot: return rnot;
                case BinaryBitLogicKind.Impl: return impl;
                case BinaryBitLogicKind.NonImpl: return nonimpl;
                case BinaryBitLogicKind.CImpl: return cimpl;
                case BinaryBitLogicKind.CNonImpl: return cnonimpl;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector256<T>> lookup<T>(N256 w, BinaryBitLogicKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true;
                case BinaryBitLogicKind.False: return @false;
                case BinaryBitLogicKind.And: return and;
                case BinaryBitLogicKind.Nand: return nand;
                case BinaryBitLogicKind.Or: return or;
                case BinaryBitLogicKind.Nor: return nor;
                case BinaryBitLogicKind.Xor: return xor;
                case BinaryBitLogicKind.Xnor: return xnor;
                case BinaryBitLogicKind.LProject: return left;
                case BinaryBitLogicKind.RProject: return right;
                case BinaryBitLogicKind.LNot: return lnot;
                case BinaryBitLogicKind.RNot: return rnot;
                case BinaryBitLogicKind.Impl: return impl;
                case BinaryBitLogicKind.NonImpl: return nonimpl;
                case BinaryBitLogicKind.CImpl: return cimpl;
                case BinaryBitLogicKind.CNonImpl: return cnonimpl;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static TernaryOp<Vector128<T>> lookup<T>(N128 w, TernaryBitLogicKind kind)
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
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static TernaryOp<Vector256<T>> lookup<T>(N256 w, TernaryBitLogicKind kind)
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
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}