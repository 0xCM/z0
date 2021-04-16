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

    public class ApiHostDecoder : WfService<ApiHostDecoder>
    {
        IAsmDecoder Decoder;

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
        }

        public AsmHostRoutines Decode(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            try
            {
                var flow = Wf.Running(uri);
                var count = src.Length;
                var buffer = alloc<AsmMemberRoutine>(count);
                ref var dst = ref first(buffer);
                for(var i=0; i<count; i++)
                {
                    ref readonly var code = ref skip(src, i);
                    var decoded = Decoder.Decode(code);
                    if(!decoded)
                        HandleFailure(code);

                    seek(dst, i) = decoded ? new AsmMemberRoutine(code.Member, decoded.Value) : AsmMemberRoutine.Empty;
                }

                Wf.Ran(flow, Msg.DecodedHostMembers.Format(buffer.Length, uri));
                return buffer;
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