//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Formatters
    {   
        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static BitFormatter<T> bits<T>()
            where T : struct    
                => BitFormatter.create<T>();
    }
}