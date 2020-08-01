//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public sealed class ProcessCommandResponseAdapter : ProcessCommandResponse<ProcessCommandAdapter>
    {
        public ProcessCommandResponseAdapter(ProcessCommandAdapter command, IProcessResponseMessge adapted_response)
            : base(command,adapted_response)
        {
            
        }
    }
}