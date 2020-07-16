//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    [ApiHost("api")]
    public partial class BitPack
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}