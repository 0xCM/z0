//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using AsmSpecs;

    using static zfunc;

    public static partial class AsmExtend
    {
        public static IAsmDecoder Decoder(this IAsmContext ctx, int? bufferlen = null)
            => AsmServices.Decoder(ctx, bufferlen);

            
        public static void CaptureDelegate(this IAsmContext ctx, Delegate src, IAsmFunctionWriter dst)
        {
            var capture = NativeCapture.capture(src,dst.TakeBuffer());
            var decoded = AsmServices.Decoder(ctx).DecodeFunction(capture);
            dst.Write(decoded);
        }

        public static void CaptureMethod(this IAsmContext ctx, MethodInfo src, IAsmFunctionWriter dst)
        {
            var capture = NativeCapture.capture(src,dst.TakeBuffer());
            var decoded = AsmServices.Decoder(ctx).DecodeFunction(capture);
            dst.Write(decoded);
        }

        public static void CaptureMethod(this IAsmContext ctx, MethodInfo src, Type arg, IAsmFunctionWriter dst)
        {
            var capture = NativeCapture.capture(src, arg, dst.TakeBuffer());
            var decoded = AsmServices.Decoder(ctx).DecodeFunction(capture);         
            dst.Write(decoded);
        }

        public static void CaptureMethods(this IAsmContext ctx, IEnumerable<MethodInfo> methods, Type arg, IAsmFunctionWriter dst)
            => iter(methods, m => ctx.CaptureMethod(m, arg, dst));

        public static IAsmCodeArchive CodeArchive(this AssemblyId assembly, string subject)
            => AsmServices.CodeArchive(assembly,subject);

        public static IAsmCodeIndex ToCodeIndex(this IEnumerable<AsmCode> code, bool generic)
            => AsmCodeIndex.Create(code,generic);
    }

}