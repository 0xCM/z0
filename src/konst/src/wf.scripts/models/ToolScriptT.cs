//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Konst;
    using static z;

    public struct ToolScript<T> : IToolScript<ToolScript<T>,T>
        where T : struct, IToolScript<T>
    {
        public T Content;

        public ToolId ToolId
            => Content.ToolId;

        [MethodImpl(Inline)]
        public ToolScript(T data)
            => Content = data;

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        T IContented<T>.Content
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator ToolScript<T>(T src)
            => new ToolScript<T>(src);
    }
}