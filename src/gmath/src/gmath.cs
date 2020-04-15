//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost("api")]
    public partial class gmath : IApiHost<gmath>
    {
          
    }

    [ApiHost("as.numeric")]
    public partial class AsNumeric : IApiHost<AsNumeric>
    {                

    }

    [ApiHost]
    public partial class Partition : IApiHost<Partition>
    {

    }

    [ApiHost]
    public partial class num : IApiHost<num>
    {

    }

    [ApiHost("parser")]
    public partial class NumericParser : IApiHost<NumericParser>
    {

    }
    public static partial class XTend
    {
       
    }
}