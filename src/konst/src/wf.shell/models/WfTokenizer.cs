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

    public class WfTokenizer
    {
        long StartToken;

        long EndToken;

        ExecTokens Tokens;

        public WfTokenizer()
        {
            StartToken = 0;
            EndToken = 0;
            Tokens = ExecTokens.init();
        }

        [MethodImpl(Inline)]
        public WfExecToken Open()
            => new WfExecToken((ulong)atomic(ref StartToken));

        [MethodImpl(Inline)]
        public WfExecToken Close(WfExecToken src)
            => src.Complete((ulong)atomic(ref EndToken));
    }
}