//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Runtime.CompilerServices;

    [ApiHost("api")]
    public partial class math : IApiHost<math>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;    
    }

    [ApiHost]
    public partial class BmiMul : IApiHost<BmiMul>
    {

    }

}