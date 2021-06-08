//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class WorkflowRunner<T> : AppService<T>
        where T : WorkflowRunner<T>, new()
    {

    }

}