//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DelimitedList<T> delimit<T>(T[] src, char delimiter = Chars.Comma)
            => new DelimitedList<T>(src, delimiter);        
    }
}