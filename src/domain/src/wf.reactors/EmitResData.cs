//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitResData : CmdReactor<EmitResDataCmd,Index<ResEmission>>
    {
        protected override Index<ResEmission> Run(EmitResDataCmd cmd)
            => ResDataEmitter.embedded(Wf, cmd.Source, cmd.Target, cmd.Match, cmd.ClearTarget);
    }
}