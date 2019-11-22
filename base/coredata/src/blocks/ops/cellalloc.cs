//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;
    using static nfunc;

    partial class DataBlocks
    {
        [MethodImpl(Inline)]
        public static Block64<T> cellalloc<T>(N64 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, blockalign<T>(n, cellcount));

        [MethodImpl(Inline)]
        public static Block128<T> cellalloc<T>(N128 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, blockalign<T>(n, cellcount));

        [MethodImpl(Inline)]
        public static Block256<T> cellalloc<T>(N256 n, int cellcount)
            where T : unmanaged        
                => alloc<T>(n, blockalign<T>(n, cellcount));


    }

}