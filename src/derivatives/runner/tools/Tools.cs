//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Derivatives.Scalar;

    using static Konst;


    [ApiHost]
    public partial struct Tools : IDisposable
    {
        readonly IWfShell Wf;

        readonly ToolPaths Paths;

        readonly WfStepId StepId;

        [MethodImpl(Inline)]
        public Tools(IWfShell wf)
        {
            Wf = wf;
            Paths = new ToolPaths();
            StepId = typeof(Tools);
        }

        [MethodImpl(Inline), Op]
        public IlDasm ildasm(params string[] args)
            => new IlDasm(Paths.IlDasm, args);

        [MethodImpl(Inline), Op]
        public static string format(ToolCommand src)
            => src.Format();


        public ProcessResult Run(ToolCommand src)
        {
            var result = ProcessHelper.Run(src.ToolPath.Name, src.Args.Format());
            Wf.Status(StepId,result.Output);
            return result;
        }

        public void Dispose()
        {

        }
    }
}