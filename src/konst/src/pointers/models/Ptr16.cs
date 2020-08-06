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
    /// Models a <see cref='ushort'/> pointer
    /// </summary>
    public unsafe struct Ptr16
    {
        public ushort* P;

        [MethodImpl(Inline)]
        public Ptr16(ushort* src)
            => P = src;
    }
}