//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost("api")]
    public partial class BitMatrix : IApiHost<BitMatrix>
    {        

    }

    [ApiHost("logix")]
    public partial class SquareBitLogix : IApiHost<SquareBitLogix>
    {

    }

    /// <summary>
    /// Defines primary api surface for rowbit manipulation
    /// </summary>
    [ApiHost]
    public partial class RowBits : IApiHost<RowBits>
    {

    }

    [ApiHost]
    public partial class BitBlocks : IApiHost<BitBlocks>
    {

    }

    public static partial class XTend
    {   

    }
}

