//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;
    using static Part;

    public readonly struct Ref : ISegRef<byte>
    {
        public MemoryAddress Address {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public Ref(Vector128<ulong> src)
        {
            Address = src.GetElement(0);
            Size = src.GetElement(1);
        }

        [MethodImpl(Inline)]
        public unsafe Ref(byte* src, ulong size)
        {
            Address = src;
            Size = size;
        }

        [MethodImpl(Inline)]
        public Ref(MemoryAddress src, ulong size)
        {
            Address = src;
            Size = size;
        }

        [MethodImpl(Inline)]
        public Ref(ulong location, ulong size)
        {
            Address = location;
            Size = size;
        }

        [MethodImpl(Inline)]
        public Span<T> As<T>()
            => cover<T>(BaseAddress, DataSize/size<T>());

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => cover(BaseAddress, DataSize);
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Address;
        }

        public uint CellSize
        {
            [MethodImpl(Inline)]
            get => 1;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => DataSize;
        }

        [MethodImpl(Inline)]
        public unsafe ref byte Cell(int index)
            => ref Unsafe.AsRef<byte>((void*)(BaseAddress + (uint)index));

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Address,Size);
        }

        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        [MethodImpl(Inline)]
        public bool Equals(Ref src)
            => src.Address == Address && src.Size == Size;

        public string Format()
            => string.Format("{0}:{1}", BaseAddress, DataSize);

        public override bool Equals(object src)
            => src is Ref r && Equals(r);

        public override int GetHashCode()
            => (int)Hash;

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<byte> operator !(Ref src)
            => src.Edit;

        [MethodImpl(Inline)]
        public static bool operator ==(Ref a, Ref b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Ref a, Ref b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        static uint size<T>()
            => (uint)SizeOf<T>();

        [MethodImpl(Inline)]
        static unsafe Span<byte> cover(MemoryAddress location, uint count)
            => cover<byte>((void*)location, count);

        [MethodImpl(Inline)]
        static unsafe Span<T> cover<T>(ulong location, uint count)
            => cover<T>((void*)location, count);

        [MethodImpl(Inline)]
        static unsafe Span<T> cover<T>(void* pSrc, uint count)
            => CreateSpan(ref @as<T>(pSrc), (int)count);

        [MethodImpl(Inline)]
        static unsafe ref T @as<T>(void* pSrc)
            => ref AsRef<T>(pSrc);
    }
}