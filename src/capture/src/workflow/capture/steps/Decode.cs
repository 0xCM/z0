//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CaptureWorkflowEvents;

    partial class HostCaptureSteps
    {
        public readonly struct DecodeStep : IDecodeStep
        {            
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;
            
            [MethodImpl(Inline)]
            internal DecodeStep(ICaptureWorkflow workfow)
            {
                Workflow = workfow;
            }

            public AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] parsed)
            {                
                var functions = DecodeExtracts(parsed);
                Context.Raise(FunctionsDecoded.Define(host, functions));
                return functions;
            }

            public void SaveDecoded(AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.WriterFactory(dst,Context.Formatter);                
                writer.WriteAsm(src);
            }

            public AsmFunction[] DecodeExtracts(params ParsedMember[] src)
            {
                var dst = Control.alloc<AsmFunction>(src.Length);
                for(var i=0; i<src.Length; i++)
                {
                    var parsed = src[i];
                    var decoded = Context.Decoder.Decode(parsed).OnNone(() => term.error($"Parse failure for {parsed.Id}"));
                    dst[i] = decoded ? decoded.Value : AsmFunction.Empty;                
                }
                return dst;
            }
        }
    }
}