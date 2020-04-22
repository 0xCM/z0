//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;
    using static BufferSeqId;

    public interface IAsmTester : IService<IAsmContext>, IBufferedTester, ITestDynamic, ICheckVectors 
    {
        ICaptureService CaptureService => Context.CaptureService;

        IAsmFunctionDecoder Decoder => Context.Decoder;

        ICaptureExchange Exchange => CaptureExchangeProxy.Create(Context.CaptureControl, this[Aux3], this[Aux4]);
    }
}