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
    /// Delegate contract for emission event receipt
    /// </summary>
    /// <param name="data">The event data</param>
    public delegate void CaptureEmissionObserver(in CaptureTokenGroup data);

}