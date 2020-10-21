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

    public sealed class EmitRenderPatterns : WfHost<EmitRenderPatterns>
    {
        Type Source;

        FS.FilePath Target;

        public static WfHost create(Type src, FS.FilePath dst)
        {
            var host = create();
            host.Source = src;
            host.Target = dst;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using  var step = new EmitRenderPatternsStep(wf, this, Source, Target);
            step.Run();
        }
    }

    public ref struct EmitRenderPatternsStep
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Type Source;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitRenderPatternsStep(IWfShell wf, WfHost host, Type src, FS.FilePath dst)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Source = src;
            Target = dst;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
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

        public void Run()
        {
            Wf.Running();

            try
            {
                using var writer = Target.Writer();
                var patterns = sources(Source);
                var view = patterns.View;
                var count = view.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(skip(view,i).Format());
                Wf.EmittedFile(count, Target);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }
    }
}