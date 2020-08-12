//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Data;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static ArchivedTable<F,T> archived<F,T>(FilePath location)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new ArchivedTable<F,T>(location);
    }
}