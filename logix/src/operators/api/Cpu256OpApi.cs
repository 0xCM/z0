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

    using static OpHelpers;
    using static CpuOps;    
    using static TernaryBitOpKind;
    using static zfunc;

    /// <summary>
    /// Defines services for 256-bit instrinsic operators
    /// </summary>
    public static partial class CpuOpApi
    {

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static Vector256<T> eval<T>(UnaryBitwiseOpKind kind, Vector256<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not(a);
                case UnaryBitwiseOpKind.Identity: return ScalarOps.identity(a);
                case UnaryBitwiseOpKind.Negate: return negate(a);
                default: return dne<UnaryBitwiseOpKind,Vector256<T>>(kind);            
            }
        }

        /// <summary>
        /// Evaluates a comparison operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static Vector256<T> eval<T>(ComparisonKind kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals(a,b);
                case ComparisonKind.Lt: return lt(a,b);
                case ComparisonKind.Gt: return gt(a,b);
                default: return dne<ComparisonKind,Vector256<T>>(kind);
            }
         
        }

        /// <summary>
        /// Evaluates an identified binary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static Vector256<T> eval<T>(BinaryBitwiseOpKind kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true(a,b);
                case BinaryBitwiseOpKind.And: return and(a,b);
                case BinaryBitwiseOpKind.Or: return or(a,b);
                case BinaryBitwiseOpKind.XOr: return xor(a,b);
                case BinaryBitwiseOpKind.Nand: return nand(a,b);
                case BinaryBitwiseOpKind.Nor: return nor(a,b);
                case BinaryBitwiseOpKind.Xnor: return xnor(a,b);
                case BinaryBitwiseOpKind.AndNot: return andnot(a,b);
                case BinaryBitwiseOpKind.LeftProject: return left(a,b);
                case BinaryBitwiseOpKind.LeftNot: return leftnot(a,b);
                case BinaryBitwiseOpKind.RightProject: return right(a,b);
                case BinaryBitwiseOpKind.RightNot: return rightnot(a,b);
                case BinaryBitwiseOpKind.False: return @false(a,b);
                default: return dne<BinaryBitwiseOpKind,Vector256<T>>(kind);
            }
        }

        /// <summary>
        /// Evaluates an identified shift operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The subject</param>
        /// <param name="offset">The shift amount</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(ShiftOpKind kind, Vector256<T> a, int offset)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll(a,offset);
                case ShiftOpKind.Srl: return srl(a,offset);
                case ShiftOpKind.Rotl: return rotl(a,offset);
                case ShiftOpKind.Rotr: return rotr(a,offset);
                default: return dne<ShiftOpKind,Vector256<T>>(kind);
            }
        }

        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(BinaryArithmeticOpKind kind, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryArithmeticOpKind.Add: return add(x,y);
                case BinaryArithmeticOpKind.Sub: return sub(x,y);
                case BinaryArithmeticOpKind.Eq: 
                case BinaryArithmeticOpKind.Lt: 
                case BinaryArithmeticOpKind.Gt: return eval((ComparisonKind)kind, x, y);
                default: return dne<BinaryArithmeticOpKind,Vector256<T>>(kind);
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
        [MethodImpl(Inline)]
        public static Vector256<T> eval<T>(TernaryBitOpKind kind, Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => lookup<T>(n256,kind)(x,y,z);

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static UnaryOp<Vector256<T>> lookup<T>(N256 n, UnaryBitwiseOpKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not;
                case UnaryBitwiseOpKind.Identity: return identity;
                case UnaryBitwiseOpKind.Negate: return negate;
                default: return dne<Vector256<T>>(kind);            
            }
        }

        public static BinaryOp<Vector256<T>> lookup<T>(N256 n, ComparisonKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals;
                case ComparisonKind.Lt: return lt;
                case ComparisonKind.Gt: return gt;
                default: return dne<Vector256<T>>(kind);
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static BinaryOp<Vector256<T>> lookup<T>(N256 n, BinaryBitwiseOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.And: return and;
                case BinaryBitwiseOpKind.Nand: return nand;
                case BinaryBitwiseOpKind.Or: return or;
                case BinaryBitwiseOpKind.Nor: return nor;
                case BinaryBitwiseOpKind.XOr: return xor;
                case BinaryBitwiseOpKind.Xnor: return xnor;
                case BinaryBitwiseOpKind.AndNot: return andnot;
                case BinaryBitwiseOpKind.False: return @false;
                case BinaryBitwiseOpKind.True: return @true;
                default: return dne<Vector256<T>>(kind);            
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static Shifter<Vector256<T>> lookup<T>(N256 n, ShiftOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll;
                case ShiftOpKind.Srl: return srl;
                case ShiftOpKind.Rotl: return rotl;
                case ShiftOpKind.Rotr: return rotr;
                default: return dne<Vector256<T>>(kind);            
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static TernaryOp<Vector256<T>> lookup<T>(N256 n, TernaryBitOpKind kind)
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
                default: return dne<Vector256<T>>(kind);            

            }
        }

    }

}