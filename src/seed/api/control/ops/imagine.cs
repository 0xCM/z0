//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {

        [MethodImpl(Inline), Op]
        public static ref T imagine<S,T>(ref S src)
            => ref Unsafe.As<S,T>(ref edit(src));
    }
}