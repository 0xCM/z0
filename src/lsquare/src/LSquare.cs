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
    [ApiHost]
    public partial class LSquare : IApiHost<LSquare>
    {
        static W256 w => default;
    }

    [FunctionalService]
    public partial class LogicSquares : IFunctional<LogicSquares>
    {

    }
}