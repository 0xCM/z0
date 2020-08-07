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

    public readonly struct ArchivedTable<F,T>
        where T : struct, ITable<F,T>
        where F : unmanaged, Enum
    {
        public readonly FilePath Location;        

        [MethodImpl(Inline)]
        public ArchivedTable(FilePath path)
        {
            Location = path;
        }        
    }
}
