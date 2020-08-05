//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class CaptureBroker : WfBroker, ICaptureBroker
    {   
        CaptureBroker(CorrelationToken ct)
            : base(ct)
        {

        }

        public static ICaptureBroker create(FilePath target, CorrelationToken ct)
            => new CaptureBroker(ct);           
    }
}