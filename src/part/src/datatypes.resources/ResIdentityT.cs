//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    /// <summary>
    /// Identifies a resource of parametric type along with a reference to the memory segment it occupies
    /// </summary>
    public readonly struct ResIdentity<T>
    {
        public Name Name {get;}

        public MemorySegment Segment {get;}

        [MethodImpl(Inline)]
        public ResIdentity(Name name, MemorySegment seg)
        {
            Name = name;
            Segment = seg;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Segment.BaseAddress;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => DataSize/CellSize;
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => size<T>();
        }

        public ByteSize DataSize
        {
            [MethodImpl(Inline)]
            get => Segment.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator ResIdentity(ResIdentity<T> src)
            => new ResIdentity(src.Name, src.Segment, ClrPrimitives.kind<T>());
    }
}