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

        public void datares()
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Data.GetDescriptions())
                Claim.eq(d.Location, location(d.GetBytes()));

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

        public void vector_bitlogic_match()
        {
            var names = array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = PrimalKind.Integers.DistinctKinds();
            var widths = array(FixedWidth.W128, FixedWidth.W256);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                vector_match(n, w, k);                        
        }

        IEnumerable<string> PrimalBitLogicOps
            => items("and", "or", "xor", "nand", "nor", "xnor",
                "impl","nonimpl", "cimpl", "cnonimpl");

        void primal_bitlogic_match()
        {
            var names = PrimalBitLogicOps;
            var kinds = PrimalKind.Integers.DistinctKinds();
            var widths = array(FixedWidth.W8, FixedWidth.W16, FixedWidth.W32, FixedWidth.W64);
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                primal_match(n, w, k);                        
        }

        void primal_match(string name, FixedWidth w, PrimalKind kind)
        {
            var dSrc = nameof(math);
            var gSrc = nameof(gmath);

            var dId = OpIdentity.define(name, kind, false);
            var gId = OpIdentity.define(name, kind, true);

            var dAsm = AsmArchive.Define(dSrc).ReadCode(dId).OnNone(() => Trace($"{dId} not found"));
            var gAsm = AsmArchive.Define(gSrc).ReadCode(gId).OnNone(() => Trace($"{gId} not found"));

            var success = from d in dAsm
                          from g in gAsm
                          let result = binop_match(w,d,g)
                          select result;

            success.OnNone(() => Claim.fail());
        }

        void vector_match(string name, FixedWidth w, PrimalKind kind)
        {
            var dSrc = nameof(dinx);
            var gSrc = nameof(ginx);

            var dId = OpIdentity.define(name, w, kind, false);
            var gId = OpIdentity.define(name, w, kind, true);

            var dAsm = AsmArchive.Define(dSrc).ReadCode(dId).OnNone(() => Trace($"{dId} not found"));
            var gAsm = AsmArchive.Define(gSrc).ReadCode(gId).OnNone(() => Trace($"{gId} not found"));

            var success = from d in dAsm
                          from g in gAsm
                          let result = binop_match(w,d,g)
                          select result;

            success.OnNone(() => Claim.fail());
        }

        bit binop_match(FixedWidth w, AsmCode a, AsmCode b)
        {
            switch(w)
            {
                case FixedWidth.W8:
                    binop_match(n8,a,b);
                    break;

                case FixedWidth.W16:
                    binop_match(n16,a,b);
                    break;

                case FixedWidth.W32:
                    binop_match(n32,a,b);
                    break;

                case FixedWidth.W64:
                    binop_match(n64,a,b);
                    break;

                case FixedWidth.W128:
                    binop_match(n128,a,b);
                    break;

                case FixedWidth.W256:
                    binop_match(n256, a, b);
                    break;

                default:
                    Claim.fail();
                break;
            }
            return bit.On;
        }

        protected void binop_match(N8 w, AsmCode a, AsmCode b)
        {
            var f = LeftBuffer.BinOp(w, a);
            var g = RightBuffer.BinOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(N16 w, AsmCode a, AsmCode b)
        {
            var f = LeftBuffer.BinOp(w, a);
            var g = RightBuffer.BinOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(N32 w, AsmCode a, AsmCode b)
        {
            var f = LeftBuffer.BinOp(w, a);
            var g = RightBuffer.BinOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(N64 w, AsmCode a, AsmCode b)
        {

            var f = LeftBuffer.BinOp(w, a);
            var g = RightBuffer.BinOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(N128 w, AsmCode a, AsmCode b)
        {
            using var fBuffer = AsmExecBuffer.Create();
            using var gBuffer = AsmExecBuffer.Create();

            var f = fBuffer.BinOp(w, a);
            var g = gBuffer.BinOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        protected void binop_match(N256 w, AsmCode a, AsmCode b)
        {
            using var fBuffer = AsmExecBuffer.Create();
            using var gBuffer = AsmExecBuffer.Create();

            var f = fBuffer.BinOp(w, a);
            var g = gBuffer.BinOp(w, b);
            CheckMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }
        
        void vadd_check<T>(N128 w, AsmCode<T> asm)
            where T : unmanaged
        {            
            var f = AsmBuffer.BinOp(w,asm);            
            CheckMatch<T>(ginx.vadd, f, asm.Id);
        }

        void vadd_check<T>(N256 w, AsmCode<T> asm)
            where T : unmanaged
        {            
            var f = AsmBuffer.BinOp(w,asm);
            CheckMatch<T>(ginx.vadd, f, asm.Id);
        }
    }
}