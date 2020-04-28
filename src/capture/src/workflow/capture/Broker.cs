//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    sealed class HostCaptureBroker : EventBroker, IHostCaptureBroker
    {
        public static IHostCaptureBroker New => new HostCaptureBroker();           
    }
}