//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Correlates a sequence of native buffers with a 0-based/monotonic integral sequence
    /// </summary>
    public class AddressMap
    {
        public static AddressMap cover(NativeBufferSeq segs)
            => new AddressMap(segs);

        NativeBufferSeq Segs;

        MemoryAddress BaseAddress;

        AddressMap(NativeBufferSeq segs)
        {
            Segs = segs;
            BaseAddress = segs[0].Address;
        }

        public uint SegCount
        {
            [MethodImpl(Inline)]
            get => Segs.BufferCount;
        }

        /// <summary>
        /// Computes the unsigned distance between the base addresses of index-identified segments
        /// </summary>
        /// <param name="i0">The first segment index</param>
        /// <param name="i1">The second segment index</param>
        [MethodImpl(Inline)]
        public ulong Distance(uint i0, uint i1)
            => i0 > i1 ? (ulong)Base(i0) - (ulong)Base(i1) : (ulong)Base(i1) - (ulong)Base(i0);

        [MethodImpl(Inline)]
        public MemoryAddress Base(uint i)
            => Segs[i].Address;

        [MethodImpl(Inline)]
        public MemoryAddress Address(uint i0, Disp32 disp)
            => Base(i0) + disp.Value;

        [MethodImpl(Inline)]
        public MemorySeg Seg(uint i)
        {
            ref readonly var buffer = ref Segs[i];
            var size = buffer.Size;
            var address = buffer.Address;
            var seg = MemorySegs.define(address, size);
            return seg;
        }

        public void Describe(ITextBuffer dst)
        {
            for(var i=0u; i<SegCount; i++)
            {
                ref readonly var buffer = ref Segs[i];
                var seg = Seg(i);
                var fmt = string.Format("[{0}][{1}:{2}]", i, seg.Size, seg.Range);
                if(i != SegCount - 1)
                    dst.AppendLine(fmt);
                else
                    dst.Append(fmt);
            }
        }
    }
}