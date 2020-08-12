//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static DataFlow<S,T> flow<S,T>(S src, T dst)
            => new DataFlow<S,T>(src,dst);
        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static DataFlow<T[],BinaryCode> flow<T>(T[] src, BinaryCode dst)
            where T : struct
                => new DataFlow<T[],BinaryCode>(src, dst);
    }
}