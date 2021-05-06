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
    public readonly struct ResDescriptor<T> : IDataTypeComparable<ResDescriptor<T>>, IAddressable
    {
        public Name Name {get;}

        public MemorySeg Segment {get;}

        [MethodImpl(Inline)]
        public ResDescriptor(Name name, MemorySeg seg)
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
        public int CompareTo(ResDescriptor<T> src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public bool Equals(ResDescriptor<T> src)
            => Address.Equals(src.Address);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, Address, DataSize, Name);

        public override string ToString()
            => Format();

        public static ResDescriptor<T> Empty
            => new ResDescriptor<T>(Name.Empty, MemorySeg.Empty);
    }
}