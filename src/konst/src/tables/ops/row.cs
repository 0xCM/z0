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
        public static StringTableRow row(string[] data)
            => new StringTableRow(data);

        [MethodImpl(Inline), Op]
        public static StringTableRow<T> row<T>(params StringTableCell<T>[] cells)
            where T : ITextual
                => new StringTableRow<T>(cells);
    }
}