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

    /// <summary>
    /// Defines a tool invocation script
    /// </summary>
    public struct ToolCmd<T> : IToolScript<ToolCmd<T>,T>
        where T : struct, IToolScript<T>
    {
        public T Content;

        public ToolId ToolId
            => Content.ToolId;

        [MethodImpl(Inline)]
        public ToolCmd(T data)
            => Content = data;

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        T IContented<T>.Content
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator ToolCmd<T>(T src)
            => new ToolCmd<T>(src);
    }
}