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

    public static class AsmServicesX
    {
        public static void CaptureAsm(this Delegate src, IAsmWriter dst)
            => dst.Write(NativeCapture.capture(src,dst.TakeBuffer()));

        public static void CaptureAsm(this MethodInfo src, IAsmWriter dst)
            => dst.Write(NativeCapture.capture(src,dst.TakeBuffer()));

        public static void CaptureAsm(this MethodInfo src, Type arg, IAsmWriter dst)
            => dst.Write(NativeCapture.capture(src, arg, dst.TakeBuffer()));

        public static void CaptureAsm(this IEnumerable<MethodInfo> methods, Type arg, IAsmWriter dst, AsmFormatConfig format = null)
            => iter(methods, m => m.CaptureAsm(arg, dst));

        public static IAsmFunctionArchive AsmArchive(this AssemblyId assembly, string subject)
            => AsmFunctionArchive.Create(assembly, subject);

        public static IAsmFunctionArchive AsmArchive(this AssemblyId assembly, Type subject)
            => AsmFunctionArchive.Create(assembly, subject);

        public static IAsmCodeArchive CodeArchive(this AssemblyId assembly, string subject)
            => AsmCodeArchive.Create(assembly, subject);

        public static IAsmCodeArchive CodeArchive(this AssemblyId assembly, Type subject)
            => AsmCodeArchive.Create(assembly, subject);


    }
}