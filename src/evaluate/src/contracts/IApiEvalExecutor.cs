//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiEvalExecutor
    {
        ApiEvalResult ExecAction(Action action, OpUri f, OpUri g);
    }
}