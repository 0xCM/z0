//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    class ArchiveControl : Controller<ArchiveControl>
    {                
        static AsmCodeSet[] ResolveExample<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var imm = new byte[]{199,205};
            var r1 = VX.vbsll(w,t).CaptureImmediates(imm);
            var r2 = VX.vsrl(w,t).CaptureImmediates(imm);            
            var r3 = VX.vblend8x16(w,t).CaptureImmediates(imm);
            return r1.Union(r2).Union(r3).ToArray();
        }

        static AsmCodeSet[] ResolveExample<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var imm = new byte[]{199,205};
            var r1 = VX.vbsll(w,t).CaptureImmediates(imm);
            var r2 = VX.vsrl(w,t).CaptureImmediates(imm);
            return r1.Union(r2).ToArray();            
        }
    
        public override void Execute()
        {
             
             FindCatalog(AssemblyId.Intrinsics).OnSome(c => c.Emit());
             FindCatalog(AssemblyId.GMath).OnSome(c => c.Emit());
             //FindCatalog(AssemblyId.BitVectors).OnSome(c => c.Emit());
            //  IntrinsicsCatalog.Emit();
            //  BitCoreCatalog.Emit();
        
        }

    }
}