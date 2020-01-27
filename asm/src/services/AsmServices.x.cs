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
        public static void CaptureAsm(this Delegate src, IAsmWriter dst)
            => dst.Write(NativeCapture.capture(src,dst.TakeBuffer()));

        public static void CaptureAsm(this MethodInfo src, IAsmWriter dst)
            => dst.Write(NativeCapture.capture(src,dst.TakeBuffer()));

        public static void CaptureAsm(this MethodInfo src, Type arg, IAsmWriter dst)
            => dst.Write(NativeCapture.capture(src, arg, dst.TakeBuffer()));

        public static void CaptureAsm(this IEnumerable<MethodInfo> methods, Type arg, IAsmWriter dst, AsmFormatConfig format = null)
            => iter(methods, m => m.CaptureAsm(arg, dst));

        public static IAsmCodeArchive CodeArchive(this AssemblyId assembly, string subject)
            => AsmServices.CodeArchive(assembly,subject);

        public static IAsmCodeIndex ToCodeIndex(this IEnumerable<AsmCode> code, bool generic)
            => AsmCodeIndex.Create(code,generic);
    }

}