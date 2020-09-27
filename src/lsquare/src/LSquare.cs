//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    [ApiHost("api")]
    public partial class LogicSquare
    {
        static W256 w => default;

        const NumericKind Closure = UnsignedInts;
    }

    [FunctionalService]
    public partial class LogicSquares : ISFxHost<LogicSquares>
    {
        const NumericKind Closure = UnsignedInts;
    }

    [ApiHost("ops")]
    public partial class LogicSquared
    {
        const NumericKind Closure = UnsignedInts;

    }
}