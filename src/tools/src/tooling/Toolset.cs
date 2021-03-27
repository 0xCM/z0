//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a set of related tools
    /// </summary>
    public readonly struct Toolset
    {
        public Identifier Name {get;}

        public Index<ToolId> Members {get;}

        public Toolset(Identifier name, params ToolId[] members)
        {
            Name = name;
            Members = members;
        }
    }

    /// <summary>
    /// Defines a kind-related set of tools
    /// </summary>
    public readonly struct Toolset<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public Identifier Name {get;}

        public Index<ToolId> Members {get;}

        public Toolset(Identifier name, K kind, params ToolId[] members)
        {
            Name = name;
            Kind = kind;
            Members = members;
        }
    }
}