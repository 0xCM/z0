//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public partial class AsmCases : WfService<AsmCases>
    {

    }

    public sealed class AsmCaseRunner : WfService<AsmCaseRunner>
    {
        public void Run()
        {
            var flow = Wf.Running();

            Wf.Ran(flow);
        }
    }

    public readonly partial struct AsmCaseCode
    {

    }
}