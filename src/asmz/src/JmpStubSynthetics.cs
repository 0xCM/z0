//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static Root;
    using static core;
    using static Z0.Asm.AsmRegOps;

    public class JmpStubSynthetics : AppService<JmpStubSynthetics>
    {
        Index<MemoryRange> Trampolines;

        Index<Cell128> Payloads;

        Index<MemoryAddress> Receivers;

        const uint SlotCount = 256;

        public JmpStubSynthetics()
        {
            Trampolines = alloc<MemoryRange>(SlotCount);
            Payloads = alloc<Cell128>(SlotCount);
            Receivers = alloc<MemoryAddress>(SlotCount);
            Receivers[0] = ApiJit.jit(GetType().Method(nameof(Receive64u)));
        }

        public bool Create<T>(byte slot)
            where T : unmanaged
        {
             var ep = new JmpStubSynthetic<T>();
            Trampolines[slot] = ep.Init();
            return Trampolines[slot].IsNonEmpty;
        }

        void Receive64u(ulong a0)
        {
            Wf.Status($"Received {a0}");
        }

        [Op]
        public ref readonly Cell128 EncodeDispatch(byte slot, MemoryAddress target)
        {
            var address = Trampolines[slot];
            ref var payload = ref Payloads[slot];
            var mov = AsmEncoderPrototype.mov(rcx, target).Content.Bytes;
            //var jmp = AsmEncoderPrototype.jmp(rcx).Content.Bytes;
            var dst = payload.Bytes;
            var j=0;
            for(var i=0; i< mov.Length; i++)
                seek(dst,j++) = skip(mov,i);
            // for(var i=0; i< jmp.Length; i++)
            //     seek(dst,j++) = skip(jmp,i);
            return ref payload;
        }

        [Op]
        public ref readonly Cell128 EncodeDispatch(byte slot)
            => ref EncodeDispatch(slot, Receivers[slot]);
    }
}