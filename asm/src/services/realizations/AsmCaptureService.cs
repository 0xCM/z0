//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    
    using Z0.AsmSpecs;
    
    using static zfunc;
    

    readonly struct AsmCaptureService : IAsmCaptureService
    {
        readonly byte[] buffer; 

        public IAsmContext Context {get;}

        public static IAsmCaptureService Create(IAsmContext context, int? buffersize = null)
            => new AsmCaptureService(context, buffersize);

        public static IAsmCaptureService Create(IAsmContext context, byte[] buffer)
            => new AsmCaptureService(context, buffer);

        AsmCaptureService(IAsmContext context, byte[] buffer)
        {
            Context = context;
            this.buffer = buffer;
        }

        AsmCaptureService(IAsmContext context, int? buffersize)
        {
            Context = context;
            buffer = new byte[buffersize ?? NativeServices.DefaultBufferLen];
        }

        Span<byte> TakeBuffer()
        {
            buffer.Clear();
            return buffer;
        }   

        IAsmDecoder Decoder => Context.Decoder();        

        public CapturedMember ExtractBits(OpIdentity id, DynamicDelegate src)
            => NativeReader.read(id,src,TakeBuffer());

        public CapturedMember ExtractBits(OpIdentity id, MethodInfo src)
            => NativeReader.read(id, src, TakeBuffer());

        public CapturedMember ExtractBits(OpIdentity id, Delegate src)
            => NativeReader.read(id, src, TakeBuffer());

        public CapturedMember ExtractBits(Delegate src)
            => ExtractBits(src.Identify(), src);

        public CapturedMember ExtractBits(MethodInfo src, params Type[] args)
            => src.IsOpenGeneric() ? CaptureBits(src.Reify(args)) : CaptureBits(src);

        public CapturedMember[] ExtractBits(MethodInfo[] methods)
        {
            var targets = new CapturedMember[methods.Length];
            for(var i = 0; i<methods.Length; i++)
            {
                var m = methods[i];
                targets[i] = NativeReader.read(m.Identify(), m, TakeBuffer()).Replicate();                                 
                ExtractBits(m);
            }
            return targets;
        }

        public AsmFunction ExtractAsm(Delegate src)
            => Decoder.DecodeFunction(ExtractBits(src));

        public AsmFunction ExtractAsm(MethodInfo src)
            => Decoder.DecodeFunction(CaptureBits(src));

        public AsmFunction ExtractAsm(MethodInfo src, params Type[] args)
            => Decoder.DecodeFunction(ExtractBits(src,args));

        public AsmFunction[] ExtractAsm(MethodInfo[] src, params Type[] args)
        {
            var dst = new AsmFunction[src.Length];            
            for(var i=0; i<dst.Length; i++)
                dst[i] = ExtractAsm(src[i],args);
            return dst;                
        }

        public void SaveBits(MethodInfo src, IAsmHexWriter dst)
            => dst.Write(NativeReader.read(src.Identify(), src, TakeBuffer()));

        public void SaveBits(MethodInfo src, Type[] args, IAsmHexWriter dst)
            => dst.Write(ExtractBits(src,args));

        public void SaveBits(MethodInfo[] methods, IAsmHexWriter dst)
            => dst.Write(ExtractBits(methods));
        public void SaveBits(Delegate src, IAsmHexWriter dst)
            => dst.Write(ExtractBits(src));    

        public void SaveAsm(Delegate src, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(src));

        public void SaveAsm(MethodInfo src, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(src));

        public void SaveAsm(MethodInfo src, Type[] args, IAsmFunctionWriter dst)
            => dst.Write(ExtractAsm(src,args));
        
        public void SaveAsm(MethodInfo[] src, IAsmFunctionWriter dst)
            => iter(ExtractAsm(src),dst.Write);

        public void SaveAsm(MethodInfo[] src, Type[] args, IAsmFunctionWriter dst)
            => iter(ExtractAsm(src,args),dst.Write);
                
        CapturedMember CaptureBits(MethodInfo m)
            => NativeReader.read(m.Identify(), m, TakeBuffer()); 
    }
}