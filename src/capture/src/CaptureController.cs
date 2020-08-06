//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public readonly struct CaptureController
    {
        public const string ActorName = nameof(CaptureControl);        

        public static CaptureControl create(IAppContext root, CorrelationToken ct, params string[] args)
            => new CaptureControl(root, ct, args);
    }
}