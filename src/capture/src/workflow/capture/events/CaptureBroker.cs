//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class CaptureBroker : WfBroker, ICaptureBroker
    {   
        CaptureBroker(FilePath target, CorrelationToken? ct)
            : base(target, ct)
        {

        }

        public static ICaptureBroker create(FilePath target, CorrelationToken? ct = null)
            => new CaptureBroker(target, ct);           
    }
}