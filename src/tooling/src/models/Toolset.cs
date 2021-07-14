//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a name-identified tool configuration set
    /// </summary>
    public readonly struct Toolset
    {
        public Identifier Name {get;}

        public Index<ToolConfig> Configs {get;}

        [MethodImpl(Inline)]
        public Toolset(Identifier name, ToolConfig[] configs)
        {
            Name = name;
            Configs = configs;
        }
    }
}