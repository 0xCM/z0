//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfStepExec<T> : IWfStep
    {
        T Run(IWfShell wf, WfFuncArgs args)
        {
            Configure(args);
            return Run(wf);
        }

        void Configure(WfFuncArgs args) { }

        T Run(IWfShell wf);

        Outcome<T> Try(IWfShell wf)
        {
            try
            {
                return Run(wf);
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }

    [Free]
    public interface IWfStepExec<S,T> : IWfStep<S>, IWfStepExec<T>
        where S : struct, IWfStepExec<S,T>
    {
    }

    [Free]
    public interface IWfStepExec<H,S,T> : IWfStep<H>
        where H : struct, IWfStepExec<H,S,T>
    {

        T Run(IWfShell wf, in S src);

        Outcome<T> Try(IWfShell wf, in S src)
        {
            try
            {
                return Run(wf, src);
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}