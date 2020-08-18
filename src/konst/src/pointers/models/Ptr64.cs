//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Pointers;

    /// <summary>
    /// Captures and represents <see cref='ulong'/> pointer
    /// </summary>
    public unsafe struct Ptr64
    {
        public ulong* P;

        [MethodImpl(Inline)]
        public Ptr64(ulong* src)
            => P = src;
    }
}