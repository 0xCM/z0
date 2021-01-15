//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Tool<T> : ITool<Tool<T>>
    {
        public Name ToolName {get;}

        [MethodImpl(Inline)]
        public Tool(string name)
            => ToolName = name;

        [MethodImpl(Inline)]
        public static implicit operator Tool<T>(string id)
            => new Tool<T>(id);
    }
}