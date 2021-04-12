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
    using static memory;
    using static Z0.Asm.AsmRegOps;

    public readonly struct EntryPoint
    {
        public MemoryRange Location {get;}

        [MethodImpl(Inline)]
        public EntryPoint(MemoryRange address)
        {
            Location = address;
        }

        [MethodImpl(Inline)]
        public static implicit operator EntryPoint(MemoryRange src)
            => new EntryPoint(src);
    }

    public struct EntryPoint<T>
        where T : unmanaged
    {

        public MemoryRange Location {get; private set;}

        [MethodImpl(NotInline)]
        ulong Jump(T a0)
            => root.timestamp();

        public MemoryRange Init()
        {
            Jump(default);
            var @base = ApiJit.jit(GetType().Method(nameof(Jump)));
            var size = 16ul;
            var liberated = memory.liberate(@base,size);
            if(liberated.IsNonZero)
                Location = (@base, @base + size);
            return Location;
        }
    }

    public class EntryPoints : WfService<EntryPoints>
    {
        Index<EntryPoint> Trampolines;

        Index<Cell128> Payloads;

        Index<MemoryAddress> Receivers;

        const uint SlotCount = 256;

        public EntryPoints()
        {
            Trampolines = alloc<EntryPoint>(SlotCount);
            Payloads = alloc<Cell128>(SlotCount);
            Receivers = alloc<MemoryAddress>(SlotCount);
            Receivers[0] = ApiJit.jit(GetType().Method(nameof(Receive64u)));
        }

        public bool Create<T>(byte slot)
            where T : unmanaged
        {
             var ep = new EntryPoint<T>();
            Trampolines[slot] = ep.Init();
            return Trampolines[slot].Location.IsNonEmpty;
        }

        void Receive64u(ulong a0)
        {
            Wf.Status($"Received {a0}");
        }

        [Op]
        public ref readonly Cell128 EncodeDispatch(byte slot, MemoryAddress target)
        {
            var address = Trampolines[slot].Location;
            ref var payload = ref Payloads[slot];
            var mov = AsmEncoder.mov(rcx, asm.imm64(target)).Content.Bytes;
            var jmp = AsmEncoder.jmp(rcx).Content.Bytes;
            var dst = payload.Bytes;
            var j=0;
            for(var i=0; i< mov.Length; i++)
                seek(dst,j++) = skip(mov,i);
            for(var i=0; i< jmp.Length; i++)
                seek(dst,j++) = skip(jmp,i);
            return ref payload;
        }

        [Op]
        public ref readonly Cell128 EncodeDispatch(byte slot)
            => ref EncodeDispatch(slot, Receivers[slot]);
    }
}