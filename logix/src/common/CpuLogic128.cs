//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static TernaryLogic;
    using static As;

    public static class CpuLogic128
    {

        [MethodImpl(Inline)]
        public static Vec128<T> identity<T>(in Vec128<T> a)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static Vec128<T> zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec128<T> one<T>()
            where T : unmanaged
                => Vec128Pattern.ones<T>();

        [MethodImpl(Inline)]
        public static Vec128<T> not<T>(in Vec128<T> a)
            where T : unmanaged
                => ginx.vnot(a);

        [MethodImpl(Inline)]
        public static Vec128<T> negate<T>(in Vec128<T> a)
            where T : unmanaged
                => ginx.vnegate(a);

        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vand(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> andnot<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vandnot(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> nand<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => not(and(a,b));

        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vor(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> nor<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => not(or(a,b));

        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vxor(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> xnor<T>(in Vec128<T> a, in Vec128<T> b)
            where T : unmanaged
                => ginx.vxnor(a,b);

        [MethodImpl(Inline)]
        public static Vec128<T> xor1<T>(in Vec128<T> a)
            where T : unmanaged
                => ginx.vxor1(a);

        [MethodImpl(Inline)]
        public static Vec128<T> select<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
            => or(and(a, b), andnot(c,a));

        // a nor (b or c)
        [MethodImpl(Inline)]
        public static Vec128<T> f01<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static Vec128<T> f02<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static Vec128<T> f03<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(b,a);

       // b and (a nor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f04<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static Vec128<T> f05<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f06<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f07<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static Vec128<T> f08<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f09<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static Vec128<T> f0a<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static Vec128<T> f0b<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(not(a), or(xor1(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static Vec128<T> f0c<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline)]
        public static Vec128<T> f0d<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(not(a), or(b, xor1(c)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static Vec128<T> f0e<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static Vec128<T> f0f<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f10<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(a, nor(b, c));
        
        // c nor b
        [MethodImpl(Inline)]
        public static Vec128<T> f11<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static Vec128<T> f12<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static Vec128<T> f13<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static Vec128<T> f14<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static Vec128<T> f15<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f16<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static Vec128<T> f17<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f18<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static Vec128<T> f19<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static Vec128<T> f1a<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static Vec128<T> f1b<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => select(c, not(a), not(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline)]
        public static Vec128<T> f97<T>(in Vec128<T> a, in Vec128<T> b, in Vec128<T> c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));

        public static UnaryOpIn<Vec128<T>> unaryop<T>(UnaryLogic id)
            where T : unmanaged            
        {
            switch(id)
            {
                case UnaryLogic.Not: return not;
                case UnaryLogic.Identity: return identity;
                default:
                    throw unsupported<T>();
            }

        }

       public static BinaryOpIn<Vec128<T>> binop<T>(BinaryLogic id)
            where T : unmanaged
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
                    throw unsupported<T>();
            }
        }

        public static TernaryOpIn<Vec128<T>> ternop<T>(TernaryLogic id)
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
                default: return select;

            }
        }

    }

}

