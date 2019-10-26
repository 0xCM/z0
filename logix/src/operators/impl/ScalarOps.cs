//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    using static TernaryBitOpKind;


    public static class ScalarOps
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
        public static T add<T>(T a, T b)
            where T : unmanaged
                => gmath.add(a,b);

        [MethodImpl(Inline)]
        public static T sub<T>(T a, T b)
            where T : unmanaged
                => gmath.sub(a,b);

        [MethodImpl(Inline)]
        public static T div<T>(T a, T b)
            where T : unmanaged
                => gmath.div(a,b);

        [MethodImpl(Inline)]
        public static T mod<T>(T a, T b)
            where T : unmanaged
                => gmath.mod(a,b);

        [MethodImpl(Inline)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => gmath.eq(a,b);

        [MethodImpl(Inline)]
        public static bit lt<T>(T a, T b)
            where T : unmanaged
                => gmath.lt(a,b);

        [MethodImpl(Inline)]
        public static bit lteq<T>(T a, T b)
            where T : unmanaged
                => gmath.lteq(a,b);

        [MethodImpl(Inline)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
                => gmath.gt(a,b);

        [MethodImpl(Inline)]
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
                => gmath.gteq(a,b);

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
                => gmath.andnot(a,b);

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
        public static T left<T>(T a, T b)
            where T : unmanaged
            => a;

        [MethodImpl(Inline)]
        public static T right<T>(T a, T b)
            where T : unmanaged
            => b;

        [MethodImpl(Inline)]
        public static T rightnot<T>(T a, T b)
            where T : unmanaged
                => not(b);

        [MethodImpl(Inline)]
        public static T leftnot<T>(T a, T b)
            where T : unmanaged
                => not(a);

        [MethodImpl(Inline)]
        public static T implies<T>(T antecedent, T consequent)
            where T : unmanaged
                => not(andnot(antecedent, consequent));


        [MethodImpl(Inline)]
        public static T not<T>(T a)
            where T : unmanaged
                => gmath.not(a);

        [MethodImpl(Inline)]
        public static T xor1<T>(T a)
            where T : unmanaged
                => gmath.xor1(a); 

        [MethodImpl(Inline)]
        public static T sll<T>(T a, int offset)
            where T : unmanaged
                => gmath.sll(a,offset);

        [MethodImpl(Inline)]
        public static T srl<T>(T a, int offset)
            where T : unmanaged
                => gmath.srl(a,offset);

        [MethodImpl(Inline)]
        public static T rotl<T>(T a, int offset)
            where T : unmanaged
                => gbits.rotl(a,offset);

        [MethodImpl(Inline)]
        public static T rotr<T>(T a, int offset)
            where T : unmanaged
                => gbits.rotr(a,offset);

        [MethodImpl(Inline)]
        public static T negate<T>(T a)
            where T : unmanaged
                => gmath.negate(a); 

        [MethodImpl(Inline)]
        public static T inc<T>(T a)
            where T : unmanaged
                => gmath.inc(a); 

        [MethodImpl(Inline)]
        public static T dec<T>(T a)
            where T : unmanaged
                => gmath.dec(a); 

        [MethodImpl(Inline)]
        public static T @false<T>(T a)
            where T:unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T @false<T>(T a, T b)
            where T:unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T @false<T>(T a, T b, T c)
            where T:unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T @true<T>(T a)
            where T:unmanaged
                => gmath.maxval<T>();         

        [MethodImpl(Inline)]
        public static T @true<T>(T a, T b)
            where T:unmanaged
                => gmath.maxval<T>();

        [MethodImpl(Inline)]
        public static T @true<T>(T a, T b, T c)
            where T:unmanaged
                => gmath.maxval<T>();

        [MethodImpl(Inline)]
        public static T select<T>(T a, T b, T c)
            where T : unmanaged
                => gmath.select(a,b,c);

        [MethodImpl(Inline),TernaryOp(X00)]
        public static T f00<T>(T a, T b, T c)
            where T : unmanaged
            => default;

        // a nor (b or c)
        [MethodImpl(Inline),TernaryOp(X01)]
        public static T f01<T>(T a, T b, T c)
            where T : unmanaged
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline),TernaryOp(X02)]
        public static T f02<T>(T a, T b, T c)
            where T : unmanaged
                => and(c, nor(b,a));
 
         // b nor a
        [MethodImpl(Inline),TernaryOp(X03)]
        public static T f03<T>(T a, T b, T c)
            where T : unmanaged
                => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline),TernaryOp(X04)]
        public static T f04<T>(T a, T b, T c)
            where T : unmanaged
                => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline),TernaryOp(X05)]
        public static T f05<T>(T a, T b, T c)
            where T : unmanaged
                => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline),TernaryOp(X06)]
        public static T f06<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline),TernaryOp(X07)]
        public static T f07<T>(T a, T b, T c)
            where T : unmanaged
                => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline),TernaryOp(X08)]
        public static T f08<T>(T a, T b, T c)
            where T : unmanaged
                => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline),TernaryOp(X09)]
        public static T f09<T>(T a, T b, T c)
            where T : unmanaged
                => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline),TernaryOp(X0A)]
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
                => and(and(not(b),a),c);

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

        // C and (B nand A)
        [MethodImpl(Inline)]
        public static T f2a<T>(T a, T b, T c)
            where T : unmanaged
                => and(c,nand(b,a));

        // C ? (B nand A) : (B nor A)
        [MethodImpl(Inline)]
        public static T f2b<T>(T a, T b, T c)
            where T : unmanaged
                => select(c,nand(b,a), nor(b,a));

        // (B or C) and (A xor B)
        [MethodImpl(Inline)]
        public static T f2c<T>(T a, T b, T c)
            where T : unmanaged
                => and(or(b,c), xor(a,b));

        // A xor (B or not (C))
        [MethodImpl(Inline)]
        public static T f2d<T>(T a, T b, T c)
            where T : unmanaged
                => xor(a, or(b, not(c)));

        // (B or C) xor (A and B)
        [MethodImpl(Inline)]
        public static T f2e<T>(T a, T b, T c)
            where T : unmanaged
                => xor(or(b,c),and(a,b));

        // not (A) or (not (B) and C)
        [MethodImpl(Inline)]
        public static T f2f<T>(T a, T b, T c)
            where T : unmanaged
                => or(not(a),(and(not(b),c)));

        // a and not(b)
        [MethodImpl(Inline),TernaryOp(X30)]
        public static T f30<T>(T a, T b, T c)
            where T : unmanaged
                => andnot(a,b);

        // not (B) and (A or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X31)]
        public static T f31<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(b), or(a,xor1(c)));

        //not (B) and (A or C)
        [MethodImpl(Inline),TernaryOp(X32)]
        public static T f32<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(b),or(a,c));

        // not (B)
        [MethodImpl(Inline),TernaryOp(X33)]
        public static T f33<T>(T a, T b, T c)
            where T : unmanaged
                => not(b);

        // not ((B and C)) and (A xor B)
        [MethodImpl(Inline),TernaryOp(X34)]
        public static T f34<T>(T a, T b, T c)
            where T : unmanaged
            => and(not(and(b,c)), xor(a,b));

        // A ? not (B) : not (C)
        [MethodImpl(Inline),TernaryOp(X35)]
        public static T f35<T>(T a, T b, T c)
            where T : unmanaged
            => select(a,not(b),not(c));

        // B xor (A or C)
        [MethodImpl(Inline),TernaryOp(X36)]
        public static T f36<T>(T a, T b, T c)
            where T : unmanaged
            => xor(b,or(a,c));

        // B nand (A or C)
        [MethodImpl(Inline),TernaryOp(X37)]
        public static T f37<T>(T a, T b, T c)
            where T : unmanaged
            => nand(b,or(a,c));

        // (A or C) and (A xor B)
        [MethodImpl(Inline),TernaryOp(X38)]
        public static T f38<T>(T a, T b, T c)
            where T : unmanaged
            => and(or(a,c), xor(a,b));

        // B xor (A or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X39)]
        public static T f39<T>(T a, T b, T c)
            where T : unmanaged
                => xor(b, or(a,xor1(c)));

        // A ? not (B) : C
        [MethodImpl(Inline),TernaryOp(X3A)]
        public static T f3a<T>(T a, T b, T c)
            where T : unmanaged
            => select(a, not(b), c);

        // (not (A) and C) or (B xor 1)
        [MethodImpl(Inline),TernaryOp(X3B)]
        public static T f3b<T>(T a, T b, T c)
            where T : unmanaged
            => or(and(not(a),c),xor1(b));

        // B xor A
        [MethodImpl(Inline),TernaryOp(X3C)]
        public static T f3c<T>(T a, T b, T c)
            where T : unmanaged
                => xor(b,a);

        // ((A xor B) or (A nor C))
        [MethodImpl(Inline),TernaryOp(X3D)]
        public static T f3d<T>(T a, T b, T c)
            where T : unmanaged
            => or(xor(b,a),nor(a,c));

        // (not (A) and C) or (A xor B)
        [MethodImpl(Inline),TernaryOp(X3E)]
        public static T f3e<T>(T a, T b, T c)
            where T : unmanaged
                => or(and(not(a),c),xor(a,b));

        // B nand A
        [MethodImpl(Inline),TernaryOp(X3F)]
        public static T f3f<T>(T a, T b, T c)
            where T : unmanaged
            => nand(b,a);

        // (not (C) and A) and B
        [MethodImpl(Inline),TernaryOp(X40)]
        public static T f40<T>(T a, T b, T c)
            where T : unmanaged
                => and(and(not(c),a),b);

        // C nor (B xor A)
        [MethodImpl(Inline),TernaryOp(X41)]
        public static T f41<T>(T a, T b, T c)
            where T : unmanaged
            => nor(c,xor(b,a));

        // (A xor C) and (B xor C)
        [MethodImpl(Inline),TernaryOp(X42)]
        public static T f42<T>(T a, T b, T c)
            where T : unmanaged
                => and(xor(a,c),xor(b,c));

        // not ((A and C)) and (A xor (B xor 1))
        [MethodImpl(Inline),TernaryOp(X43)]
        public static T f43<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(and(a,c)), xor(a,xor1(b)));

        // B and not (C)
        [MethodImpl(Inline),TernaryOp(X44)]
        public static T f44<T>(T a, T b, T c)
            where T : unmanaged
                => andnot(b,c);

        // not (C) and ((A xor 1) or B)
        [MethodImpl(Inline),TernaryOp(X45)]
        public static T f45<T>(T a, T b, T c)
            where T : unmanaged
            => and(not(c), or(xor1(a), b));

        // not ((A and C)) and (B xor C)
        [MethodImpl(Inline),TernaryOp(X46)]
        public static T f46<T>(T a, T b, T c)
            where T : unmanaged
            => and(not(and(a,c)),xor(b,c));

        // B ? not (C) : not (A)
        [MethodImpl(Inline),TernaryOp(X47)]
        public static T f47<T>(T a, T b, T c)
            where T : unmanaged
            => select(b,not(c),not(a));

        // B and (A xor C)
        [MethodImpl(Inline),TernaryOp(X48)]
        public static T f48<T>(T a, T b, T c)
            where T : unmanaged
            => and(b,xor(a,c));

        // B ? (A xor C) : (A nor C)
        [MethodImpl(Inline),TernaryOp(X49)]
        public static T f49<T>(T a, T b, T c)
            where T : unmanaged
            => select(b,xor(a,c),nor(a,c));

        // (B or C) and (A xor C)
        [MethodImpl(Inline),TernaryOp(X4A)]
        public static T f4a<T>(T a, T b, T c)
            where T : unmanaged
                => and(or(b,c), xor(a,c));

         // A xor (not (B) or C)
        [MethodImpl(Inline),TernaryOp(X4B)]
        public static T f4b<T>(T a, T b, T c)
            where T : unmanaged
                => xor(a, or(not(b), c));

        // B and (A nand C)
        [MethodImpl(Inline),TernaryOp(X4C)]
        public static T f4c<T>(T a, T b, T c)
            where T : unmanaged
                => and(b, nand(a,c));

        // B ? (A nand C) : (A nor C)
        [MethodImpl(Inline),TernaryOp(X4D)]
        public static T f4d<T>(T a, T b, T c)
            where T : unmanaged
                => select(b, nand(a,c),nor(a,c));

        // C ? not (A) : B
        [MethodImpl(Inline),TernaryOp(X4E)]
        public static T f4e<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, not(a), b);

        // not (A) or (B and not (C))
        [MethodImpl(Inline),TernaryOp(X4F)]
        public static T f4f<T>(T a, T b, T c)
            where T : unmanaged
                => or(not(a),andnot(b,c));

        // A and not (C)
        [MethodImpl(Inline),TernaryOp(X50)]
        public static T f50<T>(T a, T b, T c)
            where T : unmanaged
                => andnot(a,c);

        // not (C) and (A or (B xor 1))
        [MethodImpl(Inline),TernaryOp(X51)]
        public static T f51<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(c),or(a,xor1(b)));

        // not ((B and C)) and (A xor C)
        [MethodImpl(Inline),TernaryOp(X52)]
        public static T f52<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(and(b,c)),xor(a,c));

        // A ? not (C) : not (B)
        [MethodImpl(Inline),TernaryOp(X53)]
        public static T f53<T>(T a, T b, T c)
            where T : unmanaged
                => select(a, not(c), not(b));

        // not (C) and (A or B)
        [MethodImpl(Inline),TernaryOp(X54)]
        public static T f54<T>(T a, T b, T c)
            where T : unmanaged
                => and(not(c), or(a,b));

        // not (C)
        [MethodImpl(Inline),TernaryOp(X55)]
        public static T f55<T>(T a, T b, T c)
            where T : unmanaged
                => not(c);

        // C xor (B or A)
        [MethodImpl(Inline),TernaryOp(X56)]
        public static T f56<T>(T a, T b, T c)
            where T : unmanaged
                => xor(c,or(b,a));

        // C nand (B or A)
        [MethodImpl(Inline),TernaryOp(X57)]
        public static T f57<T>(T a, T b, T c)
            where T : unmanaged
                => nand(c,or(b,a));

        // (A or B) and (A xor C)
        [MethodImpl(Inline),TernaryOp(X58)]
        public static T f58<T>(T a, T b, T c)
            where T : unmanaged
                => and(or(a,b),xor(a,c));

        // C xor (A or (B xor 1))
        [MethodImpl(Inline),TernaryOp(X59)]
        public static T f59<T>(T a, T b, T c)
            where T : unmanaged
                => xor(c, or(a,xor1(b)));

        // C xor A
        [MethodImpl(Inline),TernaryOp(X5A)]
        public static T f5a<T>(T a, T b, T c)
            where T : unmanaged
                => xor(c,a);


        // a ? (b xnor c) : (b nand c)
        [MethodImpl(Inline)]
        public static T f97<T>(T a, T b, T c)
            where T : unmanaged
                => select(c, xnor(b,c), nand(b,c));
  
    }    

}