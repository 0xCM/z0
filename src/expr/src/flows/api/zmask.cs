//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct flows
    {
        [MethodImpl(Inline), Op]
        public static ZeroMask zmask(ulong value)
            => new ZeroMask(value);
    }
}