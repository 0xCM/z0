//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public sealed class CaptureBroker : WfBroker, ICaptureBroker
    {   
        CaptureBroker(FilePath target)
            : base(target)
        {

        }

        public static ICaptureBroker create(FilePath target)
            => new CaptureBroker(target);           
    }
}