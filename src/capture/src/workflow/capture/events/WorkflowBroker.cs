//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    sealed class CaptureBroker : EventBroker, ICaptureBroker
    {
        public static ICaptureBroker Service => new CaptureBroker();           
    }

    public partial class CaptureWorkflowEvents
    {
       
    }    
}