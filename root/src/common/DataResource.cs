//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Describes an embedded data resource
    /// </summary>
    public readonly struct DataResource
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
        public static DataResource Define(string id, ReadOnlySpan<byte> src)
            => new DataResource(id, src.Length, location(src));

        [MethodImpl(Inline)]
        public static DataResource Define(string id, int Length, ulong location)
            => new DataResource(id,Length,location);

        [MethodImpl(Inline)]
        internal DataResource(string Id, int Length, ulong Location)
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