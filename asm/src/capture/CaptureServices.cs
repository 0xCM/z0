//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;        

    using static zfunc;

    public static class CaptureServices
    {
        public const int DefaultBufferLen = 1024*8;
        
        public static ICaptureOps Operations
        {
            [MethodImpl(Inline)]
            get => default(CaptureOps);
        }

        public static CaptureExchange Exchange(CaptureEventObserver observer, int? size = null)
        {
            var control = CaptureControl.Create(observer);
            var cBuffer = new byte[size ?? CaptureServices.DefaultBufferLen];
            var sBuffer = new byte[size ?? CaptureServices.DefaultBufferLen];
            return CaptureExchange.Define(control, cBuffer, sBuffer);
        }        
    }
}