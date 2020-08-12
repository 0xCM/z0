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
    using static z;

    public readonly struct TableProcessor<T,Y> : ITableProcessor<TableProcessor<T,Y>,T,Y>        
        where T : struct, ITable
    {                
        [MethodImpl(Inline)]
        public Y Process(in T x)
        {
            return default;
        }    
    }
}