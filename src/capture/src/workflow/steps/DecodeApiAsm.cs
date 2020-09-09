//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static DecodeApiAsmStep;

    public readonly ref struct DecodeApiAsm
    {
        public IWfShell Wf {get;}

        readonly CorrelationToken Ct;

        ICaptureContext Capture {get;}

        [MethodImpl(Inline)]
        internal DecodeApiAsm(IWfShell wf, ICaptureContext capture, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Capture = capture;
            Wf.Created(StepId);
        }

        public AsmRoutine[] Run(ApiHostUri host, X86MemberRefinement[] src)
        {
            try
            {
                Wf.Running(StepId, host);
                var dst = z.alloc<AsmRoutine>(src.Length);
                for(var i=0; i<src.Length; i++)
                {
                    var member = src[i];
                    var decoded = Capture.Decoder.Decode(member);
                    if(!decoded)
                        HandleFailure(member);

                    dst[i] = decoded ? decoded.Value : AsmRoutine.Empty;
                }

                Wf.Raise(new FunctionsDecoded(StepId, host, dst, Ct));
                return dst;
            }
            catch(Exception e)
            {
                Wf.Error(StepId, $"{host}: {e}");
                return sys.empty<AsmRoutine>();
            }
        }

        public void SaveDecoded(AsmRoutine[] src, FilePath dst)
        {
            using var writer = Capture.WriterFactory(dst, Capture.Formatter);
            writer.WriteAsm(src);
        }

        void HandleFailure(in X86MemberRefinement member)
        {
            Wf.Error(StepId, $"Could not decode {member}");
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }
    }
}