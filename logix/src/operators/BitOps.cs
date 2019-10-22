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
    using static TernaryLogicOpKind;

    /// <summary>
    /// Defines logical operations over 1, 2 or 3 bits
    /// </summary>
    public static class BitOps
    {        
        static bit Off
        {
            [MethodImpl(Inline)]
            get => bit.Off;
        }

        static bit On
        {
            [MethodImpl(Inline)]
            get => bit.On;
        }

        [MethodImpl(Inline)]
        public static bit zero()
            => bit.Off;

        [MethodImpl(Inline)]
        public static bit identity(bit a)
            => a;

        [MethodImpl(Inline)]
        public static bit one()
            => bit.On;
        
        [MethodImpl(Inline)]
        public static bit @false(bit a, bit b)
            => Off;

        [MethodImpl(Inline)]
        public static bit and(bit a, bit b)
            => bit.and(a,b);

        [MethodImpl(Inline)]
        public static bit nand(bit a, bit b)
            => bit.nand(a,b);

        [MethodImpl(Inline)]
        public static bit andnot(bit a, bit b)
            => bit.andnot(a,b);

        [MethodImpl(Inline)]
        public static bit or(bit a, bit b)
            => bit.or(a,b);

        [MethodImpl(Inline)]
        public static bit nor(bit a, bit b)
            => bit.nor(a,b);

        [MethodImpl(Inline)]
        public static bit xor(bit a, bit b)
            => bit.xor(a,b);

        [MethodImpl(Inline)]
        public static bit xnor(bit a, bit b)
            => bit.xnor(a,b);

        [MethodImpl(Inline)]
        public static bit left(bit a, bit b)
            => a;

        [MethodImpl(Inline)]
        public static bit right(bit a, bit b)
            => b;

        [MethodImpl(Inline)]
        public static bit leftnot(bit a, bit b)
            => not(a);

        [MethodImpl(Inline)]
        public static bit rightnot(bit a, bit b)
            => not(b);

        [MethodImpl(Inline)]
        public static bit @true(bit a, bit b)
            => On;
        
        [MethodImpl(Inline)]
        public static bit implies(bit antecedent, bit consequent)
            => bit.implies(antecedent,consequent);

        [MethodImpl(Inline)]
        public static bit not(bit a)
            => !a;

        [MethodImpl(Inline)]
        public static bit xor1(bit a)
            => bit.xor1(a);

        [MethodImpl(Inline)]
        public static bit select(bit a, bit b, bit c)
            => bit.select(a,b,c);

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
            => and(not(a), or(b^one(),  c));   

        // b and (not a)
        [MethodImpl(Inline),TernaryOp(X0C)]
        public static bit f0c(bit a, bit b, bit c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X0D)]
        public static bit f0d(bit a, bit b, bit c)
            => and(not(a), or(b, xor(c, one())));

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
        [MethodImpl(Inline),TernaryOp(X16)]
        public static bit f16(bit a, bit b, bit c)
            => select(a, nor(b,c), xor(b,c));

        // not(a ? (b or c) : (b and c))
        [MethodImpl(Inline),TernaryOp(X17)]
        public static bit f17(bit a, bit b, bit c)
            => not(select(a, or(b,c), and(b,c)));

        // (a xor b) and (a xor c)
        [MethodImpl(Inline),TernaryOp(X18)]
        public static bit f18(bit a, bit b, bit c)
            => and(xor(a,b), xor(a,c));

        // ((b xor c) xor (a and (b and c))
        [MethodImpl(Inline),TernaryOp(X19)]
        public static bit f19(bit a, bit b, bit c)
            => xor(xor(b,c), and(a, and(b,c)));

        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline),TernaryOp(X1A)]
        public static bit f1a(bit a, bit b, bit c)
            => not(and(and(a,b), xor(a, c)));

        // c ? not a : not b
        [MethodImpl(Inline),TernaryOp(X1B)]
        public static bit f1b(bit a, bit b, bit c)
            => select(c, not(a), not(b));

        //not ((a and c)) and (a xor b)
        [MethodImpl(Inline),TernaryOp(X1C)]
        public static bit f1c(bit a, bit b, bit c)
            => and(not(and(a,c)), xor(a,b));

        //b ? (not a) : (not c)
        [MethodImpl(Inline),TernaryOp(X1D)]
        public static bit f1d(bit a, bit b, bit c)
            => select(b, not(a), not(c));

        //a xor (b or c)
        [MethodImpl(Inline),TernaryOp(X1E)]
        public static bit f1e(bit a, bit b, bit c)
            => xor(a, or(b,c));

        // a nand (b or c)
        [MethodImpl(Inline),TernaryOp(X1F)]
        public static bit f1f(bit a, bit b, bit c)
            => nand(a, or(b,c));

        //((not b) and a) and C
        [MethodImpl(Inline),TernaryOp(X20)]
        public static bit f20(bit a, bit b, bit c)
            => and(andnot(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline),TernaryOp(X21)]
        public static bit f21(bit a, bit b, bit c)
            => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline),TernaryOp(X22)]
        public static bit f22(bit a, bit b, bit c)
            => andnot(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline),TernaryOp(X23)]
        public static bit f23(bit a, bit b, bit c)
            => and(not(b),or(xor1(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline),TernaryOp(X24)]
        public static bit f24(bit a, bit b, bit c)
            => and(xor(a,b), xor(b,c));

        // (not ((a and b)) and (a xor (c xor 1)))
        [MethodImpl(Inline),TernaryOp(X25)]
        public static bit f25(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(a, xor1(c)));

        //not ((a and b)) and (b xor c)
        [MethodImpl(Inline),TernaryOp(X26)]
        public static bit f26(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(b,c));

        // C ? not (B) : not (A)
        [MethodImpl(Inline),TernaryOp(X27)]
        public static bit f27(bit a, bit b, bit c)
            => select(c, not(b),not(c));

        // C and (B xor A)
        [MethodImpl(Inline),TernaryOp(X28)]
        public static bit f28(bit a, bit b, bit c)
            => and(c, xor(b,a));

        // C ? (B xor A) : (B nor A)
        [MethodImpl(Inline),TernaryOp(X29)]
        public static bit f29(bit a, bit b, bit c)
            => select(c, xor(b,a), nor(b,a));

        // C and (B nand A)
        [MethodImpl(Inline),TernaryOp(X2A)]
        public static bit f2a(bit a, bit b, bit c)
            => and(c, nand(b,a));

        // C ? (B nand A) : (B nor A)
        [MethodImpl(Inline),TernaryOp(X2B)]
        public static bit f2b(bit a, bit b, bit c)
            => select(c, nand(b,a), nor(b,a));

        // (B or C) and (A xor B)
        [MethodImpl(Inline),TernaryOp(X2C)]
        public static bit f2c(bit a, bit b, bit c)
            => and(or(b,c), xor(a,b));

        // A xor (B or not (C))
        [MethodImpl(Inline),TernaryOp(X2D)]
        public static bit f2d(bit a, bit b, bit c)
            => xor(a,(or(b,not(c))));
            
        // (B or C) xor (A and B)
        [MethodImpl(Inline),TernaryOp(X2E)]
        public static bit f2e(bit a, bit b, bit c)
            => xor(or(b,c), or(a,b));

        // not (A) or (not (B) and C)
        [MethodImpl(Inline),TernaryOp(X2F)]
        public static bit f2f(bit a, bit b, bit c)
            => or(not(a), and(not(b),c));
    
        // a and not(b)
        [MethodImpl(Inline),TernaryOp(X30)]
        public static bit f30(bit a, bit b, bit c)
            => andnot(a,b);

        // not (B) and (A or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X31)]
        public static bit f31(bit a, bit b, bit c)
            => and(not(b), or(a,xor1(c)));

        //not (B) and (A or C)
        [MethodImpl(Inline),TernaryOp(X32)]
        public static bit f32(bit a, bit b, bit c)
            => and(not(b),or(a,c));

        // not (B)
        [MethodImpl(Inline),TernaryOp(X33)]
        public static bit f33(bit a, bit b, bit c)
            => not(b);

        // not ((B and C)) and (A xor B)
        [MethodImpl(Inline),TernaryOp(X34)]
        public static bit f34(bit a, bit b, bit c)
            => and(not(and(b,c)), xor(a,b));

        // A ? not (B) : not (C)
        [MethodImpl(Inline),TernaryOp(X35)]
        public static bit f35(bit a, bit b, bit c)
            => select(a,not(b),not(c));

        // B xor (A or C)
        [MethodImpl(Inline),TernaryOp(X36)]
        public static bit f36(bit a, bit b, bit c)
            => xor(b,or(a,c));

        // B nand (A or C)
        [MethodImpl(Inline),TernaryOp(X37)]
        public static bit f37(bit a, bit b, bit c)
            => nand(b,or(a,c));

        // (A or C) and (A xor B)
        [MethodImpl(Inline),TernaryOp(X38)]
        public static bit f38(bit a, bit b, bit c)
            => and(or(a,c), xor(a,b));

        // B xor (A or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X39)]
        public static bit f39(bit a, bit b, bit c)
            => xor(b, or(a,xor1(c)));

        // A ? not (B) : C
        [MethodImpl(Inline),TernaryOp(X3A)]
        public static bit f3a(bit a, bit b, bit c)
            => select(a, not(b), c);

        // (not (A) and C) or (B xor 1)
        [MethodImpl(Inline),TernaryOp(X3B)]
        public static bit f3b(bit a, bit b, bit c)
            => or(and(not(a),c),xor1(b));

        // B xor A
        [MethodImpl(Inline),TernaryOp(X3C)]
        public static bit f3c(bit a, bit b, bit c)
            => xor(b,a);

        // ((A xor B) or (A nor C))
        [MethodImpl(Inline),TernaryOp(X3D)]
        public static bit f3d(bit a, bit b, bit c)
            => or(xor(b,a),nor(a,c));

        // (not (A) and C) or (A xor B)
        [MethodImpl(Inline),TernaryOp(X3E)]
        public static bit f3e(bit a, bit b, bit c)
            => or(and(not(a),c),xor(a,b));

        // B nand A
        [MethodImpl(Inline),TernaryOp(X3F)]
        public static bit f3f(bit a, bit b, bit c)
            => nand(b,a);

        // (not (C) and A) and B
        [MethodImpl(Inline),TernaryOp(X40)]
        public static bit f40(bit a, bit b, bit c)
            => and(and(not(c),a),b);

        // C nor (B xor A)
        [MethodImpl(Inline),TernaryOp(X41)]
        public static bit f41(bit a, bit b, bit c)
            => nor(c,xor(b,a));

        // (A xor C) and (B xor C)
        [MethodImpl(Inline),TernaryOp(X42)]
        public static bit f42(bit a, bit b, bit c)
            => and(xor(a,c),xor(b,c));

        // not ((A and C)) and (A xor (B xor 1))
        [MethodImpl(Inline),TernaryOp(X43)]
        public static bit f43(bit a, bit b, bit c)
            => and(not(and(a,c)), xor(a,xor1(b)));

        // B and not (C)
        [MethodImpl(Inline),TernaryOp(X44)]
        public static bit f44(bit a, bit b, bit c)
            => andnot(b,c);

        // not (C) and ((A xor 1) or B)
        [MethodImpl(Inline),TernaryOp(X45)]
        public static bit f45(bit a, bit b, bit c)
            => and(not(c), or(xor1(a), b));

        // not ((A and C)) and (B xor C)
        [MethodImpl(Inline),TernaryOp(X46)]
        public static bit f46(bit a, bit b, bit c)
            => and(not(and(a,c)),xor(b,c));

        // B ? not (C) : not (A)
        [MethodImpl(Inline),TernaryOp(X47)]
        public static bit f47(bit a, bit b, bit c)
            => select(b,not(c),not(a));

        // B and (A xor C)
        [MethodImpl(Inline),TernaryOp(X48)]
        public static bit f48(bit a, bit b, bit c)
            => and(b,xor(a,c));

        // B ? (A xor C) : (A nor C)
        [MethodImpl(Inline),TernaryOp(X49)]
        public static bit f49(bit a, bit b, bit c)
            => select(b,xor(a,c),nor(a,c));

        // (B or C) and (A xor C)
        [MethodImpl(Inline),TernaryOp(X4A)]
        public static bit f4a(bit a, bit b, bit c)
            => and(or(b,c), xor(a,c));

         // A xor (not (B) or C)
        [MethodImpl(Inline),TernaryOp(X4B)]
        public static bit f4b(bit a, bit b, bit c)
            => xor(a, or(not(b), c));

        // B and (A nand C)
        [MethodImpl(Inline),TernaryOp(X4C)]
        public static bit f4c(bit a, bit b, bit c)
            => and(b, nand(a,c));

        // B ? (A nand C) : (A nor C)
        [MethodImpl(Inline),TernaryOp(X4D)]
        public static bit f4d(bit a, bit b, bit c)
            => select(b, nand(a,c),nor(a,c));

        // C ? not (A) : B
        [MethodImpl(Inline),TernaryOp(X4E)]
        public static bit f4e(bit a, bit b, bit c)
            => select(c, not(a), b);

        // not (A) or (B and not (C))
        [MethodImpl(Inline),TernaryOp(X4F)]
        public static bit f4f(bit a, bit b, bit c)
            => or(not(a),andnot(b,c));

        // A and not (C)
        [MethodImpl(Inline),TernaryOp(X50)]
        public static bit f50(bit a, bit b, bit c)
            => andnot(a,c);

        // not (C) and (A or (B xor 1))
        [MethodImpl(Inline),TernaryOp(X51)]
        public static bit f51(bit a, bit b, bit c)
            => and(not(c),or(a,xor1(b)));

        // not ((B and C)) and (A xor C)
        [MethodImpl(Inline),TernaryOp(X52)]
        public static bit f52(bit a, bit b, bit c)
            => and(not(and(b,c)),xor(a,c));

        // A ? not (C) : not (B)
        [MethodImpl(Inline),TernaryOp(X53)]
        public static bit f53(bit a, bit b, bit c)
            => select(a, not(c), not(b));

        // not (C) and (A or B)
        [MethodImpl(Inline),TernaryOp(X54)]
        public static bit f54(bit a, bit b, bit c)
            => and(not(c), or(a,b));

        // not (C)
        [MethodImpl(Inline),TernaryOp(X55)]
        public static bit f55(bit a, bit b, bit c)
            => not(c);

        // C xor (B or A)
        [MethodImpl(Inline),TernaryOp(X56)]
        public static bit f56(bit a, bit b, bit c)
            => xor(c,or(b,a));

        // C nand (B or A)
        [MethodImpl(Inline),TernaryOp(X57)]
        public static bit f57(bit a, bit b, bit c)
            => nand(c,or(b,a));

        // (A or B) and (A xor C)
        [MethodImpl(Inline),TernaryOp(X58)]
        public static bit f58(bit a, bit b, bit c)
            => and(or(a,b),xor(a,c));

        // C xor (A or (B xor 1))
        [MethodImpl(Inline),TernaryOp(X59)]
        public static bit f59(bit a, bit b, bit c)
            => xor(c, or(a,xor1(b)));

        // C xor A
        [MethodImpl(Inline),TernaryOp(X5A)]
        public static bit f5a(bit a, bit b, bit c)
            => xor(c,a);

        [MethodImpl(Inline),TernaryOp(X5B)]
        public static bit f5b(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X5C)]
        public static bit f5c(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X5D)]
        public static bit f5d(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X5E)]
        public static bit f5e(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X5F)]
        public static bit f5f(bit a, bit b, bit c)
            => default;

        // c
        [MethodImpl(Inline), TernaryOp(XAA)]
        public static bit faa(bit a, bit b, bit c)
            => c;

    }

}
