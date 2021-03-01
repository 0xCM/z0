//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfFileFlow
    {
        readonly IWfShell Wf;

        public WfExecToken Token {get;}

        public FS.FilePath Target {get;}

        public Count EmissionCount {get;}

        [MethodImpl(Inline)]
        internal WfFileFlow(IWfShell wf, FS.FilePath dst, in WfExecToken token, uint count = 0)
        {
            Wf = wf;
            Token = token;
            Target = dst;
            EmissionCount = count;
        }

        [MethodImpl(Inline)]
        public WfFileFlow WithCount(Count count)
            => new WfFileFlow(Wf, Target, Token, count);

        [MethodImpl(Inline)]
        public WfFileFlow WithToken(WfExecToken token)
            => new WfFileFlow(Wf, Target, token, EmissionCount);

        [MethodImpl(Inline)]
        public static implicit operator WfExecFlow(WfFileFlow src)
            => new WfExecFlow(src.Wf, src.Token);
    }
}