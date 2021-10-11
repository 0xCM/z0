//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Collections.Generic;

    public readonly partial struct Virtual
    {
        public class Allocator
        {
            List<MemoryRange> Allocated;

            int Pos;

            object locker;

            public Allocator()
            {
                Allocated = new();
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
                        Allocated.Add(seg);
                        Pos = 0;
                    }
                    else
                    {
                        var last = Allocated[Pos];
                        var seg = MemoryRange.define(last.Max + 1, last.Max + size);
                        Allocated.Add(seg);
                        Pos++;
                    }
                }
                return Allocated[Pos];
            }
        }
    }
}