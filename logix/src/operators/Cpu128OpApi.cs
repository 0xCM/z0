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
    using static Ternary512OpKind;
    using static As;
    using static OpHelpers;
    using static Cpu128Ops;

    /// <summary>
    /// Defines services for 128-bit instrinsic operators
    /// </summary>
    public static class Cpu128OpApi
    {
        /// <summary>
        /// Advertises the supported unary bitwise operators
        /// </summary>
        public static IEnumerable<UnaryBitwiseOpKind> UnaryBitwiseKinds
            => items(UnaryBitwiseOpKind.Not, UnaryBitwiseOpKind.Identity, UnaryBitwiseOpKind.Negate);

        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static IEnumerable<BinaryBitwiseOpKind> BinaryKinds
            => items(
                BinaryBitwiseOpKind.And, BinaryBitwiseOpKind.Or, BinaryBitwiseOpKind.XOr,
                BinaryBitwiseOpKind.Nand, BinaryBitwiseOpKind.Nor, BinaryBitwiseOpKind.Xnor,
                BinaryBitwiseOpKind.AndNot, BinaryBitwiseOpKind.False, BinaryBitwiseOpKind.True
            );

        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public static IEnumerable<Ternary512OpKind> TernaryKinds
            => range((byte)1,(byte)X1B).Cast<Ternary512OpKind>();

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
                case UnaryBitwiseOpKind.Identity: return ScalarOps.identity(a);
                case UnaryBitwiseOpKind.Negate: return negate(a);
                default: return dne<UnaryBitwiseOpKind,Vector128<T>>(kind);            
            }
        }

        /// <summary>
        /// Evaluates an identified binary operator over supplied operands
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
                case BinaryBitwiseOpKind.And:
                    return and(a,b);
                case BinaryBitwiseOpKind.Or:
                    return or(a,b);
                case BinaryBitwiseOpKind.XOr:
                    return xor(a,b);
                case BinaryBitwiseOpKind.Nand:
                    return nand(a,b);
                case BinaryBitwiseOpKind.Nor:
                    return nor(a,b);
                case BinaryBitwiseOpKind.Xnor:
                    return xnor(a,b);
                case BinaryBitwiseOpKind.AndNot:
                    return andnot(a,b);
                case BinaryBitwiseOpKind.False:
                    return @false(a,b);
                case BinaryBitwiseOpKind.True:
                    return @true(a,b);
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
        public static Vector128<T> eval<T>(Ternary512OpKind kind, Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => lookup<T>(kind)(x,y,z);

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

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static UnaryOp<Vector128<T>> lookup<T>(UnaryBitwiseOpKind id)
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

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
       public static Shifter<Vector128<T>> lookup<T>(ShiftOpKind id)
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
       public static BinaryOp<Vector128<T>> lookup<T>(BinaryBitwiseOpKind id)
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
        public static TernaryOp<Vector128<T>> lookup<T>(Ternary512OpKind id)
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

