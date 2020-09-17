//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        [MethodImpl(Inline), Op]
        public static BufferAllocation own(BufferToken token)
            => new BufferAllocation(token);       
    }
}