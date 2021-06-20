//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICmdDispatcher
    {
        Outcome Dispatch(string command, params object[] args);

        ReadOnlySpan<string> Supported {get;}
    }
}