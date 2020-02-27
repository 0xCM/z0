//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Delegate contract for capture event receipt
    /// </summary>
    /// <param name="data">The event data</param>
    public delegate void CaptureEventObserver(in CaptureEventData data);

}