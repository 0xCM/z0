//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum NodeKind : byte
    {
        None = 0,

        Receiver = 1,

        Emitter = 2,

        Transport = 4 | Receiver | Emitter,

        UnaryReceiver = 8 | Receiver,

        UnaryEmitter = 16 | Emitter,

        UnaryTransport = 32 | Transport | UnaryReceiver | UnaryEmitter,

        Leaf = 64 | Receiver,
    }
}