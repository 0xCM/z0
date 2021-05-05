//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an inclusive virtual memory range
    /// </summary>
    public readonly struct VirtualMemoryRange : IComparable<VirtualMemoryRange>
    {
        public MemoryAddress StartAddress {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public VirtualMemoryRange(MemoryAddress startAddress, ByteSize size)
        {
            StartAddress = startAddress;
            Size = size;
        }

        public MemoryAddress EndAddress
        {
            [MethodImpl(Inline)]
            get => StartAddress + Size;
        }

        public int CompareTo(VirtualMemoryRange src)
            => StartAddress.CompareTo(src.StartAddress);

        public string Format()
            => string.Format("[{0},{1}]:{2}", StartAddress.Format(false), EndAddress.Format(false), Size);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Contains(MemoryAddress src)
            => StartAddress <= src && src <= EndAddress;

        [MethodImpl(Inline)]
        public bool Contains(VirtualMemoryRange src)
            => src.StartAddress >= StartAddress && src.EndAddress <= EndAddress;

        [MethodImpl(Inline)]
        public static implicit operator MemoryRange(in VirtualMemoryRange src)
            => (src.StartAddress,src.EndAddress);
    }
}