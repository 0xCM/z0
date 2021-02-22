//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    [ApiHost]
    public readonly partial struct Llvm
    {
        [Op]
        public static Llvm service(IWfShell wf)
            => new Llvm(wf);
    }
}