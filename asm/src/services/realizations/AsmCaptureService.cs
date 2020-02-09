//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using Z0.AsmSpecs;
    
    using static zfunc;
    
    readonly struct AsmCaptureService : ICaptureService
    {
        public IAsmContext Context {get;}

        readonly ICaptureControl Control;

        public static ICaptureService Create(IAsmContext context, ICaptureControl control)
            => new AsmCaptureService(context, control);

        AsmCaptureService(IAsmContext context, ICaptureControl control)
        {
            Context = context;
            Control = control;            
        }

        IAsmDecoder Decoder => Context.Decoder();                

        public CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => Control.Capture(in exchange, id,src);

        public CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
            => Control.Capture(in exchange, id, src);

        public CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, Delegate src)
            => Control.Capture(in exchange, id, src);

        public CapturedMember ExtractBits(in CaptureExchange exchange, Delegate src)
            => ExtractBits(in exchange, src.Identify(), src);

        public CapturedMember ExtractBits(in CaptureExchange exchange, MethodInfo src, params Type[] args)
            => src.IsOpenGeneric() ? CaptureBits(in exchange, src.Reify(args)) : CaptureBits(in exchange, src);

        public CapturedMember[] ExtractBits(in CaptureExchange exchange, MethodInfo[] methods)
        {
            var targets = new CapturedMember[methods.Length];
            for(var i = 0; i<methods.Length; i++)
            {
                var m = methods[i];
                targets[i] = Control.Capture(in exchange, m.Identify(), m).Replicate();                                 
                ExtractBits(exchange,m);
            }
            return targets;
        }

        public AsmFunction ExtractAsm(in CaptureExchange exchange, Delegate src)
            => Decoder.DecodeFunction(ExtractBits(exchange, src));

        public AsmFunction ExtractAsm(in CaptureExchange exchange, MethodInfo src)
            => Decoder.DecodeFunction(CaptureBits(exchange, src));

        public AsmFunction ExtractAsm(in CaptureExchange exchange, MethodInfo src, params Type[] args)
            => Decoder.DecodeFunction(ExtractBits(exchange, src,args));

        public AsmFunction[] ExtractAsm(in CaptureExchange exchange, MethodInfo[] src)
        {
            var dst = new AsmFunction[src.Length];            
            for(var i=0; i<dst.Length; i++)
                dst[i] = ExtractAsm(exchange, src[i]);
            return dst;                
        }

        public void CaptureBits(in CaptureExchange exchange, MethodInfo src, IAsmCodeWriter dst)
            => dst.Write(Control.Capture(in exchange, src.Identify(), src).Code);

        public void CaptureBits(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmCodeWriter dst)
            => dst.Write(ExtractBits(exchange, src,args).Code);

        public void CaptureBits(in CaptureExchange exchange, MethodInfo[] methods, IAsmCodeWriter dst)
            => dst.Write(ExtractBits(exchange, methods).Map(x => x.Code));
            
        public void CaptureBits(in CaptureExchange exchange, Delegate src, IAsmCodeWriter dst)
            => dst.Write(ExtractBits(exchange, src).Code);    

        public void CaptureAsm(in CaptureExchange exchange, Delegate src, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(exchange, src));

        public void CaptureAsm(in CaptureExchange exchange,MethodInfo src, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(exchange, src));

        public void CaptureAsm(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(exchange, src,args));
        
        public void CaptureAsm(in CaptureExchange exchange, MethodInfo[] src, IAsmFunctionWriter dst)
            => iter(ExtractAsm(exchange, src),dst.Write);
                
        CapturedMember CaptureBits(in CaptureExchange exchange, MethodInfo m)
            => Control.Capture(in exchange, m.Identify(), m); 
    }
}