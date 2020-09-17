//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using PD = Pointers.Delegates;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static void fix<T>(Span<T> src, PD.Receiver<T> receiver)
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