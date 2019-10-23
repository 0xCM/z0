//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIbit
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;    

    public static partial class loc
    {


        public static uint composition_54(uint v1, uint v2)
            => ScalarOps.or(v2, ScalarOps.xor(v1,ScalarOps.and(v1, ScalarOps.nand(v2, ScalarOps.not(v1)))));

        public static byte composition_54(byte v1, byte v2)
            => ScalarOps.or(v2, ScalarOps.xor(v1,ScalarOps.and(v1, ScalarOps.nand(v2, ScalarOps.not(v1)))));

        // ~

        public static ulong and_64u(ulong a, ulong b)
            => ScalarOps.and(a,b);


        public static Vector128<ulong> and_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Ops.and(a,b);

        public static Vector256<ulong> and_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Ops.and(a,b);


        // ~

        public static ulong or_64u(ulong a, ulong b)
            => ScalarOps.or(a,b);

        public static Vector128<ulong> or_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Ops.or(a,b);

         public static Vector256<ulong> or_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Ops.or(a,b);

       // ~

        public static ulong xor_64u(ulong a, ulong b)
            => ScalarOps.xor(a,b);

        public static Vector128<ulong> xor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Ops.xor(a,b);

        public static Vector256<ulong> xor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Ops.xor(a,b);

        // ~

        public static ulong not_64u(ulong a)
            => ScalarOps.not(a);

        public static Vector128<ulong> not_v128x64u(Vector128<ulong> a)
            => Cpu128Ops.not(a);

        public static Vector256<ulong> not_v256x64u(Vector256<ulong> a)
            => Cpu256Ops.not(a);


        // ~

        public static ulong nand_64u(ulong a, ulong b)
            => ScalarOps.nand(a,b);

        public static Vector128<ulong> nand_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Ops.nand(a,b);

        public static Vector256<ulong> nand_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Ops.nand(a,b);

        // ~
        public static ulong nor_64u(ulong a, ulong b)
            => ScalarOps.nor(a,b);

        public static Vector128<ulong> nor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Ops.nor(a,b);
        
        public static Vector256<ulong> nor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Ops.nor(a,b);

        // ~

        public static ulong xnor_64u(ulong a, ulong b)
            => ScalarOps.xnor(a,b);

        public static Vector128<ulong> xnor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Ops.xnor(a,b);

        public static Vector256<ulong> xnor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Ops.xnor(a,b);

        // ~

        public static ulong xor1_64u(ulong a)
            => ScalarOps.xor1(a);

        public static Vector128<ulong> xor1_v128x64u(Vector128<ulong> a)
            => Cpu128Ops.xor1(a);

        public static Vector256<ulong> xor1_v256x64u(Vector256<ulong> a)
            => Cpu256Ops.xor1(a);

        // ~

        public static ulong select_64u(ulong a, ulong b, ulong c)
            => ScalarOps.select(a,b,c);

        public static Vector128<ulong> select_v128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.select(a,b,c);

        public static Vector256<ulong> select_v256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.select(a,b,c);

        // ~ 

        public static bit f01_bit(bit a, bit b, bit c)
            => LogicOps.f01(a,b,c);

        public static ulong f01_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f01(a,b,c);

 
        public static Vector128<ulong> f01_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f01(a,b,c);

        public static Vector256<ulong> f01_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f01(a,b,c);

        // ~ 

        public static bit f02_bit(bit a, bit b, bit c)
            => LogicOps.f02(a,b,c);

        public static ulong f02_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f02(a,b,c);

        public static Vector128<ulong> f02_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f02(a,b,c);
 
        public static Vector256<ulong> f02_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f02(a,b,c);

        // ~ 

        public static bit f03_bit(bit a, bit b, bit c)
            => LogicOps.f03(a,b,c);

        public static ulong f03_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f03(a,b,c);

        public static Vector128<ulong> f03_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f03(a,b,c);

        public static Vector256<ulong> f03_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f03(a,b,c);

        // ~ 

        public static bit f04_bit(bit a, bit b, bit c)
            => LogicOps.f04(a,b,c);

        public static ulong f04_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f04(a,b,c);

        public static Vector128<ulong> f04_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f04(a,b,c);

        public static Vector256<ulong> f04_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f04(a,b,c);

        // ~ 

        // c nor a
        public static bit f05_bit(bit a, bit b, bit c)
            => LogicOps.f05(a,b,c);

        // c nor a
        public static ulong f05_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f05(a,b,c);

        public static Vector128<ulong> f05_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f05(a,b,c);

        // c nor a
        public static Vector256<ulong> f05_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f05(a,b,c);

        // ~ 
 
        // not a and (b xor c)
        public static bit f06_bit(bit a, bit b, bit c)
            => LogicOps.f06(a,b,c);

        // not a and (b xor c)
        public static ulong f06_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f06(a,b,c);

        public static Vector128<ulong> f06_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f06(a,b,c);

        public static Vector256<ulong> f06_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f06(a,b,c);

        // ~ not a and (b xor c)

        public static bit f07_bit(bit a, bit b, bit c)
            => LogicOps.f07(a,b,c);

        public static ulong f07_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f07(a,b,c);

        public static Vector128<ulong> f07_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f07(a,b,c);

        public static Vector256<ulong> f07_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f07(a,b,c);

        // ~ (not a and b) and c

        public static bit f08_bit(bit a, bit b, bit c)
            => LogicOps.f08(a,b,c);

        // (not a and b) and c
        public static ulong f08_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f08(a,b,c);

        public static Vector128<ulong> f08_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f08(a,b,c);

        public static Vector256<ulong> f08_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f08(a,b,c);

        // ~ a nor (b xor c)
        public static bit f09_bit(bit a, bit b, bit c)
            => LogicOps.f09(a,b,c);

        public static ulong f09_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f09(a,b,c);

        public static Vector128<ulong> f09_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f09(a,b,c);

        public static Vector256<ulong> f09_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f09(a,b,c);

        // ~ c and (not a)

        public static bit f0a_bit(bit a, bit b, bit c)
            => LogicOps.f0a(a,b,c);

        public static ulong f0a_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f0a(a,b,c);


        public static Vector128<ulong> f0a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f0a(a,b,c);

        public static Vector256<ulong> f0a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f0a(a,b,c);

        // ~ not a and ((b xor 1) or c)

        public static bit f0b_bit(bit a, bit b, bit c)
            => LogicOps.f0b(a,b,c);

        public static ulong f0b_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f0b(a,b,c);

        public static Vector128<ulong> f0b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f0b(a,b,c);


        public static Vector256<ulong> f0b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f0b(a,b,c);

        // ~ b and (not a)

        public static bit f0c_bit(bit a, bit b, bit c)
            => LogicOps.f0c(a,b,c);

        public static ulong f0c_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f0c(a,b,c);

        public static Vector128<ulong> f0c_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f0c(a,b,c);

        public static Vector256<ulong> f0c_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f0c(a,b,c);

        // ~ not (A) and (B or (C xor 1))

        public static bit f0d_bit(bit a, bit b, bit c)
            => LogicOps.f0d(a,b,c);

        public static ulong f0d_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f0d(a,b,c);

        public static Vector128<ulong> f0d_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f0d(a,b,c);

        public static Vector256<ulong> f0d_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f0d(a,b,c);

        // ~ not a and (b or c)

        public static bit f0e_bit(bit a, bit b, bit c)
            => LogicOps.f0e(a,b,c);

        public static ulong f0e_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f0e(a,b,c);

        public static Vector128<ulong> f0e_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f0e(a,b,c);

        public static Vector256<ulong> f0e_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f0e(a,b,c);


        // ~ not a

        public static bit f0f_bit(bit a, bit b, bit c)
            => LogicOps.f0f(a,b,c);

        // not a
        public static ulong f0f_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f0f(a,b,c);


        // not a
        public static Vector128<ulong> f0f_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f0f(a,b,c);

        // not a
        public static Vector256<ulong> f0f_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f0f(a,b,c);

        // ~ a and (b nor c)

        public static bit f10_bit(bit a, bit b, bit c)
            => LogicOps.f10(a,b,c);
        
        public static ulong f10_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f10(a,b,c);
        
        public static Vector128<ulong> f10_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f10(a,b,c);
        
        public static Vector256<ulong> f10_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f10(a,b,c);        

        // ~ 

        // a and (b nor c)
        public static bit f11_bit(bit a, bit b, bit c)
            => LogicOps.f11(a,b,c);
        
        // a and (b nor c)
        public static ulong f11_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f11(a,b,c);


        // a and (b nor c)
        public static Vector128<ulong> f11_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f11(a,b,c);
        

        // a and (b nor c)
        public static Vector256<ulong> f11_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f11(a,b,c);
        

        // ~ not b and (a xor c) 

        public static bit f12_bit(bit a, bit b, bit c)
            => LogicOps.f12(a,b,c);

        // not b and (a xor c) 
        public static ulong f12_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f12(a,b,c);

        public static Vector128<ulong> f12_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f12(a,b,c);

        // not b and (a xor c) 
        public static Vector256<ulong> f12_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f12(a,b,c);

        // ~ b nor (a and c)

        public static bit f13_bit(bit a, bit b, bit c)
            => LogicOps.f13(a,b,c);

        public static ulong f13_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f13(a,b,c);


        public static Vector128<ulong> f13_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f13(a,b,c);

        public static Vector256<ulong> f13_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f13(a,b,c);


        // ~ 

        public static bit f14_bit(bit a, bit b, bit c)
            => LogicOps.f14(a,b,c);

        public static ulong f14_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f14(a,b,c);

        public static Vector128<ulong> f14_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f14(a,b,c);

        public static Vector256<ulong> f14_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f14(a,b,c);

        // ~ 

        public static bit f15_bit(bit a, bit b, bit c)
            => LogicOps.f15(a,b,c);

        public static ulong f15_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f15(a,b,c);

        public static Vector128<ulong> f15_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f15(a,b,c);

        public static Vector256<ulong> f15_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f15(a,b,c);

        // ~ 

        // a ? (b nor c) : (b xor c)
        public static bit f16_bit(bit a, bit b, bit c)
            => LogicOps.f16(a,b,c);
 
         // a ? (b nor c) : (b xor c)
        public static ulong f16_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f16(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Vector128<ulong> f16_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f16(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Vector256<ulong> f16_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f16(a,b,c);

        // ~ 

        public static bit f17_bit(bit a, bit b, bit c)
            => LogicOps.f17(a,b,c);

        public static ulong f17_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f17(a,b,c);

        public static Vector128<ulong> f17_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f17(a,b,c);

        public static Vector256<ulong> f17_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f17(a,b,c);


        // ~ 

        public static bit f18_bit(bit a, bit b, bit c)
            => LogicOps.f18(a,b,c);


        public static ulong f18_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f18(a,b,c);

 
        public static Vector128<ulong> f18_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f18(a,b,c);

        public static Vector256<ulong> f18_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f18(a,b,c);

        // ~ 
        public static bit f19_bit(bit a, bit b, bit c)
            => LogicOps.f19(a,b,c);

        public static ulong f19_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f19(a,b,c);

 
        public static Vector128<ulong> f19_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f19(a,b,c);

        public static Vector256<ulong> f19_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f19(a,b,c);

        // ~ 

        public static bit f1a_bit(bit a, bit b, bit c)
            => LogicOps.f1a(a,b,c);

        public static ulong f1a_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f1a(a,b,c);

 
        public static Vector128<ulong> f1a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f1a(a,b,c);

        public static Vector256<ulong> f1a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f1a(a,b,c);

        // ~ c ? not a : not b

        public static bit f1b_bit(bit a, bit b, bit c)
            => LogicOps.f1b(a,b,c);

        public static ulong f1b_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f1b(a,b,c);

        public static Vector128<ulong> f1b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f1b(a,b,c);

        public static Vector256<ulong> f1b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f1b(a,b,c);


        public static ulong f1c_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f1c(a,b,c);

        public static ulong f1d(ulong a, ulong b, ulong c)
            => ScalarOps.f1d(a,b,c);

        public static ulong f1e(ulong a, ulong b, ulong c)
            => ScalarOps.f1e(a,b,c);

        //a nand (b or c)
        public static ulong f1f(ulong a, ulong b, ulong c)
            => ScalarOps.f1f(a,b,c);

        //(not (B) and A) and C
        public static ulong f20(ulong a, ulong b, ulong c)
            => ScalarOps.f20(a,b,c);

        public static ulong f21(ulong a, ulong b, ulong c)
            => ScalarOps.f21(a,b,c);

        public static ulong f22(ulong a, ulong b, ulong c)
            => ScalarOps.f22(a,b,c);

        public static ulong f23(ulong a, ulong b, ulong c)
            => ScalarOps.f23(a,b,c);

        public static ulong f24(ulong a, ulong b, ulong c)
            => ScalarOps.f24(a,b,c);

        public static ulong f25(ulong a, ulong b, ulong c)
            => ScalarOps.f25(a,b,c);

        public static ulong f26(ulong a, ulong b, ulong c)
            => ScalarOps.f26(a,b,c);

        public static ulong f27(ulong a, ulong b, ulong c)
            => ScalarOps.f27(a,b,c);

        public static ulong f28(ulong a, ulong b, ulong c)
            => ScalarOps.f28(a,b,c);

        public static ulong f29(ulong a, ulong b, ulong c)
            => ScalarOps.f29(a,b,c);

        public static ulong f2a(ulong a, ulong b, ulong c)
            => ScalarOps.f2a(a,b,c);

        public static ulong f2b(ulong a, ulong b, ulong c)
            => ScalarOps.f2b(a,b,c);

        public static ulong f2c(ulong a, ulong b, ulong c)
            => ScalarOps.f2c(a,b,c);

        public static ulong f2d(ulong a, ulong b, ulong c)
            => ScalarOps.f2d(a,b,c);

        public static ulong f2e(ulong a, ulong b, ulong c)
            => ScalarOps.f2e(a,b,c);

        public static ulong f2f(ulong a, ulong b, ulong c)
            => ScalarOps.f2f(a,b,c);

        public static ulong f30(ulong a, ulong b, ulong c)
            => ScalarOps.f30(a,b,c);

        public static ulong f31(ulong a, ulong b, ulong c)
            => ScalarOps.f31(a,b,c);

        public static ulong f32(ulong a, ulong b, ulong c)
            => ScalarOps.f32(a,b,c);

        public static ulong f33(ulong a, ulong b, ulong c)
            => ScalarOps.f33(a,b,c);

        public static ulong f34(ulong a, ulong b, ulong c)
            => ScalarOps.f34(a,b,c);

        public static ulong f35(ulong a, ulong b, ulong c)
            => ScalarOps.f35(a,b,c);

        public static ulong f36(ulong a, ulong b, ulong c)
            => ScalarOps.f36(a,b,c);

        public static ulong f37(ulong a, ulong b, ulong c)
            => ScalarOps.f37(a,b,c);

        public static ulong f38(ulong a, ulong b, ulong c)
            => ScalarOps.f38(a,b,c);

        public static ulong f39(ulong a, ulong b, ulong c)
            => ScalarOps.f39(a,b,c);

        public static ulong f3a(ulong a, ulong b, ulong c)
            => ScalarOps.f3a(a,b,c);

        public static ulong f3b(ulong a, ulong b, ulong c)
            => ScalarOps.f3b(a,b,c);

        public static ulong f3c(ulong a, ulong b, ulong c)
            => ScalarOps.f3c(a,b,c);

        public static ulong f3d(ulong a, ulong b, ulong c)
            => ScalarOps.f3d(a,b,c);

        public static ulong f3e(ulong a, ulong b, ulong c)
            => ScalarOps.f3e(a,b,c);

        public static ulong f3f(ulong a, ulong b, ulong c)
            => ScalarOps.f3f(a,b,c);

        public static ulong f40(ulong a, ulong b, ulong c)
            => ScalarOps.f40(a,b,c);

        public static ulong f41(ulong a, ulong b, ulong c)
            => ScalarOps.f41(a,b,c);

        public static ulong f42(ulong a, ulong b, ulong c)
            => ScalarOps.f42(a,b,c);

        public static ulong f43(ulong a, ulong b, ulong c)
            => ScalarOps.f43(a,b,c);

        public static ulong f44(ulong a, ulong b, ulong c)
            => ScalarOps.f44(a,b,c);

        public static ulong f45(ulong a, ulong b, ulong c)
            => ScalarOps.f45(a,b,c);

        public static ulong f46(ulong a, ulong b, ulong c)
            => ScalarOps.f46(a,b,c);

        public static ulong f47(ulong a, ulong b, ulong c)
            => ScalarOps.f47(a,b,c);

        public static ulong f48(ulong a, ulong b, ulong c)
            => ScalarOps.f48(a,b,c);

        public static ulong f49(ulong a, ulong b, ulong c)
            => ScalarOps.f49(a,b,c);

        public static ulong f4a(ulong a, ulong b, ulong c)
            => ScalarOps.f4a(a,b,c);

        public static ulong f4b(ulong a, ulong b, ulong c)
            => ScalarOps.f4b(a,b,c);

        public static ulong f4c(ulong a, ulong b, ulong c)
            => ScalarOps.f4c(a,b,c);

        public static ulong f4d(ulong a, ulong b, ulong c)
            => ScalarOps.f4d(a,b,c);

        public static ulong f4e(ulong a, ulong b, ulong c)
            => ScalarOps.f4e(a,b,c);

        public static ulong f4f(ulong a, ulong b, ulong c)
            => ScalarOps.f4f(a,b,c);

        public static ulong f97_64u(ulong a, ulong b, ulong c)
            => ScalarOps.f97(a,b,c);

       public static Vector128<ulong> f97_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Ops.f97(a,b,c);

       public static Vector256<ulong> f97_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Ops.f97(a,b,c);

    }
}