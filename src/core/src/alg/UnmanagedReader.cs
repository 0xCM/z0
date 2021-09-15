//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public unsafe struct UnmanagedReader<T>
        where T : unmanaged
    {
        T* Current;

        int Count;

        T* Last;

        [MethodImpl(Inline)]
        public UnmanagedReader(T* pSrc, int count)
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