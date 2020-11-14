//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolId<T> : IIdentified<ToolId<T>, utf8>
        where T : struct
    {
        public utf8 Id
            => typeof(T).Name;

        public bool Equals(ToolId<T> src)
            => true;    

        [MethodImpl(Inline)]
        public static implicit operator ToolId(ToolId<T> src)
            => new ToolId(src.Id);
    }
}