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

    using static Seed;    
    using static Memories;
    using static TernaryLogicKind;
    using static OpHelpers;
    using static VectorizedOps;
    using static LogicSig;

    using ULK = UnaryLogicKind;
    using BLK = BinaryLogicKind;
    using TLK = TernaryLogicKind;
    using UAR = UnaryArithmeticKind;
    using BAR = BinaryArithmeticKind;
    using BCK = BinaryComparisonKind;
    using BSK = BitShiftKind;

    /// <summary>
    /// Defines services for 128-bit instrinsic operators
    /// </summary>
    //[ApiHost("vector.api", ApiHostKind.Generic)]
    public static partial class VectorOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<ULK> UnaryBitLogicKinds
            => NumericOpApi.UnaryLogicKinds;

        /// <summary>
        /// Advertises the supported binary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<BLK> BinaryBitLogicKinds
            => NumericOpApi.BinaryLogicKinds;

        /// <summary>
        /// Advertises the supported ternary bitlogic opeators
        /// </summary>
        public static ReadOnlySpan<TLK> TernaryBitLogicKinds
            => gmath.range((byte)1,(byte)X18).Cast<TLK>().ToArray();

        /// <summary>
        /// Specifies the supported comparison operators
        /// </summary>
        public static ReadOnlySpan<BCK> ComparisonKinds
            => array(BCK.Eq, BCK.Lt, BCK.Gt);            

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Vector128<T> eval<T>(ULK kind, Vector128<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case ULK.Not: return gvec.vnot(a);
                case ULK.Identity: return gvec.videntity(a);
                case ULK.False: return gvec.vfalse(a);
                case ULK.True: return gvec.vtrue(a);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified unary operator over a supplied operand
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Vector256<T> eval<T>(ULK kind, Vector256<T> a)
            where T : unmanaged
        {
            switch(kind)
            {
                case ULK.Not: return gvec.vnot(a);
                case ULK.Identity: return gvec.videntity(a);
                case ULK.False: return gvec.vfalse(a);
                case ULK.True: return gvec.vtrue(a);
                default: throw Unsupported.define<T>(sig<T>(kind));
             }
        }

        /// <summary>
        /// Evaluates a comparison operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(AllNumeric)]
        public static Vector128<T> eval<T>(BCK kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BCK.Eq: return gvec.veq(a,b);
                case BCK.Lt: return gvec.vlt(a,b);
                case BCK.Gt: return gvec.vgt(a,b);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }         
        }

        /// <summary>
        /// Evaluates a comparison operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Vector256<T> eval<T>(BCK kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BCK.Eq: return gvec.veq(a,b);
                case BCK.Lt: return gvec.vlt(a,b);
                case BCK.Gt: return gvec.vgt(a,b);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }         
        }

        /// <summary>
        /// Evaluates an identified binary bitwise operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Vector128<T> eval<T>(BLK kind, Vector128<T> a, Vector128<T> b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return gvec.vtrue(a,b);
                case BLK.False: return gvec.vfalse(a,b);
                case BLK.And: return gvec.vand(a,b);
                case BLK.Nand: return gvec.vnand(a,b);
                case BLK.Or: return gvec.vor(a,b);
                case BLK.Nor: return gvec.vnor(a,b);
                case BLK.Xor: return gvec.vxor(a,b);
                case BLK.Xnor: return gvec.vxnor(a,b);
                case BLK.LProject: return gvec.vleft(a,b);
                case BLK.RProject: return gvec.vright(a,b);
                case BLK.LNot: return gvec.vlnot(a,b);
                case BLK.RNot: return gvec.vrnot(a,b);
                case BLK.Impl: return gvec.vimpl(a,b);
                case BLK.NonImpl: return gvec.vnonimpl(a,b);
                case BLK.CImpl: return gvec.vcimpl(a,b);
                case BLK.CNonImpl: return gvec.vcnonimpl(a,b);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified binary operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Vector256<T> eval<T>(BLK kind, Vector256<T> a, Vector256<T> b)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return gvec.vtrue(a,b);
                case BLK.False: return gvec.vfalse(a,b);
                case BLK.And: return gvec.vand(a,b);
                case BLK.Nand: return gvec.vnand(a,b);
                case BLK.Or: return gvec.vor(a,b);
                case BLK.Nor: return gvec.vnor(a,b);
                case BLK.Xor: return gvec.vxor(a,b);
                case BLK.Xnor: return gvec.vxnor(a,b);
                case BLK.LProject: return gvec.vleft(a,b);
                case BLK.RProject: return gvec.vright(a,b);
                case BLK.LNot: return gvec.vlnot(a,b);
                case BLK.RNot: return gvec.vrnot(a,b);
                case BLK.Impl: return gvec.vimpl(a,b);
                case BLK.NonImpl: return gvec.vnonimpl(a,b);
                case BLK.CImpl: return gvec.vcimpl(a,b);
                case BLK.CNonImpl: return gvec.vcnonimpl(a,b);
                default: throw Unsupported.define<T>(sig<T>(kind));
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
        [Op, Closures(Integers)]
        public static Vector128<T> eval<T>(TLK kind, Vector128<T> x, Vector128<T> y, Vector128<T> z)
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
        [Op, Closures(Integers)]
        public static Vector256<T> eval<T>(TLK kind, Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => lookup<T>(n256,kind)(x,y,z);

        /// <summary>
        /// Evaluates an identified shift operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The subject</param>
        /// <param name="count">The shift bit count</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Vector128<T> eval<T>(BSK kind, Vector128<T> a, [Imm] byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case BSK.Sll: return gvec.vsll(a,count);
                case BSK.Srl: return gvec.vsrl(a,count);
                case BSK.Rotl: return gvec.vrotl(a,count);
                case BSK.Rotr: return gvec.vrotr(a,count);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Evaluates an identified shift operator over supplied operands
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <param name="a">The subject</param>
        /// <param name="count">The shift amount</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Vector256<T> eval<T>(BSK kind, Vector256<T> a, [Imm] byte count)
            where T : unmanaged
        {
            switch(kind)
            {
                case BSK.Sll: return gvec.vsll(a,count);
                case BSK.Srl: return gvec.vsrl(a,count);
                case BSK.Rotl: return gvec.vrotl(a,count);
                case BSK.Rotr: return gvec.vrotr(a,count);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(AllNumeric)]
        public static Vector128<T> eval<T>(BAR kind, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BAR.Add: return gvec.vadd(x,y);
                case BAR.Sub: return gvec.vsub(x,y);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(AllNumeric)]
        public static Vector256<T> eval<T>(BAR kind, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BAR.Add: return gvec.vadd(x,y);
                case BAR.Sub: return gvec.vsub(x,y);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static UnaryOp<Vector128<T>> lookup<T>(N128 w, ULK kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ULK.Not: return gvec.vnot;
                case ULK.Identity: return gvec.videntity;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static UnaryOp<Vector256<T>> lookup<T>(N256 w, ULK kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ULK.Not: return gvec.vnot;
                case ULK.Identity: return gvec.videntity;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(Integers)]
        public static BinaryOp<Vector128<T>> lookup<T>(N128 w,BCK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BCK.Eq: return gvec.veq;
                case BCK.Lt: return gvec.vlt;
                case BCK.Gt: return gvec.vgt;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(Integers)]
        public static BinaryOp<Vector256<T>> lookup<T>(N256 w, BCK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BCK.Eq: return gvec.veq;
                case BCK.Lt: return gvec.vlt;
                case BCK.Gt: return gvec.vgt;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Shifter<Vector128<T>> lookup<T>(N128 w, BSK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BSK.Sll: return gvec.vsll;
                case BSK.Srl: return gvec.vsrl;
                case BSK.Rotl: return gvec.vrotl;
                case BSK.Rotr: return gvec.vrotr;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static Shifter<Vector256<T>> lookup<T>(N256 w, BSK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BSK.Sll: return gvec.vsll;
                case BSK.Srl: return gvec.vsrl;
                case BSK.Rotl: return gvec.vrotl;
                case BSK.Rotr: return gvec.vrotr;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static BinaryOp<Vector128<T>> lookup<T>(N128 w, BLK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return gvec.vtrue;
                case BLK.False: return gvec.vfalse;
                case BLK.And: return gvec.vand;
                case BLK.Nand: return gvec.vnand;
                case BLK.Or: return gvec.vor;
                case BLK.Nor: return gvec.vnor;
                case BLK.Xor: return gvec.vxor;
                case BLK.Xnor: return gvec.vxnor;
                case BLK.LProject: return gvec.vleft;
                case BLK.RProject: return gvec.vright;
                case BLK.LNot: return gvec.vlnot;
                case BLK.RNot: return gvec.vrnot;
                case BLK.Impl: return gvec.vimpl;
                case BLK.NonImpl: return gvec.vnonimpl;
                case BLK.CImpl: return gvec.vcimpl;
                case BLK.CNonImpl: return gvec.vcnonimpl;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static BinaryOp<Vector256<T>> lookup<T>(N256 w, BLK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return gvec.vtrue;
                case BLK.False: return gvec.vfalse;
                case BLK.And: return gvec.vand;
                case BLK.Nand: return gvec.vnand;
                case BLK.Or: return gvec.vor;
                case BLK.Nor: return gvec.vnor;
                case BLK.Xor: return gvec.vxor;
                case BLK.Xnor: return gvec.vxnor;
                case BLK.LProject: return gvec.vleft;
                case BLK.RProject: return gvec.vright;
                case BLK.LNot: return gvec.vlnot;
                case BLK.RNot: return gvec.vrnot;
                case BLK.Impl: return gvec.vimpl;
                case BLK.NonImpl: return gvec.vnonimpl;
                case BLK.CImpl: return gvec.vcimpl;
                case BLK.CNonImpl: return gvec.vcnonimpl;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static TernaryOp<Vector128<T>> lookup<T>(N128 w, TLK kind)
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
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        /// <summary>
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [Op, Closures(Integers)]
        public static TernaryOp<Vector256<T>> lookup<T>(N256 w, TLK kind)
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
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }
    }
}