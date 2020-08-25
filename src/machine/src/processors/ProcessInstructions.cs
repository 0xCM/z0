//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using static Konst;

    public class ProcessInstructions
    {
        public static ProcessInstructions create(IWfContext wf)
            => new ProcessInstructions(wf);

        public IWfContext Wf {get;}

        readonly ProcessAsmJmp Processor;

        public ProcessInstructions(IWfContext wf)
        {
            Wf = wf;
            Processor = AsmProcessors.jmp(wf);
        }

        public void Run(PartAsmFx src)
        {
            Process(src);
        }

        public void Process(PartAsmFx src)
        {
            AsmProcessors.parts(Wf).Process(src);
            RenderSemantic.Render(src);
        }
    }
}