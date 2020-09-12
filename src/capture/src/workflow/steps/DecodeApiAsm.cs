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

        ICaptureContext Capture {get;}

        [MethodImpl(Inline)]
        internal DecodeApiAsm(IWfShell wf, ICaptureContext capture, CorrelationToken ct)
        {
            Wf = wf;
            Capture = capture;
            Wf.Created(StepId);
        }

        public AsmRoutine[] Run(ApiHostUri host, X86ApiMembers src)
        {
            try
            {
                var count = src.Count;
                Wf.Running(StepId, host);
                var view = src.View;
                var dst = z.alloc<AsmRoutine>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var member = ref z.skip(view,i);
                    var decoded = Capture.Decoder.Decode(member);
                    if(!decoded)
                        HandleFailure(member);

                    dst[i] = decoded ? decoded.Value : AsmRoutine.Empty;
                }

                Wf.Raise(new FunctionsDecoded(StepId, host, dst, Wf.Ct));
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

        void HandleFailure(in X86ApiMember member)
        {
            Wf.Error(StepId, $"Could not decode {member}");
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }
    }
}