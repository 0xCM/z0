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

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static TableEmission<F,T> emission<F,T>(T[] src, FilePath dst, F f = default)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new TableEmission<F,T>(src,dst);  
    }
}