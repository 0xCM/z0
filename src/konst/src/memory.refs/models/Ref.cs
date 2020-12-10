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

    using static Konst;
    using static z;

    public readonly struct Ref : ISegRef<byte>
    {
        internal readonly Vector128<ulong> Segment;

        [MethodImpl(Inline)]
        public Ref(Vector128<ulong> src)
            => Segment = src;

        [MethodImpl(Inline)]
        public unsafe Ref(byte* src, ulong size)
            => Segment = vparts((ulong)src, size);

        [MethodImpl(Inline)]
        public Ref(MemoryAddress src, ulong size)
            => Segment = vparts((ulong)src, (ulong)size);

        [MethodImpl(Inline)]
        public Ref(ulong location, ulong size)
            => Segment = Vector128.Create(location, (ulong)size);

        [MethodImpl(Inline)]
        public Span<T> As<T>()
            => cover<T>(Address, DataSize/size<T>());

        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => cover(Address, DataSize);
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => (uint)Segment.GetElement(1);
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Segment.GetElement(0);
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
            => ref Unsafe.AsRef<byte>((void*)(Address + (uint)index));

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash(Segment);
        }

        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        [MethodImpl(Inline)]
        public bool Equals(Ref src)
            => Segment.Equals(src.Segment);
        public string Format()
            => string.Format("{0}:{1}", Address, DataSize);

        public override bool Equals(object src)
            => src is Ref r && Equals(r);

        public override int GetHashCode()
            => (int) Address;

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<byte> operator !(Ref src)
            => src.Buffer;

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
        static unsafe Span<byte> cover(ulong location, uint count)
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