//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    [ApiHost("api")]
    public partial class LogicSquare : IApiHost<LogicSquare>
    {
        static W256 w => default;
    }

    [FunctionalService]
    public partial class LogicSquares : IFunctional<LogicSquares>
    {

    }

    [ApiHost("ops")]
    public partial class LogicSquared : IApiHost<LogicSquared>
    {

    }
}