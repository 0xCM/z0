//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public class WfTokenProvider
    {
        long StartToken;

        ExecTokens Tokens;

        public WfTokenProvider()
        {
            StartToken = 0;
            Tokens = ExecTokens.init();
        }

        [MethodImpl(Inline)]
        public WfExecToken Dispense()
            => new WfExecToken((ulong)root.atomic(ref StartToken));
    }
}