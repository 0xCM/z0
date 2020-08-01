//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    public readonly struct VapidProcess : IProcess
    {
        public static VapidProcess TheOne => default;

        public int Id 
            => 0;

        public int ExitCode 
            => 0;

        public int WaitForExit()
            => 0;

        [MethodImpl(Inline)]
        public CorrelationToken Transmit(IMessage command)
        {
            //Living up to its name
            ((ProcessCommand)command).SubmittingProcess = this;
            return default;
        }
    }
}