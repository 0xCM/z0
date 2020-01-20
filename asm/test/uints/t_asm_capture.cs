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
            => AsmFormatConfig.Default.WithoutTimestamp();

        public void capture_and()
        {
            using var native = NativeTestWriter();
            using var asm = AsmTestWriter();
            
            var fmt = AsmFormat;

            Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> f = Avx2.And;
            f.CaptureNative(native);
            f.CaptureAsm(asm,fmt);       

            // var fNative = NativeCapture.capture(f, new byte[100]);
            // var l1 = AddressSegment.Define(fNative.StartAddress, fNative.EndAddress);
            // Trace(l1.Format());
            // Trace(fNative.Length.ToString());
            // var instructions = AsmDecoder.decode(fNative);
            // var l2 = AddressSegment.Define(instructions.BaseAddress, instructions.BaseAddress + (ulong)instructions.EncodedByteCount);
            // Trace(l2.Format());
            

            var g = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            g.CaptureNative(native);
            g.CaptureAsm(asm,fmt.WithSeparator());       

            var many = typeof(ginx).DeclaredStaticMethods().OpenGeneric().WithName("vand");
            many.CaptureNative(typeof(uint), native);            
            many.CaptureAsm(typeof(uint), asm, fmt.WithSeparator());

        }

        public void capture_constants()
        {
            using var asm = AsmTestWriter();            
            var f = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
            f.CaptureAsm(asm, AsmFormat);
        }

        public void capture_shifter()
        {
            using var native = NativeTestWriter();
            using var asm = AsmTestWriter();
            var fmt = AsmFormat;


            var f = shifter(4);
            f.CaptureNative(native);
            f.CaptureAsm(asm,fmt);       
        }

        public void capture_shuffler()
        {
            using var native = NativeTestWriter();
            using var asm = AsmTestWriter();
            var fmt = AsmFormat;

            var f = shuffler<uint>(n2);
            f.CaptureNative(native);
            f.CaptureAsm(asm,fmt);       

            var g = shuffler(n3);
            g.CaptureNative(native);
            g.CaptureAsm(asm,fmt.WithSeparator());       

        }

    }
}