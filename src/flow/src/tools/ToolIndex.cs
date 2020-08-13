//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolIndex
    {
        readonly ToolSpec[] Tools;

        public ToolIndex(ToolSpec[] tools)
        {
            Tools = tools;
        }
    }
}   