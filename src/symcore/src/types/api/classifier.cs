//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct types
    {
         public static Classifier<K,T> classifier<K,T>()
            where K : unmanaged, Enum
            where T : unmanaged
                => ClassCache.classifier<K,T>();
    }
}
