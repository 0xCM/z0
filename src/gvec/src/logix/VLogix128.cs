//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Konst;
    using static z;
    using static LogicSig;

    using ULK = UnaryBitLogicKind;
    using BLK = BinaryBitLogicKind;
    using TLK = TernaryBitLogicKind;
    using BSK = BitShiftApiClass;
    using BCK = BinaryComparisonApiClass;
    using BAR = BinaryArithmeticApiClass;

    [ApiHost]
    public static partial class VLogix
    {
        /// <summary>
        /// Advertises the supported unary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<ULK> UnaryBitLogicKinds
            => Enums.literals<ULK>();

        /// <summary>
        /// Advertises the supported binary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<BLK> BinaryBitLogicKinds
            => Enums.literals<BLK>();

        /// <summary>
        /// Advertises the supported ternary bitlogic operators
        /// </summary>
        public static ReadOnlySpan<TLK> TernaryBitLogicKinds
            => Algorithmic.stream((byte)1,(byte)TLK.X18).Cast<TLK>().ToArray();

        /// <summary>
        /// Specifies the supported comparison operators
        /// </summary>
        public static ReadOnlySpan<BCK> ComparisonKinds
            => array(BCK.Eq, BCK.Lt, BCK.Gt);

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
        /// Returns a kind-identified delegate if possible; otherwise, raises an exception
        /// </summary>
        /// <param name="kind">The operator kind</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        public static TernaryOp<Vector128<T>> lookup<T>(N128 w, TLK kind)
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
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        // a nor (b or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f01<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
            => gvec.vnor(a, gvec.vor(b,c));

        // c and (b nor a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f02<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(c, gvec.vnor(b,a));

         // b nor a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f03<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f04<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(b, gvec.vnor(a,c));

        // c nor a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f05<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f06<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vxor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f07<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(a, gvec.vand(b,c));

        // (not a and b) and c
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f08<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vand(gvec.vnot(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f09<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(a, gvec.vxor(b,c));

        // c and (not a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0a<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(c, gvec.vnot(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0b<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(gvec.vnot(b),  c));

        // b and (not a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0c<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(b, gvec.vnot(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0d<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(b, gvec.vnot(c)));

        // not a and (b or c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0e<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(a), gvec.vor(b,c));

        // not a
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f0f<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnot(a);

        // a and (b nor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f10<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(a, gvec.vnor(b, c));

        // c nor b
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f11<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(c,b);

        // not b and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f12<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(b), gvec.vxor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f13<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(b, gvec.vand(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f14<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vnot(c), gvec.vxor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f15<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnor(c, gvec.vand(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f16<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(a, gvec.vnor(b,c), gvec.vxor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f17<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnot(gvec.vselect(a, gvec.vor(b,c), gvec.vand(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f18<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vand(gvec.vxor(a,b), gvec.vxor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f19<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vxor(gvec.vxor(b,c), gvec.vand(a, gvec.vand(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f1a<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vnot(gvec.vand(gvec.vand(a,b), gvec.vxor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f1b<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(c, gvec.vnot(a), gvec.vnot(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> f97<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
                => gvec.vselect(c, gvec.vxnor(b,c), gvec.vnand(b,c));
    }
}