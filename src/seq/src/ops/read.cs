//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    using System;
    using System.Runtime.CompilerServices;

    partial struct seq
    {
       [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static void read<T>(Span<T> src, Action<T> dst)
            where T : unmanaged
        {
            fixed(T* pSrc = src)
            {
                var it = seq.reader(pSrc, src.Length);
                while(it.Next(out T current))
                    dst(current);
            }
        }

    }
}
