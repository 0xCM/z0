//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct UnmanagedReader
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static void run<T>(Span<T> src, Action<T> f)
            where T : unmanaged
        {
            fixed(T* pSrc = src)
            {
                var it = create(pSrc, src.Length);
                while(it.Next(out T current))
                    f(current);
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe UnmanagedReader<T> create<T>(T* pSrc, int count)
            where T : unmanaged
                => new UnmanagedReader<T>(pSrc, count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool next<T>(ref UnmanagedReader<T> src, out T dst)
            where T : unmanaged
                => src.Next(out dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T next<T>(ref UnmanagedReader<T> src)
            where T : unmanaged
                => ref src.Next();
    }

    public unsafe struct UnmanagedReader<T>
        where T : unmanaged
    {
        T* Current;

        int Count;

        T* Last;

        [MethodImpl(Inline)]
        internal UnmanagedReader(T* pSrc, int count)
        {
            Current = pSrc;
            Count = count;
            Last = gptr(skip(@ref(pSrc),count));
        }

        public int Remaining
        {
            [MethodImpl(Inline)]
            get => Count;
        }

        [MethodImpl(Inline)]
        public ref T Next()
        {
            if(Count != 0)
            {
                ref var result = ref Current;
                Current++;
                Count--;
                return ref @ref(result);
            }
            return ref @ref(Last);
        }

        [MethodImpl(Inline)]
        public ref T Next(out int index)
        {
            index = Count;
            if(Count >= 0)
            {
                ref var result = ref Current;
                Current++;
                Count--;
                return ref @ref(result);
            }
            return ref @ref(Last);
        }

        [MethodImpl(Inline)]
        public bool Next(out T dst)
        {
            if(Count >= 0)
            {
                dst = *Current;
                Current++;
                Count--;
                return true;
            }
            dst = default;
            return false;
        }
    }
}