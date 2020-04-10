//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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

            public AsmFunction[] DecodeParsed(in ApiHost host, ParsedExtract[] parsed)
            {                
                var functions = Context.Decoder.Decode(parsed);
                Context.Raise(HostFunctionsDecoded.Define(host, functions));
                return functions;
            }

            public void SaveDecoded(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.WriterFactory(dst,Context.Formatter);                
                writer.Write(src);
            }
        }
    }
}