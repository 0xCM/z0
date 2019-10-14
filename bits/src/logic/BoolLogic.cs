//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;
    using static TernaryLogic;

    public static class BoolLogic
    {        
        public const bool one = true;

        public const bool zero = false;

        const bool off = false;
        
        const bool on = true;


        [MethodImpl(Inline)]
        public static bool and(bool a, bool b)
            => a & b;

        [MethodImpl(Inline)]
        public static bool or(bool a, bool b)
            => a | b;

        [MethodImpl(Inline)]
        public static bool xor(bool a, bool b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static bool xor1(bool a)
            => a ^ on;

        [MethodImpl(Inline)]
        public static bool not(bool a)
            => !a;

        [MethodImpl(Inline)]
        public static bool nand(bool a, bool b)
            => ! (a & b);

        [MethodImpl(Inline)]
        public static bool nor(bool a, bool b)
            => ! (a | b);

        [MethodImpl(Inline)]
        public static bool xnor(bool a, bool b)
            => ! (a ^ b);

        [MethodImpl(Inline)]
        public static bool andnot(bool a, bool b)
            => a & (!b);

        [MethodImpl(Inline)]
        public static bool select(bool a, bool b, bool c)
            => a ? b : c;
        
        // a nor (b or c)
        [MethodImpl(Inline)]
        public static bool f01(bool a, bool b, bool c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static bool f02(bool a, bool b, bool c)
            => and(c, nor(b,a));

        // b nor a
        [MethodImpl(Inline)]
        public static bool f03(bool a, bool b, bool c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static bool f04(bool a, bool b, bool c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static bool f05(bool a, bool b, bool c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static bool f06(bool a, bool b, bool c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static bool f07(bool a, bool b, bool c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static bool f08(bool a, bool b, bool c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static bool f09(bool a, bool b, bool c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static bool f0a(bool a, bool b, bool c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static bool f0b(bool a, bool b, bool c)
            => and(not(a), or(xor1(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static bool f0c(bool a, bool b, bool c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline)]
        public static bool f0d(bool a, bool b, bool c)
            => and(not(a), or(b, xor1(c)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static bool f0e(bool a, bool b, bool c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static bool f0f(bool a, bool b, bool c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static bool f10(bool a, bool b, bool c)
            => and(a, nor(b, c));        
        
        // c nor b
        [MethodImpl(Inline)]
        public static bool f11(bool a, bool b, bool c)
            => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static bool f12(bool a, bool b, bool c)
            => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static bool f13(bool a, bool b, bool c)
            => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static bool f14(bool a, bool b, bool c)
            => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static bool f15(bool a, bool b, bool c)
            => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static bool f16(bool a, bool b, bool c)
            => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static bool f17(bool a, bool b, bool c)
            => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static bool f18(bool a, bool b, bool c)
            => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static bool f19(bool a, bool b, bool c)
            => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static bool f1a(bool a, bool b, bool c)
            => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static bool f1b(bool a, bool b, bool c)
            => select(c, not(a), not(b));

        //not ((a and c)) and (a xor b)
        [MethodImpl(Inline)]
        public static bool f1c(bool a, bool b, bool c)
            => and(not(and(a,c)), xor(a,b));

        //b ? (not a) : (not c)
        [MethodImpl(Inline)]
        public static bool f1d(bool a, bool b, bool c)
            => select(b, not(a), not(c));

        //a xor (b or c)
        [MethodImpl(Inline)]
        public static bool f1e(bool a, bool b, bool c)
            => xor(a, or(b,c));

        // a nand (b or c)
        [MethodImpl(Inline)]
        public static bool f1f(bool a, bool b, bool c)
            => nand(a, or(b,c));

        //((not b) and a) and C
        [MethodImpl(Inline)]
        public static bool f20(bool a, bool b, bool c)
            => and(andnot(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline)]
        public static bool f21(bool a, bool b, bool c)
            => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline)]
        public static bool f22(bool a, bool b, bool c)
            => andnot(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline)]
        public static bool f23(bool a, bool b, bool c)
            => and(not(b),or(xor1(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline)]
        public static bool f24(bool a, bool b, bool c)
            => and(xor(a,b), xor(b,c));

        // (not ((A and B)) and (A xor (C xor 1)))
        [MethodImpl(Inline)]
        public static bool f25(bool a, bool b, bool c)
            => and(not(and(a,b)), xor(a, xor1(c)));

        public static UnaryOp<bool> unaryop(UnaryLogic id)
        {
            switch(id)
            {
                case UnaryLogic.Not: return not;
                case UnaryLogic.Identity: return identity;
                default:
                    throw unsupported<bool>();
            }
        }

        public static BinaryOp<bool> binop(BinaryLogic id)
        {
            switch(id)
            {
                case BinaryLogic.And: return and;
                case BinaryLogic.Nand: return nand;
                case BinaryLogic.Or: return or;
                case BinaryLogic.Nor: return nor;
                case BinaryLogic.XOr: return xor;
                case BinaryLogic.XNor: return xnor;
                default:
                    throw unsupported<bool>();
            }
        }

        public static TernaryOp<bool> ternop(TernaryLogic id)
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

        static byte[] rows(BinaryLogic op)
        {
            var f = binop(op);
            var dst = new byte[8];
            dst[0] = Bits.pack3(f(off, off), off, off);
            dst[1] = Bits.pack3(f(on, off), off, on);
            dst[2] = Bits.pack3(f(off, on), on, off);
            dst[3] = Bits.pack3(f(on, on),  on, on);

            return dst;
        }

        public static BitMatrix<N4,N3,byte> table(BinaryLogic op)
            => BitMatrix.Load<N4,N3,byte>(rows(op));

        static byte[] rows(TernaryLogic op)
        {
            var f = ternop(op);
            var dst = new byte[8];
            dst[0] = Bits.pack4(f(off, off, off), off, off, off);
            dst[1] = Bits.pack4(f(off, off, on), off, off, on);
            dst[2] = Bits.pack4(f(off, on, off), off, on, off);
            dst[3] = Bits.pack4(f(off, on, on), off, on, on);
            dst[4] = Bits.pack4(f(on, off, off), on, off, off);
            dst[5] = Bits.pack4(f(on, off, on), on, off, on);
            dst[6] = Bits.pack4(f(on, on, off), off, on, on);
            dst[7] = Bits.pack4(f(on, on, on), on, on, on);
            return dst;
        }

        public static BitMatrix<N8,N4, byte> table(TernaryLogic op)        
            => BitMatrix.Load<N8,N4,byte>(rows(op));
        


    
    }

}
