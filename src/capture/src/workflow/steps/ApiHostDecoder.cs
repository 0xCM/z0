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

    readonly struct ApiHostDecoder : IDisposable
    {
        public static ApiHostDecoder create(IWfShell wf, IAsmDecoder decoder)
            => new ApiHostDecoder(wf, WfShell.host(typeof(ApiHostDecoder)), decoder);

        public IWfShell Wf {get;}

        readonly WfHost Host;

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        internal ApiHostDecoder(IWfShell wf, WfHost host, IAsmDecoder decoder)
        {
            Wf = wf;
            Host = host;
            Decoder = decoder;
            Wf.Created(Host);
        }

        public AsmRoutine[] Decode(ApiHostUri uri, ApiMemberCodeBlocks src)
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

                Wf.Status(string.Format("Decoded {0} {1} functions", dst.Length, uri));
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