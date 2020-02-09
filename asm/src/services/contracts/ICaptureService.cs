//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static zfunc;

    using AsmSpecs;

    /// <summary>
    /// Amalgamates asm/native capture and extraction services
    /// </summary>
    public interface ICaptureService : INativeCapture, IAsmCapture, IAsmExtractor, INativeExtractor
    {

    } 

}