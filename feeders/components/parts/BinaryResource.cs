//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Components;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct BinaryResource
    {
        public readonly string Id;

        public readonly int Length;

        public readonly ulong Location;

        public bool IsEmpty => Location == 0;

        /// <summary>
        /// Describes a data resource
        /// </summary>
        /// <param name="id">The resource id</param>
        /// <param name="src">The resource data</param>
        [MethodImpl(Inline)]
        public static BinaryResource Define(string id, ReadOnlySpan<byte> src)
            => new BinaryResource(id, src.Length, location(src));

        [MethodImpl(Inline)]
        public static BinaryResource Define(string id, int Length, ulong location)
            => new BinaryResource(id,Length,location);

        [MethodImpl(Inline)]
        internal BinaryResource(string Id, int Length, ulong Location)
        {
            this.Id = Id;
            this.Length = Length;
            this.Location = Location;
        }
         
        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<byte> GetBytes()
            => new ReadOnlySpan<byte>((void*)Location, Length);       
    
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        [MethodImpl(Inline)]
        static unsafe ulong location(ReadOnlySpan<byte> src)
            => (ulong)Unsafe.AsPointer(ref Unsafe.AsRef(in head(src)));
    }
}