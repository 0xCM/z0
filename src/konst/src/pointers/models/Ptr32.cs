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
    /// Captures and represents <see cref='uint'/> pointer
    /// </summary>
    public unsafe struct Ptr32
    {
        public uint* P;

        [MethodImpl(Inline)]
        public Ptr32(uint* src)
            => P = src;
    }
}