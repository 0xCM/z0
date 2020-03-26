//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Runtime.CompilerServices;

    [ApiHost("api", ApiHostKind.Direct)]
    public static partial class math
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;    
    }
}