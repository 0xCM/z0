//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmEvents;

    partial class HostCaptureSteps
    {
        public readonly struct DecodeMembers
        {
            readonly CaptureWorkflowContext Context;

            [MethodImpl(Inline)]
            internal static DecodeMembers Create(CaptureWorkflowContext context)
                => new DecodeMembers(context);
            
            [MethodImpl(Inline)]
            DecodeMembers(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            public AsmFunction[] DecodeParsed(ApiHostUri host, ParsedExtract[] parsed)
            {                
                var functions = DecodeExtracts(parsed);
                Context.Raise(HostFunctionsDecoded.Define(host, functions));
                return functions;
            }

            public void SaveDecoded(AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.WriterFactory(dst,Context.Formatter);                
                writer.Write(src);
            }

            AsmFunction[] DecodeExtracts(params ParsedExtract[] src)
            {
                var dst = new AsmFunction[src.Length];
                for(var i=0; i<src.Length; i++)
                {
                    var parsed = src[i];
                    var decoded = Context.Decoder.DecodeExtract(parsed).OnNone(() => term.error($"Parse failure for {parsed.Id}"));
                    dst[i] = decoded ? decoded.Value : AsmFunction.Empty;                
                }
                return dst;
            }

        }
    }
}