//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public static class CaptureOpExtensions
    {
        public static AsmMemberCapture[] Capture(this IAsmCaptureOps ops, in AsmCaptureExchange exchange, MethodInfo[] methods)
        {
            var targets = new AsmMemberCapture[methods.Length];
            for(var i = 0; i<methods.Length; i++)
            {
                var m = methods[i];
                targets[i] = ops.Capture(in exchange, m.Identify(), m);
            }
            return targets;
        }

        public static AsmMemberCapture Capture(this IAsmCaptureOps ops, in AsmCaptureExchange exchange, MethodInfo src, params Type[] args)
        {
            if(src.IsOpenGeneric())
            {
                var target = src.Reify(args);
                return ops.Capture(in exchange, target.Identify(), target);
            }
            else
                return ops.Capture(in exchange, src.Identify(), src);                
        }
    }
}