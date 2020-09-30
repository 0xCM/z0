//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;

    public readonly struct ApiInstructions
    {
        readonly ApiInstruction[] Data;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref ApiInstruction this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref z.first(z.span(Data));
        }

        public ref ApiInstruction this[long i]
        {
            [MethodImpl(Inline)]
            get => ref z.first(z.span(Data));
        }

        public ApiInstruction[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<ApiInstruction> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public static implicit operator ApiInstructions(ApiInstruction[] src)
            => create(src);

        public Outcome<Dictionary<MemoryAddress, ApiInstruction>> deduplicate(ApiInstruction[] src)
        {
            var count = (uint)src.Length;
            var index = new Dictionary<MemoryAddress, ApiInstruction>((int)count);
            var fail = 0;
            var success = 0u;
            var source = sys.span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var located = ref z.skip(source,i);
                if(index.TryAdd(located.IP, located))
                    success++;
                else
                    fail++;
            }

            return (true,index,(ulong)count | (success << 32));
        }

        public static ApiInstructions create(ApiInstruction[] src)
            => new ApiInstructions(src);

        public ApiInstruction[] All
            => Data;

        public IEnumerable<ApiInstruction> Calls
            => from a in All
                let i = a.Instruction
                where i.Mnemonic == Mnemonic.Call
                select a;
        public AspectData<AsmCallInfo>[] CallAspects
            => (from c in CallInfo
                let values = c.AspectValues
                select new AspectData<AsmCallInfo>(c, c.AspectValues.ToArray())).Array();

        public IEnumerable<AsmCallInfo> CallInfo
            => Calls.Select(x => new AsmCallInfo(x)).Where(x => !x.Target.IsEmpty).OrderBy(x => x.TargetOffset);

        [MethodImpl(Inline)]
        internal ApiInstructions(ApiInstruction[] src)
            => Data = src;
    }
}