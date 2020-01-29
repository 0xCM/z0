//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    [Flags]
    public enum OpFacetModifier
    {
        None = 0,

        Default = 0,

        /// <summary>
        /// Indicates that a name supplied to an operation attribute replaces the default name
        /// </summary>
        ReplaceName = Default,

        /// <summary>
        /// Indicates that a name supplied to an operation attribute prefixes the default name
        /// </summary>
        CombineNames = 2
    }
}