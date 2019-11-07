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
    using static TernaryOpKind;
    using static BinaryLogicOpKind;

    /// <summary>
    /// Defines logical operations over 1, 2 or 3 bits
    /// </summary>
    public static class LogicOps
    {        

        [MethodImpl(Inline)]
        public static bit zero()
            => off;

        [MethodImpl(Inline)]
        public static bit identity(bit a)
            => a;

        [MethodImpl(Inline)]
        public static bit one()
            => bit.On;
        
        [MethodImpl(Inline)]
        public static bit @false(bit a, bit b)
            => off;

        [MethodImpl(Inline)]
        public static bit @false(bit a, bit b, bit c)
            => off;

        [MethodImpl(Inline)]
        public static bit @false(bit a)
            => off;

        [MethodImpl(Inline)]
        public static bit @true(bit a)
            => on;

        [MethodImpl(Inline)]
        public static bit @true(bit a, bit b)
            => on;

        [MethodImpl(Inline)]
        public static bit @true(bit a, bit b, bit c)
            => on;

        [MethodImpl(Inline)]
        public static bit not(bit a)
            => !a;

        [MethodImpl(Inline), BinaryLogicOp(And)]
        public static bit and(bit a, bit b)
            => a & b;

        [MethodImpl(Inline), BinaryLogicOp(Nand)]
        public static bit nand(bit a, bit b)
            => !(a & b);

        [MethodImpl(Inline), BinaryLogicOp(Or)]
        public static bit or(bit a, bit b)
            => a | b;

        [MethodImpl(Inline), BinaryLogicOp(Nor)]
        public static bit nor(bit a, bit b)
            => ~(a | b);

        [MethodImpl(Inline), BinaryLogicOp(XOr)]
        public static bit xor(bit a, bit b)
            => a ^ b;

        [MethodImpl(Inline), BinaryLogicOp(Xnor)]
        public static bit xnor(bit a, bit b)
            => !(a ^ b);

        [MethodImpl(Inline), BinaryLogicOp(Implication)]
        public static bit imply(bit a, bit b)
            => a | ~b;

        [MethodImpl(Inline), BinaryLogicOp(Nonimplication)]
        public static bit notimply(bit a, bit b)
            => ~a & b;

        [MethodImpl(Inline), BinaryLogicOp(LeftProject)]
        public static bit left(bit a, bit b)
            => a;

        [MethodImpl(Inline), BinaryLogicOp(RightProject)]
        public static bit right(bit a, bit b)
            => b;

        [MethodImpl(Inline), BinaryLogicOp(LeftNot)]
        public static bit lnot(bit a, bit b)
            => !a;

        [MethodImpl(Inline), BinaryLogicOp(RightNot)]
        public static bit rnot(bit a, bit b)
            => ~b;

        [MethodImpl(Inline), BinaryLogicOp(ConverseImplication)]
        public static bit cimply(bit a, bit b)
            => ~a | b;

        [MethodImpl(Inline), BinaryLogicOp(ConverseNonimplication)]
        public static bit cnotimply(bit a, bit b)
            => a & ~b;

        [MethodImpl(Inline)]
        public static bit same(bit a, bit b)
            => a == b;

        [MethodImpl(Inline)]
        public static bit xor1(bit a)
            => bit.xor1(a);

        [MethodImpl(Inline)]
        public static bit select(bit a, bit b, bit c)
            => bit.select(a,b,c);

        [MethodImpl(Inline),TernaryOp(X00)]
        public static bit f00(bit a, bit b, bit c)
            => off;

        // a nor (b or c)
        [MethodImpl(Inline),TernaryOp(X01)]
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
            => and(not(a), or(not(b),  c));   

        // b and (not a)
        [MethodImpl(Inline),TernaryOp(X0C)]
        public static bit f0c(bit a, bit b, bit c)
            => and(b, not(a));

        // not (A) and (B or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X0D)]
        public static bit f0d(bit a, bit b, bit c)
            => and(not(a), or(b, not(c)));

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

        // not(((B xor C) xor (A and (B and C))))
        [MethodImpl(Inline),TernaryOp(X19)]
        public static bit f19(bit a, bit b, bit c)
            => not(xor(xor(b,c), and(a, and(b,c))));
            
        // not ((a and b)) and (a xor c)
        [MethodImpl(Inline),TernaryOp(X1A)]
        public static bit f1a(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(a,c));
            

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
            => and(cnotimply(a,b),c);

        // b nor (a xor c)
        [MethodImpl(Inline),TernaryOp(X21)]
        public static bit f21(bit a, bit b, bit c)
            => nor(b, xor(a,c));

        // c and (not b)
        [MethodImpl(Inline),TernaryOp(X22)]
        public static bit f22(bit a, bit b, bit c)
            => cnotimply(c,b);

        // not (B) and ((A xor 1) or C)
        [MethodImpl(Inline),TernaryOp(X23)]
        public static bit f23(bit a, bit b, bit c)
            => and(not(b),or(not(a),c));

        // (a xor b) and (b xor c)
        [MethodImpl(Inline),TernaryOp(X24)]
        public static bit f24(bit a, bit b, bit c)
            => and(xor(a,b), xor(b,c));

        // (not ((a and b)) and (a xor (c xor 1)))
        [MethodImpl(Inline),TernaryOp(X25)]
        public static bit f25(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(a, not(c)));

        //not ((a and b)) and (b xor c)
        [MethodImpl(Inline),TernaryOp(X26)]
        public static bit f26(bit a, bit b, bit c)
            => and(not(and(a,b)), xor(b,c));

        // C ? not (B) : not (A)
        [MethodImpl(Inline),TernaryOp(X27)]
        public static bit f27(bit a, bit b, bit c)
            => select(c, not(b), not(a));

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
            => xor(or(b,c), and(a,b));

        // not (A) or (not (B) and C)
        [MethodImpl(Inline),TernaryOp(X2F)]
        public static bit f2f(bit a, bit b, bit c)
            => or(not(a), and(not(b),c));
    
        // a and not(b)
        [MethodImpl(Inline),TernaryOp(X30)]
        public static bit f30(bit a, bit b, bit c)
            => cnotimply(a,b);

        // not (B) and (A or (C xor 1))
        [MethodImpl(Inline),TernaryOp(X31)]
        public static bit f31(bit a, bit b, bit c)
            => and(not(b), or(a,not(c)));

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
            => xor(b, or(a, not(c)));

        // A ? not (B) : C
        [MethodImpl(Inline),TernaryOp(X3A)]
        public static bit f3a(bit a, bit b, bit c)
            => select(a, not(b), c);

        // (not (A) and C) or (B xor 1)
        [MethodImpl(Inline),TernaryOp(X3B)]
        public static bit f3b(bit a, bit b, bit c)
            => or(and(not(a),c),not(b));

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
            => and(not(and(a,c)), xor(a,not(b)));

        // B and not (C)
        [MethodImpl(Inline),TernaryOp(X44)]
        public static bit f44(bit a, bit b, bit c)
            => cnotimply(b,c);

        // not (C) and ((A xor 1) or B)
        [MethodImpl(Inline),TernaryOp(X45)]
        public static bit f45(bit a, bit b, bit c)
            => and(not(c), or(not(a), b));

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
            => or(not(a),cnotimply(b,c));

        // A and not (C)
        [MethodImpl(Inline),TernaryOp(X50)]
        public static bit f50(bit a, bit b, bit c)
            => cnotimply(a,c);

        // not (C) and (A or (B xor 1))
        [MethodImpl(Inline),TernaryOp(X51)]
        public static bit f51(bit a, bit b, bit c)
            => and(not(c),or(a,not(b)));

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
            => xor(c, or(a, not(b)));

        // C xor A
        [MethodImpl(Inline),TernaryOp(X5A)]
        public static bit f5a(bit a, bit b, bit c)
            => xor(c,a);

        //((A xor C) or ((A or B) xor 1))
        [MethodImpl(Inline),TernaryOp(X5B)]
        public static bit f5b(bit a, bit b, bit c)
            => or(xor(a,c), xor(or(a,b),on));

        //(A ? not (C) : B)
        [MethodImpl(Inline),TernaryOp(X5C)]
        public static bit f5c(bit a, bit b, bit c)
            => select(a,not(c), b);

        // not (C) or (not (A) and B)
        [MethodImpl(Inline),TernaryOp(X5D)]
        public static bit f5d(bit a, bit b, bit c)
            => or(not(c), and(not(a), b));

        // (not (C) and B) or (A xor C)
        [MethodImpl(Inline),TernaryOp(X5E)]
        public static bit f5e(bit a, bit b, bit c)
            => or(and(not(c),b),(xor(a,c)));

        [MethodImpl(Inline),TernaryOp(X5F)]
        public static bit f5f(bit a, bit b, bit c)
            => nand(c,a);

        [MethodImpl(Inline),TernaryOp(X60)]
        public static bit f60(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X61)]
        public static bit f61(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X62)]
        public static bit f62(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X63)]
        public static bit f63(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X64)]
        public static bit f64(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X65)]
        public static bit f65(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X66)]
        public static bit f66(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X67)]
        public static bit f67(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X68)]
        public static bit f68(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X69)]
        public static bit f69(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X6A)]
        public static bit f6a(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X6B)]
        public static bit f6b(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X6C)]
        public static bit f6c(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X6D)]
        public static bit f6d(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X6E)]
        public static bit f6e(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X6F)]
        public static bit f6f(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X70)]
        public static bit f70(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X71)]
        public static bit f71(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X72)]
        public static bit f72(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X73)]
        public static bit f73(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X74)]
        public static bit f74(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X75)]
        public static bit f75(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X76)]
        public static bit f76(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X77)]
        public static bit f77(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X78)]
        public static bit f78(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X79)]
        public static bit f79(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X7A)]
        public static bit f7a(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X7B)]
        public static bit f7b(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X7C)]
        public static bit f7c(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X7D)]
        public static bit f7d(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X7E)]
        public static bit f7e(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X7F)]
        public static bit f7f(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X80)]
        public static bit f80(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X81)]
        public static bit f81(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X82)]
        public static bit f82(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X83)]
        public static bit f83(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X84)]
        public static bit f84(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X85)]
        public static bit f85(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X86)]
        public static bit f86(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X87)]
        public static bit f87(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X88)]
        public static bit f88(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X89)]
        public static bit f89(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X8A)]
        public static bit f8a(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X8B)]
        public static bit f8b(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X8C)]
        public static bit f8c(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X8D)]
        public static bit f8d(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X8E)]
        public static bit f8e(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X8F)]
        public static bit f8f(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X90)]
        public static bit f90(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X91)]
        public static bit f91(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X92)]
        public static bit f92(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X93)]
        public static bit f93(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X94)]
        public static bit f94(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X95)]
        public static bit f95(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X96)]
        public static bit f96(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X97)]
        public static bit f97(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X98)]
        public static bit f98(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X99)]
        public static bit f99(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X9A)]
        public static bit f9a(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X9B)]
        public static bit f9b(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X9C)]
        public static bit f9c(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X9D)]
        public static bit f9d(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X9E)]
        public static bit f9e(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(X9F)]
        public static bit f9f(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA0)]
        public static bit fa0(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA1)]
        public static bit fa1(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA2)]
        public static bit fa2(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA3)]
        public static bit fa3(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA4)]
        public static bit fa4(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA5)]
        public static bit fa5(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA6)]
        public static bit fa6(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA7)]
        public static bit fa7(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA8)]
        public static bit fa8(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XA9)]
        public static bit fa9(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline), TernaryOp(XAA)]
        public static bit faa(bit a, bit b, bit c)
            => c;

        [MethodImpl(Inline),TernaryOp(XAB)]
        public static bit fab(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XAC)]
        public static bit fac(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XAD)]
        public static bit fad(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XAE)]
        public static bit fae(bit a, bit b, bit c)
            => default;

        [MethodImpl(Inline),TernaryOp(XAF)]
        public static bit faf(bit a, bit b, bit c)
            => default;

        // ---


        [MethodImpl(Inline), TernaryOp(XCA)]
        public static bit fca(bit a, bit b, bit c)
            => select(a,b,c);

        [MethodImpl(Inline), TernaryOp(XCB)]
        public static bit fcb(bit a, bit b, bit c)
            => b;

        [MethodImpl(Inline), TernaryOp(XFF)]
        public static bit fff(bit a, bit b, bit c)
            => on;

    }

}
