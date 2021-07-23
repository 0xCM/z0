//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Toolchain
    {
        Index<ToolId> _Tools;

        internal Toolchain(ToolId[] tools)
        {
            _Tools = tools;
        }

        public ReadOnlySpan<ToolId> Tools
        {
            [MethodImpl(Inline)]
            get => _Tools.View;
        }
    }
}