//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;
    using static Classifiers;

    public class t_asm_checks : t_asm<t_asm_checks>, IDisposable
    {           


        internal void RunExplicit()
        {

        }

        public void vadd_check()
        {
            var name = nameof(dinx.vadd);
            vadd_check(n128, ReadAsm(name, n128, z8));            
            vadd_check(n128, ReadAsm(name, n128,z16));
            vadd_check(n128, ReadAsm(name, n128,z32));
            vadd_check(n256, ReadAsm(name, n256,z16));
            vadd_check(n256, ReadAsm(name, n256,z32));
        }

        public void add_megacheck()
        {
            var name = nameof(math.add);
            megacheck(name, math.add, gmath.add, u8);              
            megacheck(name, math.add, gmath.add, i8);              
            megacheck(name, math.add, gmath.add, u16);              
            megacheck(name, math.add, gmath.add, i16);              
            megacheck(name, math.add, gmath.add, u32);            
            megacheck(name, math.add, gmath.add, i32);            
            megacheck(name, math.add, gmath.add, u64);            
            megacheck(name, math.add, gmath.add, i64);            
        }

        public void sub_megacheck()
        {
            var name = nameof(math.sub);
            megacheck(name, math.sub, gmath.sub, u8);              
            megacheck(name, math.sub, gmath.sub, i8);              
            megacheck(name, math.sub, gmath.sub, u16);              
            megacheck(name, math.sub, gmath.sub, i16);              
            megacheck(name, math.sub, gmath.sub, u32);            
            megacheck(name, math.sub, gmath.sub, i32);            
            megacheck(name, math.sub, gmath.sub, u64);            
            megacheck(name, math.sub, gmath.sub, i64);            
        }

        void mul_megacheck()
        {
            var name = nameof(math.mul);
            megacheck(name, math.mul, gmath.mul, u8);              
            megacheck(name, math.mul, gmath.mul, i8);              
            megacheck(name, math.mul, gmath.mul, u16);              
            megacheck(name, math.mul, gmath.mul, i16);              
            megacheck(name, math.mul, gmath.mul, u32);            
            megacheck(name, math.mul, gmath.mul, i32);            
            megacheck(name, math.mul, gmath.mul, u64);            
            megacheck(name, math.mul, gmath.mul, i64);            
        }

        public void and_megacheck()
        {
            var name = nameof(math.and);
            megacheck(name, math.and, gmath.and, u8);              
            megacheck(name, math.and, gmath.and, i8);              
            megacheck(name, math.and, gmath.and, u16);              
            megacheck(name, math.and, gmath.and, i16);              
            megacheck(name, math.and, gmath.and, u32);            
            megacheck(name, math.and, gmath.and, i32);            
            megacheck(name, math.and, gmath.and, u64);            
            megacheck(name, math.and, gmath.and, i64);            
        }

        public void xor_megacheck()
        {
            var name = nameof(math.xor);
            megacheck(name, math.xor, gmath.xor, u8);              
            megacheck(name, math.xor, gmath.xor, i8);              
            megacheck(name, math.xor, gmath.xor, u16);              
            megacheck(name, math.xor, gmath.xor, i16);              
            megacheck(name, math.xor, gmath.xor, u32);            
            megacheck(name, math.xor, gmath.xor, i32);            
            megacheck(name, math.xor, gmath.xor, u64);            
            megacheck(name, math.xor, gmath.xor, i64);            
        }

        public void nand_megacheck()
        {
            var name = nameof(math.nand);
            megacheck(name, math.nand, gmath.nand, u8);              
            megacheck(name, math.nand, gmath.nand, i8);              
            megacheck(name, math.nand, gmath.nand, u16);              
            megacheck(name, math.nand, gmath.nand, i16);              
            megacheck(name, math.nand, gmath.nand, u32);            
            megacheck(name, math.nand, gmath.nand, i32);            
            megacheck(name, math.nand, gmath.nand, u64);            
            megacheck(name, math.nand, gmath.nand, i64);            
        }

        public void xnor_megacheck()
        {
            var name = nameof(math.xnor);
            megacheck(name, math.xnor, gmath.xnor, u8);              
            megacheck(name, math.xnor, gmath.xnor, i8);              
            megacheck(name, math.xnor, gmath.xnor, u16);              
            megacheck(name, math.xnor, gmath.xnor, i16);              
            megacheck(name, math.xnor, gmath.xnor, u32);            
            megacheck(name, math.xnor, gmath.xnor, i32);            
            megacheck(name, math.xnor, gmath.xnor, u64);            
            megacheck(name, math.xnor, gmath.xnor, i64);            
        }

        void sqrt_check()
        {
            var sqrt = AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x51,0xC0,0xC3", moniker("sqrt", z64f), z64f);
            CheckAsmMatch(fmath.sqrt, sqrt);                     
        }

        
        void vadd_check<T>(N128 w, AsmCode<T> asm)
            where T : unmanaged
        {            
            var f = AsmBuffer.BinOp128(asm);            
            CheckMatch<T>(ginx.vadd, f, asm.Id);
        }

        void vadd_check<T>(N256 w, AsmCode<T> asm)
            where T : unmanaged
        {            
            var f = AsmBuffer.BinOp256(asm);
            CheckMatch<T>(ginx.vadd, f, asm.Id);
        }
    }
}