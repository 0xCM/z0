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
    using static ByteKind;

    public static class BitLogic
    {        
        public static readonly Bit one = Bit.On;

        public static readonly Bit zero = Bit.Off;

        [MethodImpl(Inline)]
        public static Bit identity(Bit a)
            => a;

        [MethodImpl(Inline)]
        public static Bit not(Bit a)
            => ~a;

        [MethodImpl(Inline)]
        public static Bit and(Bit a, Bit b)
            => a & b;


        [MethodImpl(Inline)]
        public static Bit or(Bit a, Bit b)
            => a | b;


        [MethodImpl(Inline)]
        public static Bit xor(Bit a, Bit b)
            => a ^ b;


        [MethodImpl(Inline)]
        public static Bit select(Bit a, Bit b, Bit c)
            => a ? b : c;

        [MethodImpl(Inline)]
        public static Bit nand(Bit a, Bit b)
            => not(and(a,b));

        [MethodImpl(Inline)]
        public static Bit andnot(Bit a, Bit b)
            => and(a, not(b));

        [MethodImpl(Inline)]
        public static Bit nor(Bit a, Bit b)
            => not(or(a,b));

        [MethodImpl(Inline)]
        public static Bit xnor(Bit a, Bit b)
            => not(xor(a,b));

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
        
        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Bit f11(Bit a, Bit b, Bit c)
            => and(a,nor(c,b));
        
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

        // a ? (b or c) : (b and c)
        [MethodImpl(Inline)]
        public static Bit f17(Bit a, Bit b, Bit c)
            => select(a, or(b,c), and(b,c));

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

        public static UnaryOp<Bit> unaryop(OpKind id)
        {
            switch(id)
            {
                case OpKind.Not: return not;
                case OpKind.Identity: return identity;
                default:
                    throw unsupported<Bit>();
            }
        }

        public static BinaryOp<Bit> binop(OpKind id)
        {
            switch(id)
            {
                case OpKind.And: return and;
                case OpKind.Nand: return nand;
                case OpKind.Or: return or;
                case OpKind.Nor: return nor;
                case OpKind.XOr: return xor;
                case OpKind.XNor: return xnor;
                default:
                    throw unsupported<Bit>();
            }
        }

        public static TernaryOp<Bit> ternop(ByteKind id)
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
                default: return select;

            }
        }
 
    }

}
