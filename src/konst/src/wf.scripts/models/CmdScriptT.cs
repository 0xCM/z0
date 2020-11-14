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

    public struct CmdScript<T> : IToolScript<CmdScript<T>,T>
        where T : struct, IToolScript<T>
    {
        public T Content;

        public ToolId ToolId
            => Content.ToolId;

        [MethodImpl(Inline)]
        public CmdScript(T data)
            => Content = data;

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        T IContented<T>.Content
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator CmdScript<T>(T src)
            => new CmdScript<T>(src);
    }
}