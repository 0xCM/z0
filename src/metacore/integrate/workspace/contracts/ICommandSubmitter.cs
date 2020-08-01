//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static z;

    public interface ICommandSubmitter
    {
        Option<CommandSubmission[]> Submit(IEnumerable<ICommandSpec> Commands, SystemNode DstNode,  CorrelationToken? ct);

        Option<CommandSubmission> Submit(ICommandSpec Command, SystemNode DstNode, CorrelationToken? ct);

        Option<CommandSubmission<S>[]> Submit<S>(IEnumerable<S> Commands, SystemNode DstNode, CorrelationToken? ct)
                where S : CommandSpec<S>, new();
    }
}