//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Runtime.CompilerServices;

    [ApiHost("api", ApiHostKind.Direct)]
    public partial class math : IApiHost<math>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;    
    }
}