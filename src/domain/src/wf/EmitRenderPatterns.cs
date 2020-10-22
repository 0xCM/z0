//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Cmd]
    public struct EmitRenderPatternsCmd : ICmdSpec<EmitRenderPatternsCmd>
    {
        public Type Source;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitRenderPatternsCmd(Type src, FS.FilePath dst)
        {
            Source = src;
            Target = dst;
        }
    }

    [CmdHost, ApiHost]
    public sealed class EmitRenderPatterns : CmdHost<EmitRenderPatterns, EmitRenderPatternsCmd>
    {
        [Op]
        public static EmitRenderPatternsCmd specify(IWfShell wf, Type src)
        {
            var dst = wf.Db().Doc("render.patterns", src.Name, ArchiveFileKinds.Csv);
            return new EmitRenderPatternsCmd(src,dst);
        }

        [Op]
        public static RenderPatternSources sources(Type src)
        {
            var values = src.LiteralFieldValues<string>(out var fields);
            var count = values.Length;
            var buffer = alloc<RenderPatternSource>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new RenderPatternSource(skip(fields,i), skip(values,i));
            return buffer;
        }

        [Op]
        public static new CmdResult run(IWfShell wf, in EmitRenderPatternsCmd spec)
        {
            using var writer = spec.Target.Writer();
            var patterns = sources(spec.Source);
            var view = patterns.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(view,i).Format());
            wf.EmittedFile(count, spec.Target);
            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitRenderPatternsCmd spec)
            => run(wf, spec);
    }
}