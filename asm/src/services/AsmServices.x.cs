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

        public static void CaptureAsm(this Delegate src, IAsmWriter dst, AsmFormatConfig format = null)
            => dst.WriteFunction(NativeCapture.capture(src,dst.TakeBuffer()), format ?? AsmFormatConfig.Default);

        public static void CaptureAsm(this MethodInfo src, IAsmWriter dst, AsmFormatConfig format = null)
            => dst.WriteFunction(NativeCapture.capture(src,dst.TakeBuffer()), format ?? AsmFormatConfig.Default);

        public static void CaptureAsm(this MethodInfo src, Type arg, IAsmWriter dst, AsmFormatConfig format = null)
            => dst.WriteFunction(NativeCapture.capture(src, arg, dst.TakeBuffer()), format ?? AsmFormatConfig.Default);

        public static void CaptureAsm(this IEnumerable<MethodInfo> methods, Type arg, IAsmWriter dst, AsmFormatConfig format = null)
            => iter(methods, m => m.CaptureAsm(arg, dst, format ?? AsmFormatConfig.Default.WithSeparator()));
    }
}