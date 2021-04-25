//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ProcessSpec : IComparable<ProcessSpec>, IEquatable<ProcessSpec>
    {
        public uint ProcessId {get;}

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public ProcessSpec(uint id, MemoryAddress address)
        {
            ProcessId = id;
            Address = address;
        }

        [MethodImpl(Inline)]
        public unsafe void* Pointer()
            => Address.Pointer();

        [MethodImpl(Inline)]
        public int CompareTo(ProcessSpec src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public bool Equals(ProcessSpec src)
            => ProcessId == src.ProcessId && Address == src.Address;

        public override int GetHashCode()
            => (int)Address.Hash;

        public override bool Equals(object src)
            => src is ProcessSpec s && Equals(s);

        [MethodImpl(Inline)]
        public static implicit operator ProcessSpec((int id, MemoryAddress address) src)
            => new ProcessSpec((uint)src.id, src.address);

        [MethodImpl(Inline)]
        public static implicit operator ProcessSpec((uint id, MemoryAddress address) src)
            => new ProcessSpec((uint)src.id, src.address);
    }
}