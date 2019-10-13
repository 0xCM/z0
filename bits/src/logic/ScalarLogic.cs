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
    using static ByteKind;


    public static class ScalarLogic
    {
        [MethodImpl(Inline)]
        public static T identity<T>(T a)
            where T : unmanaged
                => a;

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : unmanaged
                => gmath.maxval<T>();
        
        [MethodImpl(Inline)]
        public static T and<T>(T a, T b)
            where T : unmanaged
                => gmath.and(a,b);

        [MethodImpl(Inline)]
        public static T nand<T>(T a, T b)
            where T : unmanaged
                => gmath.nand(a,b);

        [MethodImpl(Inline)]
        public static T andnot<T>(T a, T b)
            where T : unmanaged
                => gbits.andnot(a,b);

        [MethodImpl(Inline)]
        public static T or<T>(T a, T b)
            where T : unmanaged
                => gmath.or(a,b);

        [MethodImpl(Inline)]
        public static T nor<T>(T a, T b)
            where T : unmanaged
                => gmath.nor(a,b);

        [MethodImpl(Inline)]
        public static T xor<T>(T a, T b)
            where T : unmanaged
                => gmath.xor(a,b);

        [MethodImpl(Inline)]
        public static T xnor<T>(T a, T b)
            where T : unmanaged
                => gmath.xnor(a,b);

        [MethodImpl(Inline)]
        public static T not<T>(T a)
            where T : unmanaged
                => gmath.flip(a);

        [MethodImpl(Inline)]
        public static T xor1<T>(T a)
            where T : unmanaged
                => gmath.xor1(a); 

        [MethodImpl(Inline)]
        public static T negate<T>(T a)
            where T : unmanaged
                => gmath.negate(a); 

        // a ? b : c
        [MethodImpl(Inline)]
        public static T select_new<T>(T a, T b, T c)
            where T : unmanaged
                => gmath.select(a,b,c);

        [MethodImpl(Inline)]
        public static T select<T>(T a, T b, T c)
            where T : unmanaged
                => or(and(a, b), and(not(a), c));            
        
        // a nor (b or c)
        [MethodImpl(Inline)]
        public static T f01<T>(T a, T b, T c)
            where T : unmanaged
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static T f02<T>(T a, T b, T c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static T f03<T>(T a, T b, T c)
            where T : unmanaged
                => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static T f04<T>(T a, T b, T c)
            where T : unmanaged
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static T f05<T>(T a, T b, T c)
            where T : unmanaged
                => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static T f06<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static T f07<T>(T a, T b, T c)
            where T : unmanaged
                => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static T f08<T>(T a, T b, T c)
            where T : unmanaged
                => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static T f09<T>(T a, T b, T c)
            where T : unmanaged
                => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static T f0a<T>(T a, T b, T c)
            where T : unmanaged
                => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static T f0b<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(a), or(xor1(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static T f0c<T>(T a, T b, T c)
            where T : unmanaged
                => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline)]
        public static T f0d<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(a), or(b, xor1(c)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static T f0e<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static T f0f<T>(T a, T b, T c)
            where T : unmanaged
                => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static T f10<T>(T a, T b, T c)
            where T : unmanaged
                => and(a, nor(b, c));
        
        // a and (b nor c)
        [MethodImpl(Inline)]
        public static T f11<T>(T a, T b, T c)
            where T : unmanaged
                => and(a,nor(c,b));
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static T f12<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static T f13<T>(T a, T b, T c)
            where T : unmanaged
                => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static T f14<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static T f15<T>(T a, T b, T c)
            where T : unmanaged
                => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static T f16<T>(T a, T b, T c)
            where T : unmanaged
                => select(a, nor(b,c), xor(b,c));

        // a ? (b or c) : (b and c)
        [MethodImpl(Inline)]
        public static T f17<T>(T a, T b, T c)
            where T : unmanaged
                => select(a, or(b,c), and(b,c));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static T f18<T>(T a, T b, T c)
            where T : unmanaged
                => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static T f19<T>(T a, T b, T c)
            where T : unmanaged
                => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static T f1a<T>(T a, T b, T c)
            where T : unmanaged
                => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static T f1b<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, not(a), not(b));

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline)]
        public static T f97<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));

        public static UnaryOp<T> unaryop<T>(OpKind id)
            where T : unmanaged            
        {

            switch(id)
            {
                case OpKind.Not: return not;
                case OpKind.Negate: return negate;
                case OpKind.Identity: return identity;
                default:
                    throw unsupported<T>();
            }

        }

        public static BinaryOp<T> binop<T>(OpKind id)
            where T : unmanaged
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
                    throw unsupported<T>();
            }
        }

        public static TernaryOp<T> ternop<T>(ByteKind id)
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