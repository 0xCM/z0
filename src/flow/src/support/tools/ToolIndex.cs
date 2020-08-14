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
    /// Defines a collection of available tools
    /// </summary>
    public readonly struct ToolIndex
    {
        public readonly TableSpan<ToolSpec> Table;

        [MethodImpl(Inline)]
        public ToolIndex(ToolSpec[] tools)
        {
            Table = tools;
        }
    }
}   