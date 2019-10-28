//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static TernaryBitOpKind;
    using static As;
    using static OpHelpers;
    using static CpuOps;

    /// <summary>
    /// Defines services for 128-bit instrinsic operators
    /// </summary>
    public static partial class CpuOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitwise operators
        /// </summary>
        public static UnaryBitwiseOpKind[] UnaryBitwiseKinds
            => new UnaryBitwiseOpKind[]{
                UnaryBitwiseOpKind.Not, UnaryBitwiseOpKind.Identity, UnaryBitwiseOpKind.Negate            
                };

        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static BinaryBitwiseOpKind[] BinaryBitwiseKinds
            => new BinaryBitwiseOpKind[]{
                BinaryBitwiseOpKind.And, BinaryBitwiseOpKind.Or, BinaryBitwiseOpKind.XOr,
                BinaryBitwiseOpKind.Nand, BinaryBitwiseOpKind.Nor, BinaryBitwiseOpKind.Xnor,
                BinaryBitwiseOpKind.AndNot, BinaryBitwiseOpKind.False, BinaryBitwiseOpKind.True
            };

        /// <summary>
        /// Specifies the supported comparison operators
        /// </summary>
        public static ComparisonKind[] ComparisonKinds
            => new ComparisonKind[]{
                ComparisonKind.Eq, 
                ComparisonKind.Lt, 
                ComparisonKind.Gt, 
            };


        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public static IEnumerable<TernaryBitOpKind> TernaryBitwiseKinds
            => range((byte)1,(byte)X1B).Cast<TernaryBitOpKind>();

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> eval<T>(UnaryBitwiseOpKind kind, Vector128<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not(a);
                case UnaryBitwiseOpKind.Identity: return identity(a);
                case UnaryBitwiseOpKind.Negate: return negate(a);
                default: return dne<UnaryBitwiseOpKind,Vector128<T>>(kind);            
            }
        }

        /// <summary>
        /// Evaluates a comparison operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static Vector128<T> eval<T>(ComparisonKind kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals(a,b);
                case ComparisonKind.Lt: return lt(a,b);
                case ComparisonKind.Gt: return gt(a,b);
                default: return dne<ComparisonKind,Vector128<T>>(kind);
            }         
        }

        /// <summary>
        /// Evaluates an identified binary bitwise operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static Vector128<T> eval<T>(BinaryBitwiseOpKind kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged
        {
            switch(kind)
            {
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
                case BinaryBitwiseOpKind.True: return @true(a,b);
                default:
                    return dne<BinaryBitwiseOpKind,Vector128<T>>(kind);
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
        public static Vector128<T> eval<T>(TernaryBitOpKind kind, Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => lookup<T>(n128,kind)(x,y,z);

        /// <summary>
        /// Evaluates an identified shift operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The subject</param>
        /// <param name="offset">The shift amount</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> eval<T>(ShiftOpKind kind, Vector128<T> a, int offset)
            where T : unmanaged
        {
            switch(kind)
            {
                case ShiftOpKind.Sll: return sll(a,offset);
                case ShiftOpKind.Srl: return srl(a,offset);
                case ShiftOpKind.Rotl: return rotl(a,offset);
                case ShiftOpKind.Rotr: return rotr(a,offset);
                default: return dne<ShiftOpKind,Vector128<T>>(kind);
            }
        }

        [MethodImpl(Inline)]
        public static Vector128<T> eval<T>(BinaryArithmeticOpKind kind, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryArithmeticOpKind.Add: return add(x,y);
                case BinaryArithmeticOpKind.Sub: return sub(x,y);
                case BinaryArithmeticOpKind.Eq: 
                case BinaryArithmeticOpKind.Lt: 
                case BinaryArithmeticOpKind.Gt: return eval((ComparisonKind)kind, x, y);
                default: return dne<BinaryArithmeticOpKind,Vector128<T>>(kind);
            }
        }


        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static UnaryOp<Vector128<T>> lookup<T>(N128 n, UnaryBitwiseOpKind id)
            where T : unmanaged            
        {
            switch(id)
            {
                case UnaryBitwiseOpKind.Not: return not;
                case UnaryBitwiseOpKind.Identity: return identity;
                case UnaryBitwiseOpKind.Negate: return negate;
                default: return dne<Vector128<T>>(id);
            }
        }

        public static BinaryOp<Vector128<T>> lookup<T>(N128 n,ComparisonKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals;
                case ComparisonKind.Lt: return lt;
                case ComparisonKind.Gt: return gt;
                default: return dne<Vector128<T>>(kind);
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
       public static Shifter<Vector128<T>> lookup<T>(N128 n, ShiftOpKind id)
            where T : unmanaged
        {
            switch(id)
            {
                case ShiftOpKind.Sll: return sll;
                case ShiftOpKind.Srl: return srl;
                case ShiftOpKind.Rotl: return rotl;
                case ShiftOpKind.Rotr: return rotr;
                default: return dne<Vector128<T>>(id);            
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
       public static BinaryOp<Vector128<T>> lookup<T>(N128 n, BinaryBitwiseOpKind id)
            where T : unmanaged
        {
            switch(id)
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
                default: return dne<Vector128<T>>(id);
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static TernaryOp<Vector128<T>> lookup<T>(N128 n, TernaryBitOpKind id)
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
                default: return dne<Vector128<T>>(id);
            }
        }
    }
}

