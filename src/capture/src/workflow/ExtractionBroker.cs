//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    sealed class ExtractionBroker : EventBroker, IExtractionBroker
    {
        [MethodImpl(Inline)]
        public new static IExtractionBroker Create()
            => new ExtractionBroker();
    }
}