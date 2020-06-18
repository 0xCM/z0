//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ICaptureWorkflow : ICaptureSteps
    {
        ICaptureBroker Broker {get;}

        void Run(AsmArchiveConfig config, params PartId[] parts);         
    }

}