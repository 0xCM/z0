//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static DecodeParsedStep;
    
    [Step(Kind)]
    public readonly ref struct DecodeParsed
    {            
        public WfState Wf {get;}

        readonly CorrelationToken Ct;

        ICaptureContext Capture {get;}
        
        [MethodImpl(Inline)]
        internal DecodeParsed(WfState wf, ICaptureContext capture, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Capture = capture;
            Wf.Created(Name, Ct);
        }

        public AsmFunction[] Run(ApiHostUri host, ParsedExtraction[] src)
        {   
            try
            {             
                Wf.Running(Name, host, Ct);
                var dst = z.alloc<AsmFunction>(src.Length);
                for(var i=0; i<src.Length; i++)
                {
                    var member = src[i];
                    var decoded = Capture.Decoder.Decode(member);
                    if(!decoded)
                        HandleUndecoded(member);
                    
                    dst[i] = decoded ? decoded.Value : AsmFunction.Empty;                
                }

                Capture.Raise(new FunctionsDecoded(host, dst));
                return dst;
            }
            catch(Exception e)
            {
                Wf.Error(Name, $"{host}: {e}", Ct);
                return sys.empty<AsmFunction>();
            }
        }

        public void SaveDecoded(AsmFunction[] src, FilePath dst)
        {
            using var writer = Capture.WriterFactory(dst, Capture.Formatter);                
            writer.WriteAsm(src);
        }

        void HandleUndecoded(in ParsedExtraction member)
        {
            Wf.Error(Name, $"Could not decode {member}", Ct);
        }        

        public void Dispose()
        {
            Wf.Finished(Name, Ct);
        }
    }
}