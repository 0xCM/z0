//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public partial class BitMatrix : IApiHost<BitMatrix>
    {        

    }

    [ApiHost]
    public partial class BitGrid : IApiHost<BitGrid>
    {
                    
    }

    [ApiHost("patterns")]
    public partial class GridPatterns : IApiHost<GridPatterns>
    {

    }

    [ApiHost]
    public partial class BitBlocks : IApiHost<BitBlocks>
    {

    }

    [ApiHost]
    public partial class SubGrid : IApiHost<SubGrid>
    {

    }

    [ApiHost("bitmatrix.ops")]
    public partial class BitMatrixOps : IApiHost<BitMatrixOps>
    {

    }

    [ApiHost]
    public static partial class GridLoad
    {   

    }


    public static partial class BitGridX
    {   

    }

    public static partial class XTend
    {   

    }

}