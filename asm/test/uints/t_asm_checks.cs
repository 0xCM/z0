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

    [Skip]
    public class t_asm_checks : UnitTest<t_asm_checks>, IDisposable
    {
        AsmExecBuffer AsmBuffer;
        
        public t_asm_checks()
        {
            AsmBuffer = AsmExecBuffer.Create();
        }

        public void RunExplicit()
        {
            vadd_check();
            add_check();
            sqrt_check();
            or_check();
            and_check();

        }

        void vadd_check()
        {
            vadd_check(n128, ReadAsm("vadd", n128, z8));            
            vadd_check(n128, ReadAsm("vadd", n128,z16));
            vadd_check(n128, ReadAsm("vadd", n128,z32));
            vadd_check(n256, ReadAsm("vadd", n256,z16));
            vadd_check(n256, ReadAsm("vadd", n256,z32));

        }

        void and_check()
        {
            var opname = nameof(math.and);

            var kind = PrimalKind.U64;
            var width = kind.Width();
            var indicator = kind.Indicator();
            
            var f1m = Moniker.define(opname, kind);            
            var f1 = FixedDelegate.from(math.and, u64);
            var f2m = Moniker.generic(opname, kind);
            var f2 = FixedDelegate.from(gmath.and, u64);
            var f3m = Moniker.define(opname, kind);
            var f3 = AsmBuffer.BinOp64(ReadAsm(Math, f3m));
            var f4m = Moniker.generic(opname, kind);
            var f4 = AsmBuffer.BinOp64(ReadAsm(GMath, f4m));
            
            CheckMatch(f1, f1m, f2, f2m);
            CheckMatch(f1, f1m, f3, f3m.WithAsm());
            CheckMatch(f1, f1m, f4, f4m.WithAsm());

        }

        void CheckMatch(BinaryOp64 f, Moniker fId, BinaryOp64 g, Moniker gId)
        {
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(n64);
                    var y = Random.Fixed(n64);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));

        }
        void add_check()
        {
            add_check(z8);
            add_check(z8i);
            add_check(z16);
            add_check(z16i);
            add_check(z32);
            add_check(z32i);
            add_check(z64);
            add_check(z64i);            
        }

        void or_check()
        {
            or_check(z8);
            or_check(z8i);
            or_check(z16);
            or_check(z16i);
            or_check(z32);
            or_check(z32i);
            or_check(z64);
            or_check(z64i);            
        }

        void sqrt_check()
        {
            CheckAsmMatch(fmath.sqrt, Sqrt64f);                     
        }

        AsmCode<double> Sqrt64f
            => AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x51,0xC0,0xC3", moniker("sqrt", z64f), z64f);

        AsmCode<uint> Add128x32u
            => AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFE,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3", 
                moniker("vadd", n128, z32), z32);

        AsmCode<ushort> Add128x16u
            => AsmCode.Parse("0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0xfd,0x00,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3",
                moniker("vadd", n128,z16),z16);

        AsmCode<uint> Add256x32u
            => AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3", 
                    moniker("vadd", n256, z32), z32);

        FolderName Math
            => FolderName.Define(nameof(math));
        
        FolderName GMath
            => FolderName.Define(nameof(gmath));

        void add_check<T>(T t = default)
            where T : unmanaged
        {
            CheckAsmMatch(gmath.add, ReadAsm(Math,"add",t));
        }

        void or_check<T>(T t = default)
            where T : unmanaged
        {
            CheckAsmMatch(gmath.or, ReadAsm(Math,"or",t));
        }

        public void Dispose()
        {
            AsmBuffer.Dispose();
        }
        
        AsmCode ReadAsm(FolderName subject, Moniker m)
            => AsmLib.Read(subject, m);

        AsmCode ReadAsm(FolderName subject, string opname, PrimalKind kind)
            => AsmLib.Read(subject, Moniker.define(opname,kind));

        AsmCode<T> ReadAsm<T>(FolderName subject, string opname, T t = default)
            where T : unmanaged
                => new AsmCode<T>(ReadAsm(subject, opname, typeof(T).Kind()));

        AsmCode<T> ReadAsm<W,T>(string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => AsmLib.Intrinsic<T>(Moniker.define(opname, PrimalType.kind<T>(), w));

        void vadd_check<T>(N128 w, AsmCode<T> asm)
            where T : unmanaged
        {            
            var f = AsmBuffer.BinOp128(asm);            
            CheckAction(() => CheckMatch<T>(ginx.vadd, f), CaseName(asm.Name));  
        }

        void vadd_check<T>(N256 w, AsmCode<T> asm)
            where T : unmanaged
        {
            
            var f = AsmBuffer.BinOp256(asm);
            CheckAction(() => CheckMatch<T>(ginx.vadd, f), CaseName(asm.Name));            
        }

        void CheckMatch<T>(BinaryOp<Vector128<T>> f, BinaryOp128 g)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                Claim.eq(f(x,y), g.Apply(x,y));
            }            
        }

        void CheckMatch<T>(BinaryOp<Vector256<T>> f, BinaryOp256 g)
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                Claim.eq(f(x,y), g.Apply(x,y));
            }            
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
                      
            var g = AsmBuffer.BinOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName(asm.Name));
        }


        void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f,asm.Untyped);


        void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
            var g = AsmBuffer.UnaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, CaseName(asm.Name));
        }

        void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f, asm.Untyped);

    }
}