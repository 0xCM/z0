//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitMatrix)]

namespace Z0.Parts
{        
    public sealed class BitMatrix : Part<BitMatrix>
    {
        
    }
}

namespace Z0
{
    using System;


    [ApiHost]
    public partial class BitMatrix : IApiHost<BitMatrix>
    {        

    }

    [ApiHost("bitmatrix.ops")]
    public partial class BitMatrixOps : IApiHost<BitMatrixOps>
    {

    }

    public static partial class XTend
    {   

    }

}