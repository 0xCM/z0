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

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        internal ApiHostDecoder(IWfShell wf, IAsmDecoder decoder)
        {
            Wf = wf;
            Decoder = decoder;
        }

        public AsmMemberRoutines Decode(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            try
            {
                var flow = Wf.Running(uri);
                var count = src.Length;
                var dst = alloc<AsmMemberRoutine>(count);
                for(var i=0; i<count; i++)
                {
                    ref readonly var code = ref skip(src, i);
                    var decoded = Decoder.Decode(code);
                    if(!decoded)
                        HandleFailure(code);

                    dst[i] = decoded ? new AsmMemberRoutine(code.Member, decoded.Value) : AsmMemberRoutine.Empty;
                }

                Wf.Ran(flow, string.Format("Decoded {0} {1} functions", dst.Length, uri));
                return dst;
            }
            catch(Exception e)
            {
                Wf.Error($"{uri}: {e}");
                return sys.empty<AsmMemberRoutine>();
            }
        }

        void HandleFailure(in ApiMemberCode member)
        {
            Wf.Error($"Could not decode {member}");
        }
    }
}