//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {                

        [MethodImpl(Inline), Op]
        public static unsafe byte u8(bool on)
            => *((byte*)(&on));


    }
}