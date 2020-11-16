//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = WfShell;

    public readonly struct WfExecToken
    {
        public ulong Source {get;}

        public ulong Target {get;}

        [MethodImpl(Inline)]
        public WfExecToken(ulong src)
        {
            Source = src;
            Target = default;
        }

        [MethodImpl(Inline)]
        public WfExecToken(ulong src, ulong dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public WfExecToken WithTarget(ulong dst)
            => new WfExecToken(Source, dst);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator WfExecToken(Pair<ulong> src)
            => new WfExecToken(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator WfExecToken(ulong src)
            => new WfExecToken(src);
    }
}