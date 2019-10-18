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
    using static TernaryLogicOpKind;


    public static class ScalarLogic
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T identity<T>(T a)
            where T : unmanaged
                => a;

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
                => gmath.not(a);

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
        
        // c nor b
        [MethodImpl(Inline)]
        public static T f11<T>(T a, T b, T c)
            where T : unmanaged
                => nor(c,b);
        
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

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline)]
        public static T f17<T>(T a, T b, T c)
            where T : unmanaged
                => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline)]
        public static T f18<T>(T a, T b, T c)
            where T : unmanaged
                => and(xor(a,b), xor(a,c));

        // not((b xor c) xor (a and (b and c)))
        [MethodImpl(Inline)]
        public static T f19<T>(T a, T b, T c)
            where T : unmanaged
                => not(xor(xor(b,c), and(a, and(b,c))));

        // not ((A and B)) and (A xor C)
        [MethodImpl(Inline)]
        public static T f1a<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(and(a,b)), xor(a,c));

        // c ? not a : not b
        [MethodImpl(Inline)]
        public static T f1b<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, not(a), not(b));

        //not ((a and c)) and (a xor b)
        [MethodImpl(Inline)]
        public static T f1c<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(and(a,c)), xor(a,b));

        //b ? (not a) : (not c)
        [MethodImpl(Inline)]
        public static T f1d<T>(T a, T b, T c)
            where T : unmanaged
                => select(b, not(a), not(c));

        //a xor (b or c)
        [MethodImpl(Inline)]
        public static T f1e<T>(T a, T b, T c)
            where T : unmanaged
                => xor(a, or(b,c));

        // a nand (b or c)
        [MethodImpl(Inline)]
        public static T f1f<T>(T a, T b, T c)
            where T : unmanaged
                => nand(a, or(b,c));

        //((not b) and a) and C
        [MethodImpl(Inline)]
        public static T f20<T>(T a, T b, T c)
            where T : unmanaged
                => and(andnot(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline)]
        public static T f21<T>(T a, T b, T c)
            where T : unmanaged
                => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline)]
        public static T f22<T>(T a, T b, T c)
            where T : unmanaged
                => andnot(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline)]
        public static T f23<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(b),or(xor1(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline)]
        public static T f24<T>(T a, T b, T c)
            where T : unmanaged
                => and(xor(a,b), xor(b,c));

        // (not ((A and B)) and (A xor (C xor 1)))
        [MethodImpl(Inline)]
        public static T f25<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(and(a,b)), xor(a, xor1(c)));

        // not ((A and B)) and (B xor C)
        [MethodImpl(Inline)]
        public static T f26<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(and(a,b)),xor(b,c));

        //C ? not (B) : not (A)
        [MethodImpl(Inline)]
        public static T f27<T>(T a, T b, T c)
            where T : unmanaged
                => select(c,not(b),not(a));

        //C and (B xor A)
        [MethodImpl(Inline)]
        public static T f28<T>(T a, T b, T c)
            where T : unmanaged
                => and(c,xor(b,a));

        // C ? (B xor A) : (B nor A)
        [MethodImpl(Inline)]
        public static T f29<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, xor(b,a),nor(b,a));

        [MethodImpl(Inline)]
        public static T f2A<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f2B<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f2C<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f2D<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f2E<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f2F<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f30<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f31<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f33<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f34<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f35<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f36<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f37<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f38<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f39<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f3A<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f3B<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f3C<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f3D<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f3E<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f3F<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f40<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f41<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f43<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f44<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f45<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f46<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f47<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f48<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f49<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f4A<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f4B<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f4C<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f4D<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f4E<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T f4F<T>(T a, T b, T c)
            where T : unmanaged
                => default;

        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline)]
        public static T f97<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));
  
    }    

}