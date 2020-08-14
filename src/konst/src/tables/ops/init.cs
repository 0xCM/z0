//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Text;

    using static Konst;
    using Z0.Data;

    using static z;

    public readonly partial struct Table
    {
        [MethodImpl(Inline)]
        public static T init<T>()
            where T : struct, ITable<T>
                => new T(); 
    }
}