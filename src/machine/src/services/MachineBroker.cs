//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    sealed class MachineBroker : EventBroker, IMachineBroker
    {
        public static IMachineBroker New => new MachineBroker();           
    }
}