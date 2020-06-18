//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureHostStep : ICaptureStep
    {
        void Execute(IApiHost host, ICaptureArchive dst);
    }
}