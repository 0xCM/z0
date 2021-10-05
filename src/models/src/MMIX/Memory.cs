//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.MMIX
{
    using System;
    using System.Collections.Generic;

    using static core;

    public class Memory
    {
        List<MemoryRange> Segments;

        int Pos;

        object locker;

        public Memory()
        {
            Segments = new();
            Pos = 0;
            locker = new();
        }

        public MemoryRange Allocate(ByteSize size)
        {
            lock(locker)
            {
                if(Pos < 0)
                {
                    var seg = MemoryRange.define(0, size);
                    Segments.Add(seg);
                    Pos = 0;
                }
                else
                {
                    var last = Segments[Pos];
                    var seg = MemoryRange.define(last.Max + 1, last.Max + size);
                    Segments.Add(seg);
                    Pos++;
                }
            }
            return Segments[Pos];
        }
    }
}