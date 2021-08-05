//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiComplete]
    public sealed class ByteMachine
    {
        BssEntry Buffer;

        uint Pos;

        uint Max;

        public ByteMachine(in BssEntry bss)
        {
            Buffer = bss;
            Pos = 0;
            Max = Buffer.TotalSize - 1;
            Fill(0xFF);
        }

        [MethodImpl(Inline)]
        public bit Accept(byte src)
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
            Fill(0xFF);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> State()
            => Cells;

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
            =>  ref Bss.cell(Buffer, index);

        [MethodImpl(Inline)]
        void Fill(byte src)
        {
            var count = Buffer.CellCount;
            for(var i=0u; i<count; i++)
                Cell(i) = src;
        }
    }
}