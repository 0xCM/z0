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
        readonly CaptureEmissionObserver Observer;        
                
        [MethodImpl(Inline)]
        public static ICaptureTokenSink Create(CaptureEmissionObserver observer)
            => new CaptureTokenSink(observer);
        
        [MethodImpl(Inline)]
        CaptureTokenSink(CaptureEmissionObserver observer)
            => this.Observer = observer;
        
        [MethodImpl(Inline)]
        public void Accept(in CaptureTokenGroup src)
            => Observer(src);
    }
}