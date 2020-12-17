//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmProcessors
    {
        public static void exec(IWfShell wf, ReadOnlySpan<ApiPartRoutines> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                parts(wf).Process(skip(src,i));
        }

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IApiAsmProcessor create(IWfShell wf)
        {
            var processor = new WfAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static HostAsmProcessor hosts(IWfShell wf, ApiHostRoutines src)
            => new HostAsmProcessor(wf, src);

        [MethodImpl(Inline), Op]
        public static PartAsmProcessor parts(IWfShell wf)
            => new PartAsmProcessor(wf);
    }
}