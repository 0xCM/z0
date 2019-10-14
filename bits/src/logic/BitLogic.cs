//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static TernaryLogic;

    public static class BitLogic
    {        
        public const bool one = true;
        

        [MethodImpl(Inline)]
        public static Bit identity(Bit a)
            => a;

        [MethodImpl(Inline)]
        public static Bit not(Bit a)
            => ~a;

        [MethodImpl(Inline)]
        public static Bit xor1(Bit a)
            => a.Xor1();

        [MethodImpl(Inline)]
        public static Bit and(Bit a, Bit b)
            => a & b;

        [MethodImpl(Inline)]
        public static Bit nand(Bit a, Bit b)
            => a.Nand(b);

        [MethodImpl(Inline)]
        public static Bit or(Bit a, Bit b)
            => a | b;

        [MethodImpl(Inline)]
        public static Bit nor(Bit a, Bit b)
            => a.Nor(b);

        [MethodImpl(Inline)]
        public static Bit xor(Bit a, Bit b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static Bit xnor(Bit a, Bit b)
            => a.Xnor(b);

        [MethodImpl(Inline)]
        public static Bit andnot(Bit a, Bit b)
            => a.AndNot(b);


        [MethodImpl(Inline)]
        public static Bit select(Bit a, Bit b, Bit c)
            => a.Select(b,c);


        // a nor (b or c)
        [MethodImpl(Inline)]
        public static Bit f01(Bit a, Bit b, Bit c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static Bit f02(Bit a, Bit b, Bit c)
            => and(c, nor(b,a));

        // b nor a
        [MethodImpl(Inline)]
        public static Bit f03(Bit a, Bit b, Bit c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static Bit f04(Bit a, Bit b, Bit c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static Bit f05(Bit a, Bit b, Bit c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Bit f06(Bit a, Bit b, Bit c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Bit f07(Bit a, Bit b, Bit c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static Bit f08(Bit a, Bit b, Bit c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static Bit f09(Bit a, Bit b, Bit c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static Bit f0a(Bit a, Bit b, Bit c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static Bit f0b(Bit a, Bit b, Bit c)
            => and(not(a), or(b^one,  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static Bit f0c(Bit a, Bit b, Bit c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline)]
        public static Bit f0d(Bit a, Bit b, Bit c)
            => and(not(a), or(b, xor(c, one)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static Bit f0e(Bit a, Bit b, Bit c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static Bit f0f(Bit a, Bit b, Bit c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Bit f10(Bit a, Bit b, Bit c)
            => and(a, nor(b, c));        
        
        // c nor b
        [MethodImpl(Inline)]
        public static Bit f11(Bit a, Bit b, Bit c)
            => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static Bit f12(Bit a, Bit b, Bit c)
            => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static Bit f13(Bit a, Bit b, Bit c)
            => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static Bit f14(Bit a, Bit b, Bit c)
            => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static Bit f15(Bit a, Bit b, Bit c)
            => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static Bit f16(Bit a, Bit b, Bit c)
            => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static Bit f17(Bit a, Bit b, Bit c)
            => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static Bit f18(Bit a, Bit b, Bit c)
            => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static Bit f19(Bit a, Bit b, Bit c)
            => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static Bit f1a(Bit a, Bit b, Bit c)
            => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static Bit f1b(Bit a, Bit b, Bit c)
            => select(c, not(a), not(b));

        //not ((a and c)) and (a xor b)
        [MethodImpl(Inline)]
        public static Bit f1c(Bit a, Bit b, Bit c)
            => and(not(and(a,c)), xor(a,b));

        //b ? (not a) : (not c)
        [MethodImpl(Inline)]
        public static Bit f1d(Bit a, Bit b, Bit c)
            => select(b, not(a), not(c));

        //a xor (b or c)
        [MethodImpl(Inline)]
        public static Bit f1e(Bit a, Bit b, Bit c)
            => xor(a, or(b,c));

        // a nand (b or c)
        [MethodImpl(Inline)]
        public static Bit f1f(Bit a, Bit b, Bit c)
            => nand(a, or(b,c));

        //((not b) and a) and C
        [MethodImpl(Inline)]
        public static Bit f20(Bit a, Bit b, Bit c)
            => and(andnot(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline)]
        public static Bit f21(Bit a, Bit b, Bit c)
            => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline)]
        public static Bit f22(Bit a, Bit b, Bit c)
            => andnot(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline)]
        public static Bit f23(Bit a, Bit b, Bit c)
            => and(not(b),or(xor1(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline)]
        public static Bit f24(Bit a, Bit b, Bit c)
            => and(xor(a,b), xor(b,c));

        // (not ((A and B)) and (A xor (C xor 1)))
        [MethodImpl(Inline)]
        public static Bit f25(Bit a, Bit b, Bit c)
            => and(not(and(a,b)), xor(a, xor1(c)));

        public static UnaryOp<Bit> unaryop(UnaryLogic id)
        {
            switch(id)
            {
                case UnaryLogic.Not: return not;
                case UnaryLogic.Identity: return identity;
                default:
                    throw unsupported<Bit>();
            }
        }

        public static BinaryOp<Bit> binop(BinaryLogic id)
        {
            switch(id)
            {
                case BinaryLogic.And: return and;
                case BinaryLogic.Nand: return nand;
                case BinaryLogic.Or: return or;
                case BinaryLogic.Nor: return nor;
                case BinaryLogic.XOr: return xor;
                case BinaryLogic.XNor: return xnor;
                case BinaryLogic.AndNot: return andnot;
                default:
                    throw unsupported<Bit>();
            }
        }

        /// <summary>
        /// Advertises the supported operations
        /// </summary>
        public static IEnumerable<TernaryLogic> ternops
            => range((byte)1,0xf1b).Cast<TernaryLogic>();

        public static TernaryOp<Bit> ternop(TernaryLogic id)
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
                default: return select;

            }
        }

        public static BitMatrix<N4,N3,byte> table(BinaryLogic op)
        {
            var tt = BitMatrix.Alloc<N4,N3,byte>();
            var f = binop(op);
            tt[0] = BitVector.Define<N3,byte>(Bits.pack3(f(Bit.Off, Bit.Off), Bit.Off, Bit.Off));
            tt[1] = BitVector.Define<N3,byte>(Bits.pack3(f(Bit.On, Bit.Off), Bit.Off, Bit.On));
            tt[2] = BitVector.Define<N3,byte>(Bits.pack3(f(Bit.Off, Bit.On), Bit.On, Bit.Off));
            tt[3] = BitVector.Define<N3,byte>(Bits.pack3(f(Bit.On, Bit.On),  Bit.On, Bit.On));
            return tt;
        }

        static readonly Bit off = Bit.Off;
        static readonly Bit on = Bit.On;

        public static BitMatrix<N8,N4, byte> table(TernaryLogic op)
        {
            var tt = BitMatrix.Alloc<N8,N4,byte>();
            var f = ternop(op);
            tt[0] = BitVector.Define<N4,byte>(Bits.pack4(f(off, off, off), off, off, off));
            tt[1] = BitVector.Define<N4,byte>(Bits.pack4(f(off, off, on), off, off, on));
            tt[2] = BitVector.Define<N4,byte>(Bits.pack4(f(off, on, off), off, on, off));
            tt[3] = BitVector.Define<N4,byte>(Bits.pack4(f(off, on, on), off, on, on));
            tt[4] = BitVector.Define<N4,byte>(Bits.pack4(f(on, off, off), on, off, off));
            tt[5] = BitVector.Define<N4,byte>(Bits.pack4(f(on, off, on), on, off, on));
            tt[6] = BitVector.Define<N4,byte>(Bits.pack4(f(on, on, off), off, on, on));
            tt[7] = BitVector.Define<N4,byte>(Bits.pack4(f(on, on, on), on, on, on));
            return tt;
        }

    }

}
