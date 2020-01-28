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

        public void capture_and()
        {
            using var target = NativeTestWriter();
            using var asm = AsmTestWriter(AsmFormat);
            
            var fmt = AsmFormat;

            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> f = Avx2.And;
            NativeCapture.capture(f,target);
            Context.CaptureDelegate(f,asm);
            

            var g = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            NativeCapture.capture(g,target);            
            Context.CaptureMethod(g, asm);

            var many = typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName("vand");
            NativeCapture.capture(many,typeof(uint),target);
            Context.CaptureMethods(many,typeof(uint), asm);

        }

        public void capture_constants()
        {
            using var asm = AsmTestWriter(AsmFormat);            
            var f = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
            Context.CaptureMethod(f, asm);
        }

        public void capture_shifter()
        {
            using var native = NativeTestWriter();
            using var asm = AsmTestWriter(AsmFormat);
            var fmt = AsmFormat;


            var f = shifter(4);
            NativeCapture.capture(f,native);
            Context.CaptureDelegate(f,asm);

        }

        public void capture_shuffler()
        {
            using var native = NativeTestWriter();
            using var asm = AsmTestWriter(AsmFormat);
            var fmt = AsmFormat;

            var f = shuffler<uint>(n2);
            NativeCapture.capture(f,native);
            Context.CaptureDelegate(f,asm);

            var g = shuffler(n3);
            NativeCapture.capture(g,native);
            Context.CaptureDelegate(g,asm);

        }

    }
}