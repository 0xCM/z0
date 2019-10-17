//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIV
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;
    using static TernaryLogicOpKind;

    public static class VectorLogic
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged, IBitVector<T>
                => default;

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : unmanaged, IBitVector<T>
                => gbv.negate(gbv.alloc<T>());

        [MethodImpl(Inline)]
        public static T identity<T>(T a)
            where T : unmanaged, IBitVector<T>
                => a;

        [MethodImpl(Inline)]
        public static T and<T>(T a, T b)
            where T : unmanaged, IBitVector<T>
                => gbv.and(a,b);

        [MethodImpl(Inline)]
        public static T nand<T>(T a, T b)
            where T : unmanaged, IBitVector<T>
                => gbv.nand(a,b);

        [MethodImpl(Inline)]
        public static T andnot<T>(T a, T b)
            where T : unmanaged, IBitVector<T>
                => gbv.andnot(a,b);

        [MethodImpl(Inline)]
        public static V or<V>(V a, V b)
            where V : unmanaged, IBitVector<V>
                => gbv.or(a,b);

        [MethodImpl(Inline)]
        public static T nor<T>(T a, T b)
            where T : unmanaged, IBitVector<T>
                => gbv.nor(a,b);

        [MethodImpl(Inline)]
        public static V xor<V>(V a, V b)
            where V : unmanaged, IBitVector<V>
                => gbv.xor(a,b);

        [MethodImpl(Inline)]
        public static T xnor<T>(T a, T b)
             where T : unmanaged, IBitVector<T>
               => gbv.xnor(a,b);


        [MethodImpl(Inline)]
        public static V not<V>(V a)
            where V : unmanaged, IBitVector<V>
                => gbv.not(a);

        [MethodImpl(Inline)]
        public static V negate<V>(V a)
            where V : unmanaged, IBitVector<V>
                => gbv.negate(a);

        [MethodImpl(Inline)]
        public static T xor1<T>(T a)
            where T : unmanaged, IBitVector<T>
                => gbv.xor1(a); 

        [MethodImpl(Inline)]
        public static V select<V>(V a, V b, V c)
             where V : unmanaged, IBitVector<V>
               => gbv.select(a,b,c);

        // a nor (b or c)
        [MethodImpl(Inline)]
        public static T f01<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline)]
        public static T f02<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline)]
        public static T f03<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline)]
        public static T f04<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline)]
        public static T f05<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static T f06<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline)]
        public static T f07<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline)]
        public static T f08<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline)]
        public static T f09<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline)]
        public static T f0a<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline)]
        public static T f0b<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(not(a), or(xor1(b),  c));   

        // b and (not a)
        [MethodImpl(Inline)]
        public static T f0c<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(b, not(a));

        // not a and (b or (c xor 1))
        [MethodImpl(Inline)]
        public static T f0d<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(not(a), or(b, xor1(c)));

        // not a and (b or c)
        [MethodImpl(Inline)]
        public static T f0e<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline)]
        public static T f0f<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => not(a);

        // a and (b nor c)
        [MethodImpl(Inline)]
        public static T f10<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(a, nor(b, c));
                
        // c nor b
        [MethodImpl(Inline)]
        public static T f11<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(c,b);
        
        // not b and (a xor c) 
        [MethodImpl(Inline)]
        public static T f12<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline)]
        public static T f13<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline)]
        public static T f14<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline)]
        public static T f15<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline)]
        public static T f16<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static T f17<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => not(select(a, or(b,c), and(b,c)));


        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static T f18<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline)]
        public static T f19<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline)]
        public static T f1a<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static T f1b<T>(T a, T b, T c)
            where T : unmanaged, IBitVector<T>
                => select(c, not(a), not(b));

        public static UnaryOp<T> unaryop<T>(UnaryLogicOpKind id)
            where T : unmanaged, IBitVector<T>
        {

            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return identity;
                default:
                    throw unsupported<T>();
            }

        }

        public static BinaryOp<T> binop<T>(BinaryLogicOpKind id)
            where T : unmanaged, IBitVector<T>
        {
            switch(id)
            {
                case BinaryLogicOpKind.And: return and;
                case BinaryLogicOpKind.Nand: return nand;
                case BinaryLogicOpKind.Or: return or;
                case BinaryLogicOpKind.Nor: return nor;
                case BinaryLogicOpKind.XOr: return xor;
                case BinaryLogicOpKind.Xnor: return xnor;
                default:
                    throw unsupported<T>();
            }
        }

        public static TernaryOp<T> ternop<T>(TernaryLogicOpKind id)
            where T : unmanaged, IBitVector<T>
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