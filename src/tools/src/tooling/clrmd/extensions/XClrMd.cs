//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using Microsoft.Diagnostics.Runtime;
    using Microsoft.Diagnostics.Runtime.DacInterface;

    using static Root;

    public static partial class XClrMd
    {

        [MethodImpl(Inline)]
        public static MemoryAddress ToMemoryAddress(this ClrDataAddress src)
            => (ulong)src;
    }
}