//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdOutput<T>
        where T : struct, ITool<T>
    {
        public readonly TableSpan<CmdTarget<T>> Table;

        [MethodImpl(Inline)]
        public static implicit operator CmdOutput<T>(CmdTarget<T>[] src)
            => new CmdOutput<T>(src);

        [MethodImpl(Inline)]
        public CmdOutput(CmdTarget<T>[] src)
            => Table = src;
    }
}