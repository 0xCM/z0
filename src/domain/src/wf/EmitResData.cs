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

    [ApiHost]
    public sealed class EmitResData : CmdHost<EmitResData, EmitResDataCmd>
    {
        protected override CmdResult Execute(IWfShell wf, in EmitResDataCmd spec)
            => run(wf, spec);

        [CmdWorker]
        public static CmdResult run(IWfShell wf, EmitResDataCmd spec)
        {
            var query = Resources.query(spec.Source, spec.Match);
            var count = query.ResourceCount;

            if(count == 0)
                wf.Warn(string.Format("No {0} resources found that match {1}", spec.Source.GetSimpleName(), spec.Match));
            else
                wf.Status(string.Format("Emitting {0} resources from {1}", count, spec.Source));

            var invalid = Path.GetInvalidPathChars();
            var descriptors = query.Descriptors();
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                var name =  descriptor.Name.ToString().ReplaceAny(invalid, Chars.Underscore);
                var target = spec.Target + FS.file(name);
                var utf = Resources.utf8(descriptor);
                using var writer = target.Writer();
                writer.Write(utf);
                wf.EmittedFile(utf.Length, target);
            }
            return Win();
        }
    }
}