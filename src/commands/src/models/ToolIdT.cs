//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ToolId<T>
        where T : ITool
    {
        public ToolId Id {get;}

        [MethodImpl(Inline)]
        public ToolId(string name)
            => Id = name;

        [MethodImpl(Inline)]
        public ToolId(ToolId id)
            => Id = id;

        [MethodImpl(Inline)]
        public static implicit operator ToolId<T>(string id)
            => new ToolId<T>(id);

        [MethodImpl(Inline)]
        public static implicit operator ToolId<T>(ToolId id)
            => new ToolId<T>(id);
    }
}