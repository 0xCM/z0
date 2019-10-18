//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIbit
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;    

    public static partial class loc
    {
        public static Vec128<ulong> zero_v128x64u()
            => Vec128Pattern.zeroes<ulong>();

        public static Vector256<ulong> zero_v256x64u()
            => Vec256Pattern.zeroes<ulong>();

        public static Vector256<ulong> one_v256x64u()
            => Cpu256Logic.one<ulong>();

        public static Vec128<ulong> one_v128x64u()
            => Cpu128Logic.one<ulong>();

        // ~

        public static ulong and_64u(ulong a, ulong b)
            => ScalarLogic.and(a,b);

        public static BitVector64 and_bv64u(BitVector64 a, BitVector64 b)
            => BitVectorLogic.and(a,b);

        public static Vector128<ulong> and_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Logic.and(a,b);

        public static Vector256<ulong> and_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Logic.and(a,b);


        // ~

        public static ulong or_64u(ulong a, ulong b)
            => ScalarLogic.or(a,b);

        public static BitVector64 or_bv64u(BitVector64 a, BitVector64 b)
            => BitVectorLogic.or(a,b);

        public static Vector128<ulong> or_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Logic.or(a,b);

         public static Vector256<ulong> or_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Logic.or(a,b);

       // ~

        public static ulong xor_64u(ulong a, ulong b)
            => ScalarLogic.xor(a,b);

        public static BitVector64 xor_bv64u(BitVector64 a, BitVector64 b)
            => BitVectorLogic.xor(a,b);

        public static Vector128<ulong> xor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Logic.xor(a,b);

        public static Vector256<ulong> xor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Logic.xor(a,b);

        // ~

        public static ulong not_64u(ulong a)
            => ScalarLogic.not(a);

        public static BitVector64 not_bv64u(BitVector64 a)
            => BitVectorLogic.not(a);

        public static Vector128<ulong> not_v128x64u(Vector128<ulong> a)
            => Cpu128Logic.not(a);

        public static Vector256<ulong> not_v256x64u(Vector256<ulong> a)
            => Cpu256Logic.not(a);


        // ~

        public static ulong nand_64u(ulong a, ulong b)
            => ScalarLogic.nand(a,b);

        public static BitVector64 nand_bv64u(BitVector64 a, BitVector64 b)
            => BitVectorLogic.nand(a,b);

        public static Vector128<ulong> nand_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Logic.nand(a,b);

        public static Vector256<ulong> nand_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Logic.nand(a,b);

        // ~
        public static ulong nor_64u(ulong a, ulong b)
            => ScalarLogic.nor(a,b);

        public static BitVector64 nor_bv64u(BitVector64 a, BitVector64 b)
            => BitVectorLogic.nor(a,b);

        public static Vector128<ulong> nor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Logic.nor(a,b);
        
        public static Vector256<ulong> nor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Logic.nor(a,b);

        // ~

        public static ulong xnor_64u(ulong a, ulong b)
            => ScalarLogic.xnor(a,b);

        public static BitVector64 xnor_bv64u(BitVector64 a, BitVector64 b)
            => BitVectorLogic.xnor(a,b);

        public static Vector128<ulong> xnor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
            => Cpu128Logic.xnor(a,b);

        public static Vector256<ulong> xnor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
            => Cpu256Logic.xnor(a,b);

        // ~

        public static ulong xor1_64u(ulong a)
            => ScalarLogic.xor1(a);

        public static BitVector64 xor1_bv64u(BitVector64 a)
            => BitVectorLogic.xor1(a);

        public static Vector128<ulong> xor1_v128x64u(Vector128<ulong> a)
            => Cpu128Logic.xor1(a);

        public static Vector256<ulong> xor1_v256x64u(Vector256<ulong> a)
            => Cpu256Logic.xor1(a);

        // ~

        // a ? b : c
        public static ulong select_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.select(a,b,c);

        // a ? b : c
        public static BitVector64 select_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.select(a,b,c);
        
        // a ? b : c
        public static Vector128<ulong> select_v128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.select(a,b,c);

        // a ? b : c
        public static Vector256<ulong> select_v256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.select(a,b,c);

        // ~ 

        // a nor (b or c)
        public static bit f01_bit(bit a, bit b, bit c)
            => BitLogic.f01(a,b,c);

        // a nor (b or c)
        public static ulong f01_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f01(a,b,c);

        // a nor (b or c)
        public static BitVector64 f01_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f01(a,b,c);
 
        // a nor (b or c)
        public static Vector128<ulong> f01_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f01(a,b,c);

        // a nor (b or c)
        public static Vector256<ulong> f01_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f01(a,b,c);

        // ~ 

        // c and (b nor a)
        public static bit f02_bit(bit a, bit b, bit c)
            => BitLogic.f02(a,b,c);

        // c and (b nor a)
        public static ulong f02_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f02(a,b,c);

        // c and (b nor a)
        public static BitVector64 f02_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f02(a,b,c);

        // c and (b nor a)
        public static Vector128<ulong> f02_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f02(a,b,c);
 
        // c and (b nor a)
        public static Vector256<ulong> f02_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f02(a,b,c);

        // ~ 

         // b nor a
        public static bit f03_bit(bit a, bit b, bit c)
            => BitLogic.f03(a,b,c);

         // b nor a
        public static ulong f03_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f03(a,b,c);

         // b nor a
        public static BitVector64 f03_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f03(a,b,c);

         // b nor a
        public static Vector128<ulong> f03_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f03(a,b,c);

         // b nor a
        public static Vector256<ulong> f03_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f03(a,b,c);

        // ~ 

        // b and (a nor c)
        public static bit f04_bit(bit a, bit b, bit c)
            => BitLogic.f04(a,b,c);

        // b and (a nor c)
        public static ulong f04_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f04(a,b,c);

        // b and (a nor c)
        public static BitVector64 f04_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f04(a,b,c);

        // b and (a nor c)
        public static Vector128<ulong> f04_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f04(a,b,c);

        // b and (a nor c)
        public static Vector256<ulong> f04_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f04(a,b,c);

        // ~ 

        // c nor a
        public static bit f05_bit(bit a, bit b, bit c)
            => BitLogic.f05(a,b,c);

        // c nor a
        public static ulong f05_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f05(a,b,c);

       // c nor a
        public static BitVector64 f05_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f05(a,b,c);

        // c nor a
        public static Vector128<ulong> f05_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f05(a,b,c);

        // c nor a
        public static Vector256<ulong> f05_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f05(a,b,c);

        // ~ 
 
        // not a and (b xor c)
        public static bit f06_bit(bit a, bit b, bit c)
            => BitLogic.f06(a,b,c);

        // not a and (b xor c)
        public static ulong f06_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f06(a,b,c);

        // not a and (b xor c)
        public static BitVector64 f06_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f06(a,b,c);
 
        // not a and (b xor c)
        public static Vector128<ulong> f06_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f06(a,b,c);

        // not a and (b xor c)
        public static Vector256<ulong> f06_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f06(a,b,c);

        // ~ 

        // not a and (b xor c)
        public static bit f07_bit(bit a, bit b, bit c)
            => BitLogic.f07(a,b,c);

        // not a and (b xor c)
        public static ulong f07_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f07(a,b,c);

        // not a and (b xor c)
        public static BitVector64 f07_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f07(a,b,c);

        // not a and (b xor c)
        public static Vector128<ulong> f07_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f07(a,b,c);

        // not a and (b xor c)
        public static Vector256<ulong> f07_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f07(a,b,c);

        // ~ 

       // (not a and b) and c
        public static bit f08_bit(bit a, bit b, bit c)
            => BitLogic.f08(a,b,c);

        // (not a and b) and c
        public static ulong f08_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f08(a,b,c);

       // (not a and b) and c
        public static BitVector64 f08_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f08(a,b,c);

        // (not a and b) and c
        public static Vector128<ulong> f08_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f08(a,b,c);

        // (not a and b) and c
        public static Vector256<ulong> f08_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f08(a,b,c);

        // ~ 
        // a nor (b xor c)
        public static bit f09_bit(bit a, bit b, bit c)
            => BitLogic.f09(a,b,c);

        // a nor (b xor c)
        public static ulong f09_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f09(a,b,c);

        // a nor (b xor c)
        public static BitVector64 f09_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f09(a,b,c);

        // a nor (b xor c)
        public static Vector128<ulong> f09_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f09(a,b,c);

        // a nor (b xor c)
        public static Vector256<ulong> f09_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f09(a,b,c);

        // ~ 

        // c and (not a)
        public static bit f0a_bit(bit a, bit b, bit c)
            => BitLogic.f0a(a,b,c);

       // c and (not a)
        public static ulong f0a_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0a(a,b,c);

       // c and (not a)
        public static BitVector64 f0a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f0a(a,b,c);

        // c and (not a)
        public static Vector128<ulong> f0a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f0a(a,b,c);

        // c and (not a)
        public static Vector256<ulong> f0a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f0a(a,b,c);

        // ~ 

        // not a and ((b xor 1) or c)
        public static bit f0b_bit(bit a, bit b, bit c)
            => BitLogic.f0b(a,b,c);

        // not a and ((b xor 1) or c)
        public static ulong f0b_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0b(a,b,c);

       // not a and ((b xor 1) or c)
        public static BitVector64 f0b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f0b(a,b,c);

        // not a and ((b xor 1) or c)
        public static Vector128<ulong> f0b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f0b(a,b,c);


        // not a and ((b xor 1) or c)
        public static Vector256<ulong> f0b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f0b(a,b,c);

        // ~ 

        // b and (not a)
        public static bit f0c_bit(bit a, bit b, bit c)
            => BitLogic.f0c(a,b,c);

        // b and (not a)
        public static ulong f0c_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0c(a,b,c);

       // b and (not a)
        public static BitVector64 f0c_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f0c(a,b,c);

        // b and (not a)
        public static Vector128<ulong> f0c_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f0c(a,b,c);


        // b and (not a)
        public static Vector256<ulong> f0c_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f0c(a,b,c);

        // ~ 

        // not (A) and (B or (C xor 1))
        public static bit f0d_bit(bit a, bit b, bit c)
            => BitLogic.f0d(a,b,c);

        // not (A) and (B or (C xor 1))
        public static ulong f0d_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0d(a,b,c);

        // not (A) and (B or (C xor 1))
        public static BitVector64 f0d_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f0d(a,b,c);

        // not (A) and (B or (C xor 1))
        public static Vector128<ulong> f0d_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f0d(a,b,c);

        // not (A) and (B or (C xor 1))
        public static Vector256<ulong> f0d_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f0d(a,b,c);

        // ~ 

        // not a and (b or c)
        public static bit f0e_bit(bit a, bit b, bit c)
            => BitLogic.f0e(a,b,c);

        // not a and (b or c)
        public static ulong f0e_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0e(a,b,c);

        // not a and (b or c)
        public static BitVector64 f0e_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f0e(a,b,c);

        // not a and (b or c)
        public static Vector128<ulong> f0e_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f0e(a,b,c);


        // not a and (b or c)
        public static Vector256<ulong> f0e_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f0e(a,b,c);


        // ~ 

        // not a
        public static bit f0f_bit(bit a, bit b, bit c)
            => BitLogic.f0f(a,b,c);

        // not a
        public static ulong f0f_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f0f(a,b,c);

        // not a
        public static BitVector64 f0f_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f0f(a,b,c);

        // not a
        public static Vector128<ulong> f0f_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f0f(a,b,c);

        // not a
        public static Vector256<ulong> f0f_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f0f(a,b,c);

        // ~ 

        // a and (b nor c)
        public static bit f10_bit(bit a, bit b, bit c)
            => BitLogic.f10(a,b,c);
        
        // a and (b nor c)
        public static ulong f10_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f10(a,b,c);
        
        // a and (b nor c)
        public static BitVector64 f10_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f10(a,b,c);

        // a and (b nor c)
        public static Vector128<ulong> f10_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f10(a,b,c);
        
        // a and (b nor c)
        public static Vector256<ulong> f10_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f10(a,b,c);
        

        // ~ 

        // a and (b nor c)
        public static bit f11_bit(bit a, bit b, bit c)
            => BitLogic.f11(a,b,c);
        
        // a and (b nor c)
        public static ulong f11_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f11(a,b,c);

        // a and (b nor c)
        public static BitVector64 f11_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f11(a,b,c);

        // a and (b nor c)
        public static Vector128<ulong> f11_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f11(a,b,c);
        

        // a and (b nor c)
        public static Vector256<ulong> f11_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f11(a,b,c);
        

        // ~ 

        // not b and (a xor c) 
        public static bit f12_bit(bit a, bit b, bit c)
            => BitLogic.f12(a,b,c);

        // not b and (a xor c) 
        public static ulong f12_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f12(a,b,c);

        // not b and (a xor c) 
        public static BitVector64 f12_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f12(a,b,c);

        // not b and (a xor c) 
        public static Vector128<ulong> f12_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f12(a,b,c);

        // not b and (a xor c) 
        public static Vector256<ulong> f12_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f12(a,b,c);

        // ~ b nor (a and c)

        public static bit f13_bit(bit a, bit b, bit c)
            => BitLogic.f13(a,b,c);

        public static ulong f13_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f13(a,b,c);

        public static BitVector64 f13_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f13(a,b,c);

        public static Vector128<ulong> f13_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f13(a,b,c);

        public static Vector256<ulong> f13_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f13(a,b,c);


        // ~ 

        public static bit f14_bit(bit a, bit b, bit c)
            => BitLogic.f14(a,b,c);

        public static ulong f14_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f14(a,b,c);

        public static BitVector64 f14_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f14(a,b,c);

        public static Vector128<ulong> f14_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f14(a,b,c);

        public static Vector256<ulong> f14_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f14(a,b,c);

        // ~ 

        public static bit f15_bit(bit a, bit b, bit c)
            => BitLogic.f15(a,b,c);

        public static ulong f15_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f15(a,b,c);

        public static BitVector64 f15_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f15(a,b,c);

        public static Vector128<ulong> f15_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f15(a,b,c);

        public static Vector256<ulong> f15_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f15(a,b,c);

        // ~ 

        // a ? (b nor c) : (b xor c)
        public static bit f16_bit(bit a, bit b, bit c)
            => BitLogic.f16(a,b,c);
 
         // a ? (b nor c) : (b xor c)
        public static ulong f16_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f16(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static BitVector64 f16_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f16(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Vector128<ulong> f16_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f16(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Vector256<ulong> f16_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f16(a,b,c);

        // ~ 

        public static bit f17_bit(bit a, bit b, bit c)
            => BitLogic.f17(a,b,c);

        public static ulong f17_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f17(a,b,c);

        public static BitVector64 f17_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f17(a,b,c);

         public static Vector128<ulong> f17_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f17(a,b,c);

        public static Vector256<ulong> f17_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f17(a,b,c);


        // ~ 

        public static bit f18_bit(bit a, bit b, bit c)
            => BitLogic.f18(a,b,c);


        public static ulong f18_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f18(a,b,c);

        public static BitVector64 f18_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f18(a,b,c);

        public static Vector128<ulong> f18_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f18(a,b,c);

        public static Vector256<ulong> f18_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f18(a,b,c);

        // ~ 
        public static bit f19_bit(bit a, bit b, bit c)
            => BitLogic.f19(a,b,c);

        public static ulong f19_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f19(a,b,c);

        public static BitVector64 f19_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f19(a,b,c);

        public static Vector128<ulong> f19_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f19(a,b,c);

        public static Vector256<ulong> f19_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f19(a,b,c);

        // ~ 

        public static bit f1a_bit(bit a, bit b, bit c)
            => BitLogic.f1a(a,b,c);

        public static ulong f1a_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f1a(a,b,c);

        public static BitVector64 f1a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f1a(a,b,c);

        public static Vector128<ulong> f1a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f1a(a,b,c);

        public static Vector256<ulong> f1a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f1a(a,b,c);

        // ~ 

        public static bit f1b_bit(bit a, bit b, bit c)
            => BitLogic.f1b(a,b,c);

        // c ? not a : not b
        public static ulong f1b_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f1b(a,b,c);

        public static BitVector64 f1b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
            => BitVectorLogic.f1b(a,b,c);

        public static Vector128<ulong> f1b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f1b(a,b,c);

        public static Vector256<ulong> f1b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f1b(a,b,c);

        // ~

        //not ((a and c)) and (a xor b)
        public static ulong f1c_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f1c(a,b,c);


        //b ? (not a) : (not c)
        public static ulong f1d(ulong a, ulong b, ulong c)
            => ScalarLogic.f1d(a,b,c);

        //a xor (b or c)
        public static ulong f1e(ulong a, ulong b, ulong c)
            => ScalarLogic.f1e(a,b,c);

        //a nand (b or c)
        public static ulong f1f(ulong a, ulong b, ulong c)
            => ScalarLogic.f1f(a,b,c);

        //(not (B) and A) and C
        public static ulong f20(ulong a, ulong b, ulong c)
            => ScalarLogic.f20(a,b,c);

        public static ulong f21(ulong a, ulong b, ulong c)
            => ScalarLogic.f21(a,b,c);

        public static ulong f22(ulong a, ulong b, ulong c)
            => ScalarLogic.f22(a,b,c);

        public static ulong f23(ulong a, ulong b, ulong c)
            => ScalarLogic.f23(a,b,c);

        public static ulong f24(ulong a, ulong b, ulong c)
            => ScalarLogic.f24(a,b,c);

        public static ulong f25(ulong a, ulong b, ulong c)
            => ScalarLogic.f25(a,b,c);

        public static ulong f97_64u(ulong a, ulong b, ulong c)
            => ScalarLogic.f97(a,b,c);

       public static Vector128<ulong> f97_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => Cpu128Logic.f97(a,b,c);

       public static Vector256<ulong> f97_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => Cpu256Logic.f97(a,b,c);

    }
}