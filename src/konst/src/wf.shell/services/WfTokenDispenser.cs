//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    internal class TokenDispenser
    {
        static long StartToken;

        static long EndToken;

        public static TokenDispenser acquire()
            => new TokenDispenser();

        [MethodImpl(Inline)]
        public WfExecToken NextExecToken()
            => new WfExecToken((ulong)root.atomic(ref StartToken));

        [MethodImpl(Inline)]
        public WfExecToken CloseExecToken(WfExecToken src)
            => src.Complete((ulong)root.atomic(ref EndToken));
    }
}