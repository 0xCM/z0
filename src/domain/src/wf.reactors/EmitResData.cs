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

        // public static void xed(IWfShell wf)
        //     => XedEtlWfHost.create().Run(wf);

        // {
        //     var query = cmd.Match.IsEmpty ? Resources.query(cmd.Source) : Resources.query(cmd.Source, cmd.Match);
        //     var count = query.ResourceCount;

        //     if(count == 0)
        //         wf.Warn(Msg.NoMatchingResources.Format(cmd.Source, cmd.Match));
        //     else
        //         wf.Status(Msg.EmittingResources.Format(cmd.Source, count));

        //     if(cmd.ClearTarget)
        //         cmd.Target.Clear();

        //     var invalid = Path.GetInvalidPathChars();
        //     var descriptors = query.Descriptors();
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var descriptor = ref skip(descriptors,i);
        //         var emission = ResDataEmitter.emit(descriptor, cmd.Target);
        //         wf.EmittedFile((uint)descriptor.Size, emission.Target);
        //     }
        //     return Cmd.ok(cmd);
        // }
    }
}