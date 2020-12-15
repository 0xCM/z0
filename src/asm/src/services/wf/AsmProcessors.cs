//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct AsmProcessors
    {
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