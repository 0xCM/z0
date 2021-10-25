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
        public static MergeMask mmask(ulong value)
            => new MergeMask(value);
    }
}