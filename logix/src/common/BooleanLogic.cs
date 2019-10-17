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
    using static bit;
    using static TernaryLogicOpKind;

    public static class BooleanLogic
    {        
        public const bool one = true;
        
        // a nor (b or c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f01(bit a, bit b, bit c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline),TernaryOp(X02)]
        public static bit f02(bit a, bit b, bit c)
            => and(c, nor(b,a));

        // b nor a
        [MethodImpl(Inline),TernaryOp(X03)]
        public static bit f03(bit a, bit b, bit c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline),TernaryOp(X04)]
        public static bit f04(bit a, bit b, bit c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline),TernaryOp(X05)]
        public static bit f05(bit a, bit b, bit c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline),TernaryOp(X06)]
        public static bit f06(bit a, bit b, bit c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline),TernaryOp(X07)]
        public static bit f07(bit a, bit b, bit c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline),TernaryOp(X08)]
        public static bit f08(bit a, bit b, bit c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline),TernaryOp(X09)]
        public static bit f09(bit a, bit b, bit c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline),TernaryOp(X0A)]
        public static bit f0a(bit a, bit b, bit c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline),TernaryOp(X0B)]
        public static bit f0b(bit a, bit b, bit c)
            => and(not(a), or(b^one,  c));   

        // b and (not a)
        [MethodImpl(Inline),TernaryOp(X0C)]
        public static bit f0c(bit a, bit b, bit c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X0D)]
        public static bit f0d(bit a, bit b, bit c)
            => and(not(a), or(b, xor(c, one)));

        // not a and (b or c)
        [MethodImpl(Inline),TernaryOp(X0E)]
        public static bit f0e(bit a, bit b, bit c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline),TernaryOp(X0F)]
        public static bit f0f(bit a, bit b, bit c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline),TernaryOp(X10)]
        public static bit f10(bit a, bit b, bit c)
            => and(a, nor(b, c));        
        
        // c nor b
        [MethodImpl(Inline),TernaryOp(X11)]
        public static bit f11(bit a, bit b, bit c)
            => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline),TernaryOp(X12)]
        public static bit f12(bit a, bit b, bit c)
            => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline),TernaryOp(X13)]
        public static bit f13(bit a, bit b, bit c)
            => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline),TernaryOp(X14)]
        public static bit f14(bit a, bit b, bit c)
            => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline),TernaryOp(X15)]
        public static bit f15(bit a, bit b, bit c)
            => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f16(bit a, bit b, bit c)
            => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f17(bit a, bit b, bit c)
            => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f18(bit a, bit b, bit c)
            => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f19(bit a, bit b, bit c)
            => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f1a(bit a, bit b, bit c)
            => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f1b(bit a, bit b, bit c)
            => select(c, not(a), not(b));

        //not ((a and c)) and (a xor b)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f1c(bit a, bit b, bit c)
            => and(not(and(a,c)), xor(a,b));

        //b ? (not a) : (not c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f1d(bit a, bit b, bit c)
            => select(b, not(a), not(c));

        //a xor (b or c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f1e(bit a, bit b, bit c)
            => xor(a, or(b,c));

        // a nand (b or c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f1f(bit a, bit b, bit c)
            => nand(a, or(b,c));

        //((not b) and a) and C
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f20(bit a, bit b, bit c)
            => and(andnot(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f21(bit a, bit b, bit c)
            => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f22(bit a, bit b, bit c)
            => andnot(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f23(bit a, bit b, bit c)
            => and(not(b),or(xor1(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f24(bit a, bit b, bit c)
            => and(xor(a,b), xor(b,c));

        // (not ((a and b)) and (a xor (c xor 1)))
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f25(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(a, xor1(c)));

        //not ((a and b)) and (b xor c)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f26(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(b,c));

        // C ? not (B) : not (A)
        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f27(bit a, bit b, bit c)
            => select(c, not(b),not(c));

        // not(c)
        [MethodImpl(Inline),TernaryOp(X55)]
        public static bit f55(bit a, bit b, bit c)
            => not(c);

        // c
        [MethodImpl(Inline), TernaryOp(XAA)]
        public static bit faa(bit a, bit b, bit c)
            => c;

        public static UnaryOp<bit> unaryop(UnaryLogicOpKind id)
        {
            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return identity;
                default:
                    throw unsupported<Bit>();
            }
        }

        public static BinaryOp<bit> binop(BinaryLogicOpKind id)
        {
            switch(id)
            {
                case BinaryLogicOpKind.And: return and;
                case BinaryLogicOpKind.Nand: return nand;
                case BinaryLogicOpKind.Or: return or;
                case BinaryLogicOpKind.Nor: return nor;
                case BinaryLogicOpKind.XOr: return xor;
                case BinaryLogicOpKind.Xnor: return xnor;
                case BinaryLogicOpKind.AndNot: return andnot;
                default:
                    throw unsupported<Bit>();
            }
        }

        /// <summary>
        /// Advertises the supported operations
        /// </summary>
        public static IEnumerable<TernaryLogicOpKind> ternops
            => range((byte)1,0xf1b).Cast<TernaryLogicOpKind>();

        public static TernaryOp<bit> ternop(TernaryLogicOpKind id)
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
    

        public static BitMatrix<N4,N3,byte> table(BinaryLogicOpKind op)
        {
            var tt = BitMatrix.Alloc<N4,N3,byte>();
            var f = binop(op);
            tt[0] = BitVector.Define<N3,byte>(Bits.pack3(f(Off, Off), Off, Off));
            tt[1] = BitVector.Define<N3,byte>(Bits.pack3(f(On, Off), Off, On));
            tt[2] = BitVector.Define<N3,byte>(Bits.pack3(f(Off, On), On, Off));
            tt[3] = BitVector.Define<N3,byte>(Bits.pack3(f(On, On),  On, On));
            return tt;
        }

        public static BitMatrix<N8,N4, byte> table(TernaryLogicOpKind op)
        {
            var tt = BitMatrix.Alloc<N8,N4,byte>();
            var f = ternop(op);
            tt[0] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, Off, Off), Off, Off, Off));
            tt[1] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, Off, On), Off, Off, On));
            tt[2] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, On, Off), Off, On, Off));
            tt[3] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, On, On), Off, On, On));
            tt[4] = BitVector.Define<N4,byte>(Bits.pack4(f(On, Off, Off), On, Off, Off));
            tt[5] = BitVector.Define<N4,byte>(Bits.pack4(f(On, Off, On), On, Off, On));
            tt[6] = BitVector.Define<N4,byte>(Bits.pack4(f(On, On, Off), Off, On, On));
            tt[7] = BitVector.Define<N4,byte>(Bits.pack4(f(On, On, On), On, On, On));
            return tt;
        }

    }

}
