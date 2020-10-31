//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
            => string.Format("{0}:{1}", Source, Target);

        public override string ToString()
            => Format();
    }
}