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

    using static zfunc;    
    using static TernaryBitLogicOpKind;
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
        public static ReadOnlySpan<UnaryBitLogicOpKind> UnaryBitLogicKinds
            => NumericOpApi.UnaryBitLogicKinds;

        /// <summary>
        /// Advertises the supported binary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicOpKind> BinaryBitLogicKinds
            => NumericOpApi.BinaryBitLogicKinds;

        /// <summary>
        /// Advertises the supported ternary bitlogic opeators
        /// </summary>
        public static ReadOnlySpan<TernaryBitLogicOpKind> TernaryBitLogicKinds
            => Numeric.range((byte)1,(byte)X18).Cast<TernaryBitLogicOpKind>().ToArray();

        /// <summary>
        /// Specifies the supported comparison operators
        /// </summary>
        public static ReadOnlySpan<ComparisonOpKindId> ComparisonKinds
            => array(ComparisonOpKindId.Eq, ComparisonOpKindId.Lt, ComparisonOpKindId.Gt);            

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> eval<T>(UnaryBitLogicOpKind kind, Vector128<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not(a);
                case UnaryBitLogicOpKind.Identity: return identity(a);
                case UnaryBitLogicOpKind.False: return @false(a);
                case UnaryBitLogicOpKind.True: return @true(a);
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
        public static Vector256<T> eval<T>(UnaryBitLogicOpKind kind, Vector256<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not(a);
                case UnaryBitLogicOpKind.Identity: return identity(a);
                case UnaryBitLogicOpKind.False: return @false(a);
                case UnaryBitLogicOpKind.True: return @true(a);
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
        public static Vector128<T> eval<T>(ComparisonOpKindId kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return equals(a,b);
                case ComparisonOpKindId.Lt: return lt(a,b);
                case ComparisonOpKindId.Gt: return gt(a,b);
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
        public static Vector256<T> eval<T>(ComparisonOpKindId kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return equals(a,b);
                case ComparisonOpKindId.Lt: return lt(a,b);
                case ComparisonOpKindId.Gt: return gt(a,b);
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
        public static Vector128<T> eval<T>(BinaryBitLogicOpKind kind, Vector128<T> a, Vector128<T> b)
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

        /// <summary>
        /// Evaluates an identified binary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> eval<T>(BinaryBitLogicOpKind kind, Vector256<T> a, Vector256<T> b)
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

        /// <summary>
        /// Evaluates an ternary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> eval<T>(TernaryBitLogicOpKind kind, Vector128<T> x, Vector128<T> y, Vector128<T> z)
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
        public static Vector256<T> eval<T>(TernaryBitLogicOpKind kind, Vector256<T> x, Vector256<T> y, Vector256<T> z)
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
        public static Vector128<T> eval<T>(ShiftOpKindId kind, Vector128<T> a, [Imm] byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKindId.Sll: return sll(a,count);
                case ShiftOpKindId.Srl: return srl(a,count);
                case ShiftOpKindId.Rotl: return rotl(a,count);
                case ShiftOpKindId.Rotr: return rotr(a,count);
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
        public static Vector256<T> eval<T>(ShiftOpKindId kind, Vector256<T> a, [Imm] byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKindId.Sll: return sll(a,count);
                case ShiftOpKindId.Srl: return srl(a,count);
                case ShiftOpKindId.Rotl: return rotl(a,count);
                case ShiftOpKindId.Rotr: return rotr(a,count);
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
        public static UnaryOp<Vector128<T>> lookup<T>(N128 w, UnaryBitLogicOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not;
                case UnaryBitLogicOpKind.Identity: return identity;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static UnaryOp<Vector256<T>> lookup<T>(N256 w, UnaryBitLogicOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not;
                case UnaryBitLogicOpKind.Identity: return identity;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector128<T>> lookup<T>(N128 w,ComparisonOpKindId kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return equals;
                case ComparisonOpKindId.Lt: return lt;
                case ComparisonOpKindId.Gt: return gt;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector256<T>> lookup<T>(N256 w, ComparisonOpKindId kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ComparisonOpKindId.Eq: return equals;
                case ComparisonOpKindId.Lt: return lt;
                case ComparisonOpKindId.Gt: return gt;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Shifter<Vector128<T>> lookup<T>(N128 w, ShiftOpKindId kind)
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

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static Shifter<Vector256<T>> lookup<T>(N256 w, ShiftOpKindId kind)
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

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector128<T>> lookup<T>(N128 w, BinaryBitLogicOpKind kind)
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

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, NumericClosures(NumericKind.Integers)]
        public static BinaryOp<Vector256<T>> lookup<T>(N256 w, BinaryBitLogicOpKind kind)
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

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static TernaryOp<Vector128<T>> lookup<T>(N128 w, TernaryBitLogicOpKind kind)
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
        public static TernaryOp<Vector256<T>> lookup<T>(N256 w, TernaryBitLogicOpKind kind)
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