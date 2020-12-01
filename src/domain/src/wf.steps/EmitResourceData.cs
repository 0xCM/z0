//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    sealed class EmitResourceData : CmdReactor<EmitResourceDataCmd, CmdResult>
    {
        protected override CmdResult Run(EmitResourceDataCmd cmd)
            => run(Wf, cmd);

        public static CmdResult run(IWfShell wf, EmitResourceDataCmd cmd)
        {
            var query = cmd.Match.IsEmpty ? Resources.query(cmd.Source) : Resources.query(cmd.Source, cmd.Match);
            var count = query.ResourceCount;

            if(count == 0)
                wf.Warn(Msg.NoMatchingResources.Format(cmd.Source, cmd.Match));
            else
                wf.Status(Msg.EmittingResources.Format(cmd.Source, count));

            if(cmd.ClearTarget)
                cmd.Target.Clear();

            var invalid = Path.GetInvalidPathChars();
            var descriptors = query.Descriptors();
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                var name =  descriptor.Name.ToString().ReplaceAny(invalid, Chars.Underscore);
                var target = cmd.Target + FS.file(name);
                var utf = Resources.utf8(descriptor);
                using var writer = target.Writer();
                writer.Write(utf);
                wf.EmittedFile(utf.Length, target);
            }
            return Cmd.ok(cmd);
        }
    }
}