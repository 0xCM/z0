//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Tool<T> : ITool<Tool<T>>
    {
        public ToolId Id {get;}

        [MethodImpl(Inline)]
        public Tool(string name)
            => Id = name;

        [MethodImpl(Inline)]
        public Tool(ToolId id)
            => Id = id;

        [MethodImpl(Inline)]
        public static implicit operator Tool<T>(string id)
            => new Tool<T>(id);

        [MethodImpl(Inline)]
        public static implicit operator Tool<T>(ToolId id)
            => new Tool<T>(id);
    }
}