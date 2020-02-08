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
    using static HK;
    using AsmSpecs;

    class t_asm_main : t_asm_explicit<t_asm_main>
    {
        protected override void OnExecute(in AsmBuffers buffers)
        {
            capture_constants(buffers);
            capture_shifter(buffers);
            capture_shuffler(buffers);
            capture_archived(buffers);
            archive_context(buffers);
        }

        void archive_context(in AsmBuffers buffers)
        {
            var archive = Context.Archiver();
            var selection = from c in Context.Assemblies.Catalogs
                            where !c.IsEmpty && c.AssemblyId != AssemblyId.Data
                            orderby c.AssemblyId
                            select c.AssemblyId;
            foreach(var id in selection)
                archive.Archive(id);    

            // archive.Archive(AssemblyId.GMath);
            // archive.Archive(AssemblyId.Intrinsics);
        }

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => ginx.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        AsmFormatConfig AsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        void capture_constants(in AsmBuffers buffers)
        {
            using var hex = HexTestWriter();
            using var asm = AsmTestWriter();            
        
            var capture = Context.Capture();

            var f = typeof(gmath).Method(nameof(gmath.alteven)).MapRequired(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(byte)));
        
            capture.CaptureBits(buffers.Exchange, f, hex);
            capture.CaptureAsm(buffers.Exchange, f, asm);
        }

        void capture_shifter(in AsmBuffers buffers)
        {
            using var hex = HexTestWriter();
            using var asm = AsmTestWriter();
         
            var capture = Context.Capture();

            var f = shifter(4);
            capture.CaptureBits(buffers.Exchange, f, hex);
            capture.CaptureAsm(buffers.Exchange, f, asm);            
        }

        void capture_shuffler(in AsmBuffers buffers)
        {
            using var hex = HexTestWriter();
            using var asm = AsmTestWriter();

            var capture = Context.Capture();

            var f = shuffler<uint>(n2);
            capture.CaptureBits(buffers.Exchange, f, hex);
            capture.CaptureAsm(buffers.Exchange, f, asm);            

            var g = shuffler(n3);
            capture.CaptureBits(buffers.Exchange, g, hex);
            capture.CaptureAsm(buffers.Exchange, g, asm);     
        }

        void capture_archived(in AsmBuffers buffers)
        {
            var code = ArchivedCode(nameof(gmath), nameof(math), OpIdentity.Define(nameof(math.and)));
            iter(code, c => Trace(c));
        }

         
    }
}
