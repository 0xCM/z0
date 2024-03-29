//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using static Asm.AsmSpecs;
    using static MemorySections;

    [ApiComplete]
    public sealed class ByteMachine
    {
        Section Buffer;

        uint Pos;

        uint Max;

        public ByteMachine(in Section bss)
        {
            Buffer = bss;
            Pos = 0;
            Max = Buffer.TotalSize - 1;
            Fill(int3());
        }

        [MethodImpl(Inline)]
        public bit Deposit(byte src)
        {
            if(Pos < Max)
            {
                Cell(Pos++) = src;
                return true;
            }
            else
                return false;
        }

        [MethodImpl(Inline)]
        public void Reset()
        {
            Fill(int3());
        }

        [MethodImpl(Inline)]
        public uint Accepted(Span<byte> dst)
        {
            var max = Capacity;
            var j=0u;
            for(var i=0u; i<max; i++)
            {
                ref readonly var input = ref Cell(i);
                if(!int3(input))
                    seek(dst,j++) = input;
                else
                    break;
            }
            return j;
        }

        [MethodImpl(Inline)]
        Span<byte> Segment(uint index)
            => Buffer.Segment(index);

        uint Capacity
        {
            [MethodImpl(Inline)]
            get => Buffer.Capacity().TotalSize;
        }

        Span<byte> Cells
        {
            [MethodImpl(Inline)]
            get => Buffer.Storage();
        }

        [MethodImpl(Inline)]
        ref byte Cell(uint index)
            => ref MemorySections.cell(Buffer, index);

        [MethodImpl(Inline)]
        void Fill(byte src)
        {
            var count = Buffer.CellCount;
            for(var i=0u; i<count; i++)
                Cell(i) = src;
        }

        [MethodImpl(Inline)]
        void ExtractToken(ReadOnlySpan<byte> src, out CharBlock16 dst)
        {
            dst = CharBlock16.Null;
            var count = min(src.Length, 16);
            ref var target = ref u16(dst);

            for(var i=0; i<count; i++)
                seek(target,i) = (char)skip(src,i);
        }
   }
}