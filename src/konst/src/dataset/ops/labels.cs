//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Dataset
    {
        [MethodImpl(Inline)]
        public static string[] labels<F>()
            where F : unmanaged, Enum
                => DataFields.labels<F>();    
    }
}