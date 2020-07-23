//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    
    partial struct SegRefs
    {
        [MethodImpl(Inline), Op]
        internal static Vector128<ulong> location(SegRef src)
            => vparts(N128.N, src.Address, (ulong)src.DataSize); 

        [MethodImpl(Inline), Op]
        internal static uint length<T>(Vector128<ulong> src)
        {
            SegRefs.unpack(vcell(src,1), out var size, out var _);
            return size/scale<T>();
        }

        [MethodImpl(Inline), Op]
        internal static uint user(Vector128<ulong> src)
        {
            SegRefs.unpack(vcell(src,1), out _, out var user);
            return user;
        }
    }
}