//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    /// <summary>
    /// A reference?
    /// </summary>        
    public readonly struct Ref
    {
        readonly Vector128<ulong> R;    

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<byte> operator !(Ref src)
            => src.Bytes;

        [MethodImpl(Inline)]
        internal Ref(ulong location, uint size)
        {
            R = Vector128.Create(location, (ulong)size);
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public Span<T> As<T>()
            => cover<T>(Location, (uint)size<T>()/Size);

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => cover(Location, Size);
        }

        public uint Size
        {
            [MethodImpl(Inline)]
            get => (uint)R.GetElement(1);
        } 

        public ulong Location
        {
            [MethodImpl(Inline)]
            get => R.GetElement(0);
        }

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