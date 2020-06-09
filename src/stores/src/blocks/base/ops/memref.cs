//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial struct MemoryStore
    {
        [MethodImpl(Inline), Op]
        public ref readonly MemoryRef memref(StoreIndex n)
            => ref cell(Sources,n);
    }
}