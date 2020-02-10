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

    /// <summary>
    /// Accepts and then relays emission groups to a specified receiver
    /// </summary>
    readonly struct CaptureTokenSink : ICaptureTokenSink
    {
        readonly Action<CaptureTokenGroup> Receiver;        
                
        [MethodImpl(Inline)]
        public static ICaptureTokenSink Create(Action<CaptureTokenGroup> receiver)
            => new CaptureTokenSink(receiver);
        
        [MethodImpl(Inline)]
        CaptureTokenSink(Action<CaptureTokenGroup> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in CaptureTokenGroup src)
            => Receiver(src);
    }
}