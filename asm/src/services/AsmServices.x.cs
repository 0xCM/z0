//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using AsmSpecs;

    using static zfunc;

    public static partial class AsmExtend
    {
        public static IAsmCodeIndex ToCodeIndex(this IEnumerable<AsmCode> code, bool generic)
            => AsmCodeIndex.Create(code,generic);

        static IEnumerable<AsmInstructionList> GetInstructions(IAsmCodeArchive archive)
        {            
            var decoder = archive.Context.Decoder();
            foreach(var codeblock in archive.Read())
                yield return decoder.DecodeInstructions(codeblock);                
        }

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive)
            => AsmInstructionSource.FromProducer(() => GetInstructions(archive));

        static ICaptureOps CaptureOps => CaptureServices.Operations;

        public static AsmFunction DecodeFunction(this IAsmDecoder decoder, in CaptureExchange exchange, OpIdentity id, MethodInfo src)
            => decoder.DecodeFunction(CaptureOps.Capture(in exchange, id, src));

        public static AsmFunction DecodeFunction(this IAsmDecoder decoder, in CaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => decoder.DecodeFunction(CaptureOps.Capture(in exchange, id, src));

        public static AsmFunction DecodeFunction(this IAsmDecoder decoder, in CaptureExchange exchange, OpIdentity id, Delegate src)
            => decoder.DecodeFunction(CaptureOps.Capture(in exchange, id, src));

        public static R Eval<X0,X1,R>(this IAsmExecBuffer buffer, AsmCode src, X0 x0, X1 x1, R r = default)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed         
                => buffer.F<X0,X1,R>(src)(x0,x1);
    }
}