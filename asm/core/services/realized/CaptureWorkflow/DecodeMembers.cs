//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct DecodeMembers
        {
            readonly HostCaptureContext Context;

            readonly IAsmFunctionDecoder Decoder;

            readonly IAsmFormatter Formatter;


            [MethodImpl(Inline)]
            internal static DecodeMembers Create(HostCaptureContext context)
                => new DecodeMembers(context);
            
            [MethodImpl(Inline)]
            DecodeMembers(HostCaptureContext context)
            {
                this.Context = context;
                this.Decoder = context.Decoder;
                this.Formatter = context.Formatter;
            }

            public AsmFunction[] DecodeParsed(in ApiHost host, ParsedExtract[] parsed)
            {                
                var functions = Decoder.Decode(parsed);
                Context.Raise(HostFunctionsDecoded.Define(host, functions));
                return functions;
            }

            public void SaveDecoded(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.WriterFactory(dst,Formatter);                
                writer.Write(src);
            }
        }
    }
}
