//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    [ApiHost("api")]
    public partial class Symbolic : IApiHost<Symbolic>
    {

    }

    [ApiHost]
    public partial class SymTest : IApiHost<SymTest>
    {

    }

    [ApiHost("data")]
    public partial class SymbolicData : IApiHost<SymbolicData>
    {

    }

    
    public static partial class XTend
    {
        
    }
}