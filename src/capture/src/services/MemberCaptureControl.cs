//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct MemberCaptureControl : IMemberCaptureControl
    {                    
        readonly ICaptureService Service;
        
        [MethodImpl(Inline)]
        public static IMemberCaptureControl Create(IContext context, ICaptureService capture)
            => new MemberCaptureControl(context, capture);
                    
        [MethodImpl(Inline)]
        MemberCaptureControl(IContext context, ICaptureService capture)
        {
            this.Service = capture;
        }

        [MethodImpl(Inline)]
        public Option<ApiMemberCapture> Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Service.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public Option<ApiMemberCapture> Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src)
            => Service.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public Option<ApiMemberCapture> Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src)
            => Service.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<ParsedBuffer> ParseBuffer(in CaptureExchange exchange, in OpIdentity id, Span<byte> src)
            => Service.ParseBuffer(exchange, id, src);

        [MethodImpl(Inline)]
        public Option<ApiMemberCapture> Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
            => Service.Capture(exchange, src, args);

        [MethodImpl(Inline)]
        void ICaptureJunction.OnCaptureStep(in CaptureExchange exchange, in ApiExtractState state)
        {

        }

        [MethodImpl(Inline)]
        void ICaptureJunction.OnCaptureComplete(in CaptureExchange exchange, in ApiExtractState state, in ApiMemberCapture captured)
        {}

    }
}