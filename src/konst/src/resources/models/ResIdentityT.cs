//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    /// <summary>
    /// Identifies a resource of parametric type along with a reference to the memory segment it occupies
    /// </summary>
    public readonly struct ResIdentity<T>
    {
        public readonly asci32 Name;

        public readonly MemorySegment Reference;

        [MethodImpl(Inline)]
        public ResIdentity(in asci32 name, in MemorySegment memref)
        {
            Name = name;
            Reference = memref;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Reference.BaseAddress;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => DataSize/CellSize;
        }

        public uint CellSize
        {
            [MethodImpl(Inline)]
            get => (uint)size<T>();
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => Reference.DataSize;
        }

        [MethodImpl(Inline)]
        public static implicit operator ResIdentity(ResIdentity<T> src)
            => new ResIdentity(src.Name,src.Reference, ClrPrimitives.kind<T>());
    }
}