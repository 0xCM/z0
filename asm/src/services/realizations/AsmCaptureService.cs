//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    using Z0.AsmSpecs;
    
    using static zfunc;
    
    readonly struct AsmCaptureService : IAsmCaptureService
    {
        public IAsmContext Context {get;}

        public static IAsmCaptureService Create(IAsmContext context)
            => new AsmCaptureService(context);

        AsmCaptureService(IAsmContext context)
        {
            Context = context;
        }

        IAsmDecoder Decoder => Context.Decoder();        

        ICaptureOps Operations => CaptureServices.Operations;

        public CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => Operations.Capture(in exchange, id,src);

        public CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
            => Operations.Capture(in exchange, id, src);

        public CapturedMember ExtractBits(in CaptureExchange exchange, OpIdentity id, Delegate src)
            => Operations.Capture(in exchange, id, src);

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
                targets[i] = Operations.Capture(in exchange, m.Identify(), m).Replicate();                                 
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

        public void SaveBits(in CaptureExchange exchange, MethodInfo src, IAsmHexWriter dst)
            => dst.Write(Operations.Capture(in exchange, src.Identify(), src));

        public void SaveBits(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmHexWriter dst)
            => dst.Write(ExtractBits(exchange, src,args));

        public void SaveBits(in CaptureExchange exchange, MethodInfo[] methods, IAsmHexWriter dst)
            => dst.Write(ExtractBits(exchange, methods));

        public void SaveBits(in CaptureExchange exchange, Delegate src, IAsmHexWriter dst)
            => dst.Write(ExtractBits(exchange, src));    

        public void SaveAsm(in CaptureExchange exchange, Delegate src, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(exchange, src));

        public void SaveAsm(in CaptureExchange exchange,MethodInfo src, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(exchange, src));

        public void SaveAsm(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(exchange, src,args));
        
        public void SaveAsm(in CaptureExchange exchange, MethodInfo[] src, IAsmFunctionWriter dst)
            => iter(ExtractAsm(exchange, src),dst.Write);
                
        CapturedMember CaptureBits(in CaptureExchange exchange, MethodInfo m)
            => Operations.Capture(in exchange, m.Identify(), m); 
    }
}