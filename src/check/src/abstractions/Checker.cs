//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class Checker<H,C> : WfService<H,C>, IOperationChecker
        where H : Checker<H,C>, new()
    {
        public static H create(IWfShell wf, OpUri op)
        {
            var checker = create(wf);
            checker.Operation = op;
            return checker;
        }

        public OpUri Operation {get; private set;}
    }
}