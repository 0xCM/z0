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
    public sealed class DecodeApiHost : WfHost<DecodeApiHost,ApiMemberCodeBlocks, AsmRoutines>
    {
        IAsmDecoder Decoder;

        ApiHostUri Uri;

        public static DecodeApiHost create(IAsmDecoder decoder, ApiHostUri uri)
        {
            var dst = create();
            dst.Decoder = decoder;
            dst.Uri = uri;
            return dst;
        }

        protected override ref AsmRoutines Execute(IWfShell wf, in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var step = new DecodeApiHostStep(wf, this, Decoder);
            dst = step.Run(Uri, src);
            return ref dst;
        }
    }

    readonly ref struct DecodeApiHostStep
    {
        public IWfShell Wf {get;}

        readonly WfHost Host;

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        internal DecodeApiHostStep(IWfShell wf, WfHost host, IAsmDecoder decoder)
        {
            Wf = wf;
            Host = host;
            Decoder = decoder;
            Wf.Created(Host);
        }

        public AsmRoutine[] Run(ApiHostUri uri, ApiMemberCodeBlocks src)
        {
            try
            {
                Wf.Running(Host, uri);
                var count = src.Count;
                var view = src.View;
                var dst = alloc<AsmRoutine>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var member = ref skip(view,i);
                    var decoded = Decoder.Decode(member);
                    if(!decoded)
                        HandleFailure(member);

                    dst[i] = decoded ? decoded.Value : AsmRoutine.Empty;
                }

                Wf.Raise(new FunctionsDecoded(Host, uri, dst, Wf.Ct));
                return dst;
            }
            catch(Exception e)
            {
                Wf.Error(Host, $"{uri}: {e}");
                return sys.empty<AsmRoutine>();
            }
        }

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