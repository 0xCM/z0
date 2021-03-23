//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct RegCodes
    {
        [MethodImpl(Inline)]
        public static RegCode<T> define<T>(T src)
            where T : unmanaged, IBitNumber<T>
                => new RegCode<T>(src);
    }
}