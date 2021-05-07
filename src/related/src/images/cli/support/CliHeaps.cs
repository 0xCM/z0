//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct CliHeaps
    {
        [MethodImpl(Inline), Op]
        public static unsafe uint count(StringHeap src)
        {
            var counter = 0u;
            var pFirst = src.BaseAddress.Pointer<char>();
            var pLast = (src.BaseAddress + src.Size).Pointer<char>();
            var pCurrent = pFirst;
            while(pCurrent < pLast)
            {
                if(*pCurrent++ == 0)
                    counter++;
            }
            return counter;
        }
    }
}