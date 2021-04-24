//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public partial class AsmCases : AppService<AsmCases>
    {

    }

    public sealed class AsmCaseRunner : AppService<AsmCaseRunner>
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