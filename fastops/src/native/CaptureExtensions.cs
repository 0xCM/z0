//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public partial interface IMemberCapture
    {        
        CapturedMember Capture(OpIdentity id, DynamicDelegate src, Span<byte> dst)
            => Capture(id,src,CaptureExchange.Define(dst));

        CapturedMember Capture(OpIdentity id, Delegate src, Span<byte> dst)
            => Capture(id,src,CaptureExchange.Define(dst));

        CapturedMember Capture(MethodInfo src, Span<byte> dst)
            => Capture(src.Identify(),src, CaptureExchange.Define(dst));

        CapturedMember Capture(OpIdentity id, MethodInfo src, Span<byte> dst)
            => Capture(id,src, CaptureExchange.Define(dst));
 
        CapturedMember Capture(MethodInfo src, Type[] args, Span<byte> dst)
            => Capture(src.CloseGenericMethod(args), dst);

        void Capture(Delegate src, INativeWriter dst) 
            => dst.WriteData(Capture(src.Identify(), src, dst.TakeBuffer()));           

        void Capture(MethodInfo src, INativeWriter dst)
            => dst.WriteData(Capture(src.Identify(), src,dst.TakeBuffer()));
    }
}