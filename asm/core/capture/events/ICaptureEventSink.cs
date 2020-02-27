//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines contract for external observation of the capture workflow
    /// </summary>
    public interface ICaptureEventSink : ISink
    {
        void Accept(in CaptureEventData data);
    }
}