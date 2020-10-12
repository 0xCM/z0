//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static Pow2x32;

    /// <summary>
    /// Classifies sorts foundational api type roles
    /// </summary>
    [Flags]
    public enum ApiTypeRole : uint
    {
        None,

        ApiHost = P2ᐞ00,

        ApiService = P2ᐞ01,

        ApiDataType = P2ᐞ02,

        Event = P2ᐞ03,

        WorkflowHost = P2ᐞ04,

        ApiCommand = P2ᐞ05,

        ToolCommand = P2ᐞ06,

    }
}