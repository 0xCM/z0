//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Konst;
    using static z;

    [Cmd]
    public struct EmitResourceContentCmd : ICmdSpec<EmitResourceContentCmd>
    {
        public Assembly Source;

        public FS.FolderPath Target;

        [MethodImpl(Inline)]
        public EmitResourceContentCmd(Assembly src, FS.FolderPath dst)
        {
            Source = src;
            Target = dst;
        }
    }

    [CmdHost, ApiHost]
    public sealed class EmitResourceContent : CmdHost<EmitResourceContent, EmitResourceContentCmd>
    {
        public static EmitResourceContentCmd specify(IWfShell wf, Assembly src)
            => new EmitResourceContentCmd(src, wf.Db().RefDataRoot() + FS.folder("resources"));

        protected override CmdResult Execute(IWfShell wf, in EmitResourceContentCmd spec)
            => run(wf, spec);

        [Op]
        public static CmdResult run(IWfShell wf, in EmitResourceContentCmd spec)
        {
            var descriptors = @readonly(Resources.descriptors(spec.Source));
            var count = descriptors.Length;
            var invalid = Path.GetInvalidPathChars();
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                wf.Status(descriptor);
                var name =  descriptor.Name.ToString().ReplaceAny(invalid, Chars.Underscore);
                var target = spec.Target +  FS.file(name);
                var data = Resources.data(descriptor);
                var utf = Encoded.utf8(data);
                using var writer = target.Writer();
                writer.Write(utf);
                wf.EmittedFile(utf.Length, target);
            }
            return Win();
        }
    }
}