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

    public readonly struct Ref : ISegRef<byte>
    {
        internal readonly Vector128<ulong> Segment;

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<byte> operator !(Ref src)
            => src.Buffer;

        [MethodImpl(Inline)]
        public static bool operator ==(Ref lhs, Ref rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Ref lhs, Ref rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public Ref(Vector128<ulong> src)
            => Segment = src;

        [MethodImpl(Inline)]
        public Ref(ulong location, uint size)
            => Segment = Vector128.Create(location, (ulong)size);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public Span<T> As<T>()
            => cover<T>(Location, DataSize/size<T>());

        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => cover(Location, DataSize);
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => (uint)Segment.GetElement(1);
        }

        public ulong Location
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
            => ref Unsafe.AsRef<byte>((void*)(Location + (uint)index));

        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        [MethodImpl(Inline)]
        public bool Equals(Ref src)
            => Segment.Equals(src.Segment);

        public override bool Equals(object src)
            => src is Ref r && Equals(r);

        public override int GetHashCode()
            => (int) Location;

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