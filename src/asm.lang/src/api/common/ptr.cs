//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmOps;

    partial struct asm
    {
        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static ptr<T> ptr<T>(T dst)
            where T : unmanaged
                => new ptr<T>(dst);
    }
}