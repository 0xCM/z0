//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    [ApiHost]
    public partial class vlogic
    {
        static W256 w => default;

        const NumericKind Closure = UnsignedInts;
    }
}