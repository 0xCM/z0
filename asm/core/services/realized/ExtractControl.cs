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

    readonly struct ExtractControl : IExtractControl
    {                    
        readonly IContext Context;

        readonly ICaptureService Service;
        
        [MethodImpl(Inline)]
        public static IExtractControl New(IContext context)
            => new ExtractControl(context);
                    
        [MethodImpl(Inline)]
        ExtractControl(IContext context)
        {
            this.Context = context;
            this.Service = CaptureService.New(context);
        }

        [MethodImpl(Inline)]
        public Option<CapturedOp> Capture(in OpExtractExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Service.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, Delegate src)
            => Service.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public Option<CapturedOp> Capture(in OpExtractExchange exchange, in OpIdentity id, MethodInfo src)
            => Service.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<ParsedBuffer> ParseBuffer(in OpExtractExchange exchange, in OpIdentity id, Span<byte> src)
            => Service.ParseBuffer(exchange, id, src);

        [MethodImpl(Inline)]
        public Option<CapturedOp> Capture(in OpExtractExchange exchange, MethodInfo src, params Type[] args)
            => Service.Capture(exchange, src, args);

        [MethodImpl(Inline)]
        void IExtractJunction.OnCaptureStep(in OpExtractExchange exchange, in ExtractState state)
        {

        }

        [MethodImpl(Inline)]
        void IExtractJunction.OnCaptureComplete(in OpExtractExchange exchange, in ExtractState state, in CapturedOp captured)
        {}

    }
}