//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline)]
        public unsafe static void map<M,T>(Span<T> src, M mapper, Span<MemoryAddress> dst)
            where T : unmanaged
            where M : IPointedMap<T,MemoryAddress>
        {
            var count = (uint)src.Length;
            fixed(T* pSrc = src)
            {
                var p = pSrc;
                for(var i=0u; i<count; i++)
                    z.seek(dst,i) = mapper.Map(p++);
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void locate<T>(Span<T> src, Span<MemoryAddress> dst)
            where T : unmanaged
                => map(src,new Locate<T>(), dst);


        readonly struct Locate<T> : IPointedMap<Locate<T>,T,MemoryAddress>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public MemoryAddress Map(T* pSrc)
                => pSrc;
        }
    }
}