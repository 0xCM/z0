//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    sealed class CaptureBroker : EventBroker, ICaptureBroker
    {
        public static ICaptureBroker New => new CaptureBroker();           
    }

    public partial class CaptureWorkflowEvents
    {

        
    }    
}