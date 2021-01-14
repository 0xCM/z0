//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;

    using static z;
    using static WfEvents;


    partial interface IWfShell
    {
        void Error<T>(WfStepId step, T body)
        {
            signal(this).Error(step, body);
        }

        void Error(WfStepId step, Exception e)
        {
            signal(this).Error(step, e);
        }

        void Error(Exception e)
        {
            signal(this).Error(e);
        }

        void Error<T>(T body)
        {
            signal(this).Error(body);
        }

        WfExecToken Error(WfExecFlow flow, WfStepId step, Exception e)
        {
            signal(this).Error(step, e);
            return Ran(flow);
        }

        WfExecToken Error<T>(WfExecFlow flow, T body)
        {
            signal(this).Error(body);
            return Ran(flow);
        }

        WfExecToken Error(WfExecFlow flow, Exception e)
        {
            signal(this).Error(e);
            return Ran(flow);
        }
    }
}