//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    internal class TokenDispenser
    {
        static long StartToken;

        static long EndToken;

        public static TokenDispenser acquire()
            => new TokenDispenser();

        [MethodImpl(Inline)]
        public ExecToken NextExecToken()
            => new ExecToken((ulong)core.inc(ref StartToken));

        [MethodImpl(Inline)]
        public ExecToken CloseExecToken(ExecToken src)
            => src.Complete((ulong)core.inc(ref EndToken));
    }
}