//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolId<T> : IIdentified<ToolId<T>, string>
        where T : struct
    {
        public string Id
            => typeof(T).Name;

        [MethodImpl(Inline)]
        public static implicit operator ToolId(ToolId<T> src)
            => new ToolId(src.Id);
    }
}