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

    public readonly struct MemberCaptureControl : ICaptureControl
    {                    
        readonly ICaptureService Service;
        
        [MethodImpl(Inline)]
        public static ICaptureControl Create(ICaptureService capture)
            => new MemberCaptureControl(capture);
                    
        [MethodImpl(Inline)]
        MemberCaptureControl(ICaptureService capture)
        {
            this.Service = capture;
        }

        [MethodImpl(Inline)]
        public Option<MemberCapture> Capture(in CaptureExchange exchange, OpIdentity id, in DynamicDelegate src)
            => Service.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public Option<MemberCapture> Capture(in CaptureExchange exchange, OpIdentity id, Delegate src)
            => Service.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public Option<MemberCapture> Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
            => Service.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<ParsedOperation> ParseBuffer(in CaptureExchange exchange, OpIdentity id, Span<byte> src)
            => Service.ParseBuffer(exchange, id, src);

        [MethodImpl(Inline)]
        public Option<MemberCapture> Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
            => Service.Capture(exchange, src, args);

        [MethodImpl(Inline)]
        public Option<OperationCapture> Capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)
            => Service.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        void ICaptureJunction.OnCaptureStep(in CaptureExchange exchange, in ExtractState state)
        {

        }

        [MethodImpl(Inline)]
        void ICaptureJunction.OnCaptureComplete(in CaptureExchange exchange, in ExtractState state, in MemberCapture captured)
        {}
    }
}