//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static MemoryScale scale(byte value)
            => scale((ScaleFactor)value);

        [MethodImpl(Inline)]
        public static MemoryScale scale(ScaleFactor factor)
            => new MemoryScale(factor);
    }
}