//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ApiHostDecoder
    {
        public IWfShell Wf {get;}

        readonly WfHost Host;

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        internal ApiHostDecoder(IWfShell wf, IAsmDecoder decoder)
        {
            Host = WfSelfHost.create();
            Wf = wf.WithHost(Host);
            Decoder = decoder;
        }

        public AsmRoutine[] Decode(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            try
            {
                Wf.Running(Host, uri);
                var count = src.Length;
                var dst = alloc<AsmRoutine>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var member = ref skip(src, i);
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
    }
}