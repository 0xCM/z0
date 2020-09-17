//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static Flow;
    using static z;

    public interface IWfStatus : IWfEvent
    {

    }

    public interface IWfStatus<T> : IWfStatus
    {
        WfPayload<T> Content {get;}
    }


    public interface IWfTrace<T> : IWfEvent
    {
        WfPayload<T> Content {get;}
    }
}