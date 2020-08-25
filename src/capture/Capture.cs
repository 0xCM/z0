//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    public readonly struct Capture
    {
        public static ICaptureServices Services 
            => default(CaptureServices);
    
        public static AsmDecoderProxy DefaultDecoder
        {
             [MethodImpl(Inline)]
             get => AsmDecoderProxy.Service;
        }
    }
}