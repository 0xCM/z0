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

    public readonly struct DecodedParsedStep : IDecodeStep
    {            
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;
        
        [MethodImpl(Inline)]
        internal DecodedParsedStep(ICaptureWorkflow workfow)
        {
            Workflow = workfow;
        }

        public AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] parsed)
        {   
            try
            {             
                var functions = DecodeExtracts(parsed);
                Context.Raise(new FunctionsDecoded(host, functions));
                return functions;
            }
            catch(Exception e)
            {
                term.errlabel(e,$"{host} decoding failed");
                return Array.Empty<AsmFunction>();
            }
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