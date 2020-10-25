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

    [Cmd(Code)]
    public struct EmitResourceContentCmd : ICmdSpec<EmitResourceContentCmd>
    {
        public static EmitResourceContentCmd specify(IWfShell wf, Assembly src, string id, string match = null)
            => new EmitResourceContentCmd(src, wf.Db().RefDataRoot() + FS.folder(id), match);

        public const string Code = CmdCodes.EmitRes;

        public Assembly Source;

        public FS.FolderPath Target;

        public string Match;

        [MethodImpl(Inline)]
        public EmitResourceContentCmd(Assembly src, FS.FolderPath dst, string filter = null)
        {
            Source = src;
            Target = dst;
            Match = filter ?? EmptyString;
        }
    }

    [CmdHost, ApiHost]
    public sealed class EmitResourceContent : CmdHost<EmitResourceContent, EmitResourceContentCmd>
    {
        protected override CmdResult Execute(IWfShell wf, in EmitResourceContentCmd spec)
            => run(wf, spec);

        [Op]
        public static CmdResult run(IWfShell wf, in EmitResourceContentCmd spec)
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