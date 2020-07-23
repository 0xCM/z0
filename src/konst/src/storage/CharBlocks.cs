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
    public readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        static ref byte u8ref<T>(in T src)

            => ref cast<T,byte>(src);


        [MethodImpl(Inline), Op]
        static ref ushort u16ref<T>(in T src)
            => ref cast<T,ushort>(src);

        [MethodImpl(Inline), Op]
        static ref uint u32ref<T>(in T src)
            => ref cast<T,uint>(src);
    }
}