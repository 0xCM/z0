//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline)]   
        public static byte uint8<T>(T src)
            => As.uint8(src);

        [MethodImpl(Inline)]   
        public static byte? uint8<T>(T? src)
            where T : unmanaged
                => As.uint8(src);
    }
}