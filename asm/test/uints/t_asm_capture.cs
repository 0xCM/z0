//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    
    public class t_asm_delegates: t_asm<t_asm_delegates>
    {

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
            => x => ginx.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v,(byte)Arrange4L.ABCD);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        AsmFormatConfig AsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();


        public void capture_constants()
        {
            var svc = Context.Capture();

            using var hex = HexTestWriter();
            using var asm = AsmTestWriter();            
        
            var f = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
        
            svc.SaveBits(f,hex);
            svc.SaveAsm(f, asm);
        }

        public void capture_shifter()
        {
            var svc = Context.Capture();

            using var hex = HexTestWriter();
            using var asm = AsmTestWriter();

            var f = shifter(4);
            svc.SaveBits(f, hex);
            svc.SaveAsm(f, asm);            
        }

        public void capture_shuffler()
        {
            var svc = Context.Capture();

            using var hex = HexTestWriter();
            using var asm = AsmTestWriter();

            var f = shuffler<uint>(n2);
            svc.SaveBits(f, hex);
            svc.SaveAsm(f, asm);            

            var g = shuffler(n3);
            svc.SaveBits(g, hex);
            svc.SaveAsm(g, asm);            
        }

    }
}