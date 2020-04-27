//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct BinaryResource
    {
        public readonly string Id;

        public readonly PartId Owner;

        public readonly int Length;

        public readonly ulong Address;

        public ReadOnlySpan<byte> Data => Bytes;

        public ulong RuntimeAddress => ptr(Bytes);

        public bool IsEmpty => Address == 0;

        public string Uri 
            => string.Concat("res", Chars.Colon, Chars.FSlash, Chars.FSlash, Owner.Format(), Chars.FSlash, Id);
            
        /// <summary>
        /// Describes a data resource
        /// </summary>
        /// <param name="id">The resource id</param>
        /// <param name="src">The resource data</param>
        [MethodImpl(Inline)]
        public static BinaryResource Define(PartId owner, string id, ReadOnlySpan<byte> src)
            => new BinaryResource(owner, id, src.Length, location(src));

        [MethodImpl(Inline)]
        public static BinaryResource Define(PartId owner, string id, int Length, ulong address)
            => new BinaryResource(owner,id,Length,address);

        [MethodImpl(Inline)]
        internal BinaryResource(PartId part, string Id, int Length, ulong address)
        {
            this.Owner = part;
            this.Id = Id;
            this.Length = Length;
            this.Address = address;
        }
         
        [MethodImpl(Inline)]
        static unsafe ulong ptr(ReadOnlySpan<byte> src)
            => (ulong)Unsafe.AsPointer(ref Unsafe.AsRef(in head(src)));

        unsafe ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<byte>((void*)Address, Length);       
        }
    
        [MethodImpl(Inline)]
        static ref readonly T head<T>(ReadOnlySpan<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        [MethodImpl(Inline)]
        static unsafe ulong location(ReadOnlySpan<byte> src)
            => (ulong)Unsafe.AsPointer(ref Unsafe.AsRef(in head(src)));
    }
}