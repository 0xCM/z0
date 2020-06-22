//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEvalExecutor
    {
        EvalResult ExecAction(Action action, OpUri f);   

        EvalResult ExecAction(Action action, OpUri f, OpUri g);
    }    
}