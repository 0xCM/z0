//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Part;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static void fix<T>(Span<T> src, PointedReceiver<T> receiver)
            where T : unmanaged
        {
            var count = (uint)src.Length;
            fixed(T* pSrc = src)
            {
                var p = pSrc;
                for(var i=0u; i<count; i++)
                    receiver(p++);
            }
        }
    }
}