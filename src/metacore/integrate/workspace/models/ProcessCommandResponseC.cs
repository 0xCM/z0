//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class ProcessCommandResponse<C> : ProcessComandResponse<ProcessCommandResponse<C>, C>
        where C : IProcessCommand
    {   
        readonly IProcessResponseMessge adapted_response;
        
        public ProcessCommandResponse(C command, IProcessResponseMessge adapted_response)
            : base(command, adapted_response)
        {
            this.adapted_response = adapted_response;            
        }       
    }
}