//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;
    using static Konst;
    using static ApiDataModel;

    struct Workers : IWfService<Workers>
    {
        WfHost Host;

        IWfShell Wf;

        public void Init(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(Workers));
            Wf = wf.WithHost(Host);
        }

        [CmdWorker]
        public CmdResult Route(EmitHexIndexCmd cmd)
        {
            var dst = Wf.Db().Table("apihex.index");
            var descriptors = ApiCode.BlockDescriptors(Wf);
            var count= ApiCode.emit(descriptors, dst);
            Wf.EmittedTable<CodeBlockDescriptor>(count, dst);
            return Cmd.ok(cmd);
        }

        [CmdWorker]
        public CmdResult Route(EmitRuntimeIndexCmd cmd)
        {
            var hosts = Wf.Api.ApiHosts;
            var kHost = (uint)hosts.Length;
            Wf.Status(Status.IndexingHosts.Apply(kHost));

            var members  = @readonly(ApiRuntime.index(Wf));
            var target = Wf.Db().IndexFile("api.members");
            using var writer = target.Writer();
            var count = members.Length;
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                ApiRuntime.render(skip(members, i), buffer);
                writer.WriteLine(buffer.Emit());
            }

            return Cmd.ok(cmd);
        }

        [CmdWorker]
        public CmdResult Route(EmitResourceDataCmd cmd)
            => exec(Wf, cmd);

        public static CmdResult exec(IWfShell wf, EmitResourceDataCmd cmd)
        {
            var query = cmd.Match.IsEmpty ? Resources.query(cmd.Source) : Resources.query(cmd.Source, cmd.Match);
            var count = query.ResourceCount;

            if(count == 0)
                wf.Warn(Warnings.NoMatchingResources.Apply(cmd.Source, cmd.Match));
            else
                wf.Status(Status.EmittingResources.Apply(cmd.Source, count));

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