//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;
    
    using static zfunc;

    public readonly struct AsmCaptureFlow
    {    
        AsmCaptureFlow(IAsmContext context, ICaptureOps ops)    
        {
            this.Context = context;
            this.Ops = ops;
        }

        public readonly IAsmContext Context {get;}    

        readonly ICaptureOps Ops;

        IAsmDecoder Decoder => Context.Decoder();          
        
        public void Run(in CaptureExchange exchange, MethodInfo src, IAsmRawWriter rawwriter, IAsmCodeWriter hexwriter, IAsmFunctionWriter asmwriter)
        {
            // var host = src.DeclaringType.HostName();
            // var assembly = src.DeclaringType.Assembly.AssemblyId();
            // var identity = src.Identify();
            // var hexpath = assembly.HexFilePath(host, identity);            
            // var asmpath = assembly.AsmFilePath(host, identity);
            // var cilpath = assembly.CilFilePath(host, identity);
            // var rawpath = assembly.RawFilePath(host, identity);
            // var captured = Ops.Capture(in exchange, identity, src);   
            // var asm = Decoder.Decode(captured);           
        }
    }

    readonly struct AsmCaptureService : ICaptureService
    {
        public IAsmContext Context {get;}

        readonly ICaptureOps Ops;

        public static ICaptureService Create(IAsmContext context, ICaptureOps control)
            => new AsmCaptureService(context, control);

        AsmCaptureService(IAsmContext context, ICaptureOps control)
        {
            Context = context;
            Ops = control;            
        }

        IAsmDecoder Decoder => Context.Decoder();                

        public CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => Ops.Capture(in exchange, id, src);

        public CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
            => Ops.Capture(in exchange, id, src);

        public CapturedMember Capture(in CaptureExchange exchange, OpIdentity id, Delegate src)
            => Ops.Capture(in exchange, id, src);

        public CapturedMember Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
            => Ops.Capture(exchange,src,args);

        public CapturedMember[] Capture(in CaptureExchange exchange, MethodInfo[] methods)
            => Ops.Capture(exchange,methods);

        // AsmFunction ExtractAsm(in CaptureExchange exchange, Delegate src)
        //     => Decoder.Decode(Ops.Capture(exchange, src.Identify(), src));

        // AsmFunction ExtractAsm(in CaptureExchange exchange, MethodInfo src)
        //     => Decoder.Decode(Ops.Capture(exchange, src.Identify(), src));

        // AsmFunction ExtractAsm(in CaptureExchange exchange, MethodInfo src, params Type[] args)
        //     => Decoder.Decode(Capture(exchange, src, args));

        // AsmFunction[] ExtractAsm(in CaptureExchange exchange, MethodInfo[] src)
        // {
        //     var dst = new AsmFunction[src.Length];            
        //     for(var i=0; i<dst.Length; i++)
        //         dst[i] = ExtractAsm(exchange, src[i]);
        //     return dst;                
        // }

        // void CaptureAsm(in CaptureExchange exchange, Delegate src, IAsmFunctionWriter dst)
        //     => dst.Write(ExtractAsm(exchange, src));

        // void CaptureAsm(in CaptureExchange exchange, MethodInfo src, IAsmFunctionWriter dst)
        //     => dst.Write(ExtractAsm(exchange, src));

        // void CaptureAsm(in CaptureExchange exchange, MethodInfo src, Type[] args, IAsmFunctionWriter dst)
        //     => dst.Write(ExtractAsm(exchange, src, args));                        
    }
}