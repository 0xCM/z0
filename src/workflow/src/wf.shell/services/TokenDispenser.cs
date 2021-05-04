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
        public ExecToken NextExecToken()
            => new ExecToken((ulong)root.atomic(ref StartToken));

        [MethodImpl(Inline)]
        public ExecToken CloseExecToken(ExecToken src)
            => src.Complete((ulong)root.atomic(ref EndToken));
    }
}