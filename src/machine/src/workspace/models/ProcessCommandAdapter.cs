//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    public sealed class ProcessCommandAdapter : ProcessCommand<ProcessCommandAdapter>
    {
        readonly IProcessCommand adapted_command;

        public ProcessCommandAdapter()
        {
            
        }

        public ProcessCommandAdapter(IProcessCommand adapted_command)
            : base(adapted_command)
        {
            this.adapted_command = adapted_command;
        }

        public override IProcessResponseMessge Ok(Type response_type, ProcessMessage content)
            => adapted_command.Ok(response_type, content);

        public override IProcessResponseMessge Error(Type response_type, ProcessMessage content)
            => adapted_command.Error(response_type, content);
    }
}