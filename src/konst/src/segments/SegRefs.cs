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

    [ApiHost]
    public readonly partial struct SegRefs
    {
        [MethodImpl(Inline), Op]
        public static Ref<T> segref<T>(in T src)
            where T : struct
                => new Ref<T>(z.address(src), size<T>());     
    }    
}