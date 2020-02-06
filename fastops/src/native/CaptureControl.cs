//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public interface ICaptureJunction
    {
        void Accept(in CaptureState state, in CaptureExchange exchange);   
    }

    public interface ICaptureControl : ICaptureJunction, ICaptureStateSink
    {
        CapturedMember RunCapture(MethodInfo method, in CaptureExchange exchange);   
    }

    readonly struct CaptureControl : ICaptureControl
    {
        readonly IMemberCapture Service;
                    
        readonly Option<ICaptureStateSink> ExternalSink;

        ICaptureStateSink ControlSink
        {
            [MethodImpl(Inline)]
            get => this;
        }

        public static CaptureControl Create()
            => new CaptureControl(null);            

        public static CaptureControl Create(ICaptureStateSink sink)
            =>  new CaptureControl(sink);            

        [MethodImpl(Inline)]
        public CaptureControl(ICaptureStateSink sink)
        {
            Service = NativeServices.MemberCapture();
            ExternalSink = sink != null ? some(sink) : default;
        }

        [MethodImpl(Inline)]
        public void Accept(in CaptureState src, in CaptureExchange exchange)
        {
            ControlSink.Accept(in src);
        }

        public CapturedMember RunCapture(MethodInfo method, in CaptureExchange exchange)
        {            
            return Service.Capture(method.Identify(), method, exchange);                                    
        }

        [MethodImpl(Inline)]
        void IPointSink<CaptureState>.Accept(in CaptureState src)
        {
            ExternalSink.Value?.Accept(src);            
        }
    }
}