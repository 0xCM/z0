//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public ref struct CellCycle<T>
        where T : unmanaged
    {
        ReadOnlySpan<T> Cells;

        ulong Current;

        ulong Last;

        [MethodImpl(Inline)]
        public CellCycle(ReadOnlySpan<T> src)
        {
            Cells = src;
            Current = 0;
            Last = (ulong)src.Length - 1ul;
        }

        [MethodImpl(Inline)]
        public ref readonly T Next()
        {
            ref readonly var x = ref skip(Cells,Current++);
            if(Current == Last)
                Current = 0;
            return ref x;
        }
    }
}