//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Publishers
    {
        public ListPublisher ListPubliser
        {
            [MethodImpl(Inline)]
            get => Z0.ListPublisher.Service;
        }

        public LiteralPublisher LiteralPublisher
        {
            [MethodImpl(Inline)]
            get => Z0.LiteralPublisher.Service;
        }

        public RecordPublisher RecordPubliser
        {
            [MethodImpl(Inline)]
            get => Z0.RecordPublisher.Service;
        }
    }

}