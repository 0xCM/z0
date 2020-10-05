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
    using static z;

    [WfHost]
    public sealed class DecodeApiMembers : WfHost<DecodeApiMembers,ApiMemberCodeBlocks, AsmRoutines>
    {
        ICaptureContext Capture;

        ApiHostUri ApiHost;

        public static DecodeApiMembers create(ICaptureContext capture, ApiHostUri host)
        {
            var dst = create();
            dst.Capture = capture;
            dst.ApiHost = host;
            return dst;
        }

        protected override ref AsmRoutines Execute(IWfShell wf, in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var step = new DecodeApiMembersStep(wf, this, Capture);
            dst = step.Run(ApiHost, src);
            return ref dst;
        }
    }

    readonly ref struct DecodeApiMembersStep
    {
        public IWfShell Wf {get;}

        readonly WfHost Host;

        readonly ICaptureContext Capture;

        [MethodImpl(Inline)]
        internal DecodeApiMembersStep(IWfShell wf, WfHost host, ICaptureContext capture)
        {
            Wf = wf;
            Host = host;
            Capture = capture;
            Wf.Created(Host);
        }

        public AsmRoutine[] Run(ApiHostUri apihost, ApiMemberCodeBlocks src)
        {
            try
            {
                Wf.Running(Host, apihost);
                var count = src.Count;
                var view = src.View;
                var dst = alloc<AsmRoutine>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var member = ref skip(view,i);
                    var decoded = Capture.Decoder.Decode(member);
                    if(!decoded)
                        HandleFailure(member);

                    dst[i] = decoded ? decoded.Value : AsmRoutine.Empty;
                }

                Wf.Raise(new FunctionsDecoded(Host, apihost, dst, Wf.Ct));
                return dst;
            }
            catch(Exception e)
            {
                Wf.Error(Host, $"{apihost}: {e}");
                return sys.empty<AsmRoutine>();
            }
        }

        // public void SaveDecoded(AsmRoutine[] src, FilePath dst)
        // {
        //     using var writer = Capture.AsmWriter(FS.path(dst.Name));
        //     writer.WriteAsm(src);
        // }

        void HandleFailure(in ApiMemberCode member)
        {
            Wf.Error(Host, $"Could not decode {member}");
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}