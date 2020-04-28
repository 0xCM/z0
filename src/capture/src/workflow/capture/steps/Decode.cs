//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CaptureWorkflowEvents;

    partial class HostCaptureSteps
    {
        public readonly struct DecodeStep : IDecodeStep
        {
            readonly CaptureWorkflowContext Context;
            
            [MethodImpl(Inline)]
            internal DecodeStep(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            public AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMemberExtract[] parsed)
            {                
                var functions = DecodeExtracts(parsed);
                Context.Raise(HostFunctionsDecoded.Define(host, functions));
                return functions;
            }

            public void SaveDecoded(AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.WriterFactory(dst,Context.Formatter);                
                writer.WriteAsm(src);
            }

            public AsmFunction[] DecodeExtracts(params ParsedMemberExtract[] src)
            {
                var dst = new AsmFunction[src.Length];
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