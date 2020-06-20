//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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

        public AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] src)
        {   
            try
            {             
                var dst = Root.alloc<AsmFunction>(src.Length);
                for(var i=0; i<src.Length; i++)
                {
                    var member = src[i];
                    var decoded = Context.Decoder.Decode(member);
                    if(!decoded)
                        HandleUndecoded(member);
                    
                    dst[i] = decoded ? decoded.Value : AsmFunction.Empty;                
                }

                Context.Raise(new FunctionsDecoded(host, dst));
                return dst;
            }
            catch(Exception e)
            {
                term.errlabel(e,$"{host} decoding failed");
                return Array.Empty<AsmFunction>();
            }
        }

        public void SaveDecoded(AsmFunction[] src, FilePath dst)
        {
            using var writer = Context.WriterFactory(dst, Context.Formatter);                
            writer.WriteAsm(src);
        }

        void HandleUndecoded(in ParsedMember member)
        {
            term.error($"Could not decode {member.Id}");
        }        
    }
}