//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitLogix
    {
        [MethodImpl(Inline), Op]
        public static Bit32 select(Bit32 a, Bit32 b, Bit32 c)
            => Bit32.select(a,b,c);

        [MethodImpl(Inline), Op]
        public static Bit32 @false(Bit32 a, Bit32 b, Bit32 c)
            => Bit32.Off;

        [MethodImpl(Inline), Op]
        public static Bit32 @true(Bit32 a, Bit32 b, Bit32 c)
            => Bit32.On;

        // a nor (b or c)
        [MethodImpl(Inline), Op]
        public static Bit32 f01(Bit32 a, Bit32 b, Bit32 c)
            => nor(a, or(b,c));

        // c and (b nor a)
        [MethodImpl(Inline), Op]
        public static Bit32 f02(Bit32 a, Bit32 b, Bit32 c)
            => and(c, nor(b,a));

        // b nor a
        [MethodImpl(Inline), Op]
        public static Bit32 f03(Bit32 a, Bit32 b, Bit32 c)
            => nor(b,a);

        // b and (a nor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f04(Bit32 a, Bit32 b, Bit32 c)
            => and(b, nor(a,c));

        // c nor a
        [MethodImpl(Inline), Op]
        public static Bit32 f05(Bit32 a, Bit32 b, Bit32 c)
            => nor(c,a);

        // not a and (b xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f06(Bit32 a, Bit32 b, Bit32 c)
            => and(not(a), xor(b,c));

        // not a and (b xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f07(Bit32 a, Bit32 b, Bit32 c)
            => nor(a, and(b,c));

        // (not a and b) and c
        [MethodImpl(Inline), Op]
        public static Bit32 f08(Bit32 a, Bit32 b, Bit32 c)
            => and(and(not(a),b), c);

        // a nor (b xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f09(Bit32 a, Bit32 b, Bit32 c)
            => nor(a, xor(b,c));

        // c and (not a)
        [MethodImpl(Inline), Op]
        public static Bit32 f0a(Bit32 a, Bit32 b, Bit32 c)
            => and(c, not(a));

        // not a and ((b xor 1) or c)
        [MethodImpl(Inline), Op]
        public static Bit32 f0b(Bit32 a, Bit32 b, Bit32 c)
            => and(not(a), or(not(b),  c));

        // b and (not a)
        [MethodImpl(Inline), Op]
        public static Bit32 f0c(Bit32 a, Bit32 b, Bit32 c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f0d(Bit32 a, Bit32 b, Bit32 c)
            => and(not(a), or(b, not(c)));

        // not a and (b or c)
        [MethodImpl(Inline), Op]
        public static Bit32 f0e(Bit32 a, Bit32 b, Bit32 c)
            => and(not(a),or(b,c));

        // not a
        [MethodImpl(Inline), Op]
        public static Bit32 f0f(Bit32 a, Bit32 b, Bit32 c)
            => not(a);

        // a and (b nor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f10(Bit32 a, Bit32 b, Bit32 c)
            => and(a, nor(b, c));

        // c nor b
        [MethodImpl(Inline), Op]
        public static Bit32 f11(Bit32 a, Bit32 b, Bit32 c)
            => nor(c,b);

        // not b and (a xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f12(Bit32 a, Bit32 b, Bit32 c)
            => and(not(b), xor(a,c));

        // b nor (a and c)
        [MethodImpl(Inline), Op]
        public static Bit32 f13(Bit32 a, Bit32 b, Bit32 c)
            => nor(b, and(a,c));

        // not c and (a xor b)
        [MethodImpl(Inline), Op]
        public static Bit32 f14(Bit32 a, Bit32 b, Bit32 c)
            => and(not(c), xor(a,b));

        // c nor (b and a)
        [MethodImpl(Inline), Op]
        public static Bit32 f15(Bit32 a, Bit32 b, Bit32 c)
            => nor(c, and(a,b));

        // a ? (b nor c) : (b xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f16(Bit32 a, Bit32 b, Bit32 c)
            => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline), Op]
        public static Bit32 f17(Bit32 a, Bit32 b, Bit32 c)
            => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f18(Bit32 a, Bit32 b, Bit32 c)
            => and(xor(a,b), xor(a,c));

        // not(((B xor C) xor (A and (B and C))))
        [MethodImpl(Inline), Op]
        public static Bit32 f19(Bit32 a, Bit32 b, Bit32 c)
            => not(xor(xor(b,c), and(a, and(b,c))));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f1a(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(a,b)), xor(a,c));

        // c ? not a : not b
        [MethodImpl(Inline), Op]
        public static Bit32 f1b(Bit32 a, Bit32 b, Bit32 c)
            => select(c, not(a), not(b));

        //not ((a and c)) and (a xor b)
        [MethodImpl(Inline), Op]
        public static Bit32 f1c(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(a,c)), xor(a,b));

        //b ? (not a) : (not c)
        [MethodImpl(Inline), Op]
        public static Bit32 f1d(Bit32 a, Bit32 b, Bit32 c)
            => select(b, not(a), not(c));

        //a xor (b or c)
        [MethodImpl(Inline), Op]
        public static Bit32 f1e(Bit32 a, Bit32 b, Bit32 c)
            => xor(a, or(b,c));

        // a nand (b or c)
        [MethodImpl(Inline), Op]
        public static Bit32 f1f(Bit32 a, Bit32 b, Bit32 c)
            => nand(a, or(b,c));

        //((not b) and a) and C
        [MethodImpl(Inline), Op]
        public static Bit32 f20(Bit32 a, Bit32 b, Bit32 c)
            => and(cnonimpl(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f21(Bit32 a, Bit32 b, Bit32 c)
            => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline), Op]
        public static Bit32 f22(Bit32 a, Bit32 b, Bit32 c)
            => cnonimpl(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline), Op]
        public static Bit32 f23(Bit32 a, Bit32 b, Bit32 c)
            => and(not(b),or(not(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f24(Bit32 a, Bit32 b, Bit32 c)
            => and(xor(a,b), xor(b,c));

        // (not ((a and b)) and (a xor (c xor 1)))
        [MethodImpl(Inline), Op]
        public static Bit32 f25(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(a,b)), xor(a, not(c)));

        //not ((a and b)) and (b xor c)
        [MethodImpl(Inline), Op]
        public static Bit32 f26(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(a,b)), xor(b,c));

        // C ? not (B) : not (A)
        [MethodImpl(Inline), Op]
        public static Bit32 f27(Bit32 a, Bit32 b, Bit32 c)
            => select(c, not(b), not(a));

        // C and (B xor A)
        [MethodImpl(Inline), Op]
        public static Bit32 f28(Bit32 a, Bit32 b, Bit32 c)
            => and(c, xor(b,a));

        // C ? (B xor A) : (B nor A)
        [MethodImpl(Inline), Op]
        public static Bit32 f29(Bit32 a, Bit32 b, Bit32 c)
            => select(c, xor(b,a), nor(b,a));

        // C and (B nand A)
        [MethodImpl(Inline), Op]
        public static Bit32 f2a(Bit32 a, Bit32 b, Bit32 c)
            => and(c, nand(b,a));

        // C ? (B nand A) : (B nor A)
        [MethodImpl(Inline), Op]
        public static Bit32 f2b(Bit32 a, Bit32 b, Bit32 c)
            => select(c, nand(b,a), nor(b,a));

        // (B or C) and (A xor B)
        [MethodImpl(Inline), Op]
        public static Bit32 f2c(Bit32 a, Bit32 b, Bit32 c)
            => and(or(b,c), xor(a,b));

        // A xor (B or not (C))
        [MethodImpl(Inline), Op]
        public static Bit32 f2d(Bit32 a, Bit32 b, Bit32 c)
            => xor(a,(or(b,not(c))));

        // (B or C) xor (A and B)
        [MethodImpl(Inline), Op]
        public static Bit32 f2e(Bit32 a, Bit32 b, Bit32 c)
            => xor(or(b,c), and(a,b));

        // not (A) or (not (B) and C)
        [MethodImpl(Inline), Op]
        public static Bit32 f2f(Bit32 a, Bit32 b, Bit32 c)
            => or(not(a), and(not(b),c));

        // a and not(b)
        [MethodImpl(Inline), Op]
        public static Bit32 f30(Bit32 a, Bit32 b, Bit32 c)
            => cnonimpl(a,b);

        // not (B) and (A or (C xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f31(Bit32 a, Bit32 b, Bit32 c)
            => and(not(b), or(a,not(c)));

        //not (B) and (A or C)
        [MethodImpl(Inline), Op]
        public static Bit32 f32(Bit32 a, Bit32 b, Bit32 c)
            => and(not(b),or(a,c));

        // not (B)
        [MethodImpl(Inline), Op]
        public static Bit32 f33(Bit32 a, Bit32 b, Bit32 c)
            => not(b);

        // not ((B and C)) and (A xor B)
        [MethodImpl(Inline), Op]
        public static Bit32 f34(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(b,c)), xor(a,b));

        // A ? not (B) : not (C)
        [MethodImpl(Inline), Op]
        public static Bit32 f35(Bit32 a, Bit32 b, Bit32 c)
            => select(a,not(b),not(c));

        // B xor (A or C)
        [MethodImpl(Inline), Op]
        public static Bit32 f36(Bit32 a, Bit32 b, Bit32 c)
            => xor(b,or(a,c));

        // B nand (A or C)
        [MethodImpl(Inline), Op]
        public static Bit32 f37(Bit32 a, Bit32 b, Bit32 c)
            => nand(b,or(a,c));

        // (A or C) and (A xor B)
        [MethodImpl(Inline), Op]
        public static Bit32 f38(Bit32 a, Bit32 b, Bit32 c)
            => and(or(a,c), xor(a,b));

        // B xor (A or (C xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f39(Bit32 a, Bit32 b, Bit32 c)
            => xor(b, or(a, not(c)));

        // A ? not (B) : C
        [MethodImpl(Inline), Op]
        public static Bit32 f3a(Bit32 a, Bit32 b, Bit32 c)
            => select(a, not(b), c);

        // (not (A) and C) or (B xor 1)
        [MethodImpl(Inline), Op]
        public static Bit32 f3b(Bit32 a, Bit32 b, Bit32 c)
            => or(and(not(a),c),not(b));

        // B xor A
        [MethodImpl(Inline), Op]
        public static Bit32 f3c(Bit32 a, Bit32 b, Bit32 c)
            => xor(b,a);

        // ((A xor B) or (A nor C))
        [MethodImpl(Inline), Op]
        public static Bit32 f3d(Bit32 a, Bit32 b, Bit32 c)
            => or(xor(b,a),nor(a,c));

        // (not (A) and C) or (A xor B)
        [MethodImpl(Inline), Op]
        public static Bit32 f3e(Bit32 a, Bit32 b, Bit32 c)
            => or(and(not(a),c),xor(a,b));

        // B nand A
        [MethodImpl(Inline), Op]
        public static Bit32 f3f(Bit32 a, Bit32 b, Bit32 c)
            => nand(b,a);

        // (not (C) and A) and B
        [MethodImpl(Inline), Op]
        public static Bit32 f40(Bit32 a, Bit32 b, Bit32 c)
            => and(and(not(c),a),b);

        // C nor (B xor A)
        [MethodImpl(Inline), Op]
        public static Bit32 f41(Bit32 a, Bit32 b, Bit32 c)
            => nor(c,xor(b,a));

        // (A xor C) and (B xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f42(Bit32 a, Bit32 b, Bit32 c)
            => and(xor(a,c),xor(b,c));

        // not ((A and C)) and (A xor (B xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f43(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(a,c)), xor(a,not(b)));

        // B and not (C)
        [MethodImpl(Inline), Op]
        public static Bit32 f44(Bit32 a, Bit32 b, Bit32 c)
            => cnonimpl(b,c);

        // not (C) and ((A xor 1) or B)
        [MethodImpl(Inline), Op]
        public static Bit32 f45(Bit32 a, Bit32 b, Bit32 c)
            => and(not(c), or(not(a), b));

        // not ((A and C)) and (B xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f46(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(a,c)),xor(b,c));

        // B ? not (C) : not (A)
        [MethodImpl(Inline), Op]
        public static Bit32 f47(Bit32 a, Bit32 b, Bit32 c)
            => select(b,not(c),not(a));

        // B and (A xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f48(Bit32 a, Bit32 b, Bit32 c)
            => and(b,xor(a,c));

        // B ? (A xor C) : (A nor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f49(Bit32 a, Bit32 b, Bit32 c)
            => select(b,xor(a,c),nor(a,c));

        // (B or C) and (A xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f4a(Bit32 a, Bit32 b, Bit32 c)
            => and(or(b,c), xor(a,c));

         // A xor (not (B) or C)
        [MethodImpl(Inline), Op]
        public static Bit32 f4b(Bit32 a, Bit32 b, Bit32 c)
            => xor(a, or(not(b), c));

        // B and (A nand C)
        [MethodImpl(Inline), Op]
        public static Bit32 f4c(Bit32 a, Bit32 b, Bit32 c)
            => and(b, nand(a,c));

        // B ? (A nand C) : (A nor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f4d(Bit32 a, Bit32 b, Bit32 c)
            => select(b, nand(a,c),nor(a,c));

        // C ? not (A) : B
        [MethodImpl(Inline), Op]
        public static Bit32 f4e(Bit32 a, Bit32 b, Bit32 c)
            => select(c, not(a), b);

        // not (A) or (B and not (C))
        [MethodImpl(Inline), Op]
        public static Bit32 f4f(Bit32 a, Bit32 b, Bit32 c)
            => or(not(a),cnonimpl(b,c));

        // A and not (C)
        [MethodImpl(Inline), Op]
        public static Bit32 f50(Bit32 a, Bit32 b, Bit32 c)
            => cnonimpl(a,c);

        // not (C) and (A or (B xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f51(Bit32 a, Bit32 b, Bit32 c)
            => and(not(c),or(a,not(b)));

        // not ((B and C)) and (A xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f52(Bit32 a, Bit32 b, Bit32 c)
            => and(not(and(b,c)),xor(a,c));

        // A ? not (C) : not (B)
        [MethodImpl(Inline), Op]
        public static Bit32 f53(Bit32 a, Bit32 b, Bit32 c)
            => select(a, not(c), not(b));

        // not (C) and (A or B)
        [MethodImpl(Inline), Op]
        public static Bit32 f54(Bit32 a, Bit32 b, Bit32 c)
            => and(not(c), or(a,b));

        // not (C)
        [MethodImpl(Inline), Op]
        public static Bit32 f55(Bit32 a, Bit32 b, Bit32 c)
            => not(c);

        // C xor (B or A)
        [MethodImpl(Inline), Op]
        public static Bit32 f56(Bit32 a, Bit32 b, Bit32 c)
            => xor(c,or(b,a));

        // C nand (B or A)
        [MethodImpl(Inline), Op]
        public static Bit32 f57(Bit32 a, Bit32 b, Bit32 c)
            => nand(c,or(b,a));

        // (A or B) and (A xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f58(Bit32 a, Bit32 b, Bit32 c)
            => and(or(a,b),xor(a,c));

        // C xor (A or (B xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f59(Bit32 a, Bit32 b, Bit32 c)
            => xor(c, or(a, not(b)));

        // C xor A
        [MethodImpl(Inline), Op]
        public static Bit32 f5a(Bit32 a, Bit32 b, Bit32 c)
            => xor(c,a);

        //((A xor C) or ((A or B) xor 1))
        [MethodImpl(Inline), Op]
        public static Bit32 f5b(Bit32 a, Bit32 b, Bit32 c)
            => or(xor(a,c), xor(or(a,b),Bit32.On));

        //(A ? not (C) : B)
        [MethodImpl(Inline), Op]
        public static Bit32 f5c(Bit32 a, Bit32 b, Bit32 c)
            => select(a,not(c), b);

        // not (C) or (not (A) and B)
        [MethodImpl(Inline), Op]
        public static Bit32 f5d(Bit32 a, Bit32 b, Bit32 c)
            => or(not(c), and(not(a), b));

        // (not (C) and B) or (A xor C)
        [MethodImpl(Inline), Op]
        public static Bit32 f5e(Bit32 a, Bit32 b, Bit32 c)
            => or(and(not(c),b),(xor(a,c)));

        [MethodImpl(Inline), Op]
        public static Bit32 f5f(Bit32 a, Bit32 b, Bit32 c)
            => nand(c,a);

        [MethodImpl(Inline)]
        public static Bit32 f60(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f61(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f62(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f63(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f64(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f65(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f66(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f67(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f68(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f69(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f6a(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f6b(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f6c(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f6d(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f6e(Bit32 a, Bit32 b, Bit32 c)
            => default;

        [MethodImpl(Inline)]
        public static Bit32 f6f(Bit32 a, Bit32 b, Bit32 c)
            => default;
    }
}