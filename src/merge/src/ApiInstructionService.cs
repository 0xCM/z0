//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static z;

    [WfService]
    public struct ApiInstructionService : IWfService<ApiInstructionService,ApiInstructionService>
    {
        IWfShell Wf;

        [MethodImpl(Inline)]
        ApiInstructionService(IWfShell wf)
            => Wf = wf;

        [MethodImpl(Inline)]
        public static ApiInstructionService create(IWfShell wf)
            => new ApiInstructionService();

        ApiRoutineObsolete Load(MemoryAddress @base, ApiCodeBlock code, Instruction[] src)
            => new ApiRoutineObsolete(@base, Load(code, src));

        ApiInstruction[] Load(ApiCodeBlock code, Instruction[] src)
        {
            var @base = code.Base;
            var offseq = OffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var len = fx.ByteLength;
                var data = span(code.Storage);
                var slice = data.Slice((int)offseq.Offset, len).ToArray();
                var recoded = new ApiCodeBlock(code.Uri, fx.IP, slice);
                dst[i] = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return dst;
        }

        public ApiHostRoutines Decode(IAsmDecoder decoder, in ApiHostCodeBlocks src)
        {
            var instructions = list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Empty;
            var target = list<Instruction>();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref src[i];
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = target[0].IP;

                instructions.Add(Load(ip, block, target.ToArray()));
            }

            return new ApiHostRoutines(src.Host, instructions.ToArray());
        }

        [MethodImpl(Inline)]
        public void Init(IWfShell wf)
        {
            Wf = wf;
        }
    }
}