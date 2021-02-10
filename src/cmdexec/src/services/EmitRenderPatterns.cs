//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    [ApiHost]
    public sealed class RenderPatternEmitter : WfService<RenderPatternEmitter, RenderPatternEmitter>
    {
        public void Emit(Type src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var patterns = sources(src);
            var view = patterns.View;

            var count = view.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(view,i).Format());

            Wf.EmittedFile(flow, (Count)count, dst);

        }
        [Op]
        public static EmitRenderPatternsCmd specify(IWfShell wf, Type src)
        {
            var dst = wf.Db().Doc("render.patterns", src.Name, FileExtensions.Csv);
            var cmd = new EmitRenderPatternsCmd();
            cmd.Source = src;
            cmd.Target = dst;
            return cmd;
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
        public static CmdResult run(IWfShell wf, in EmitRenderPatternsCmd cmd)
        {
            using var writer = cmd.Target.Writer();
            var patterns = sources(cmd.Source);
            var view = patterns.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(view,i).Format());
            wf.EmittedFile(count, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}