//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CaptureServices : TCaptureServices
    {
        public static ICaptureServices Service => default(CaptureServices);

        public ICaptureCore CaptureCore
            => Asm.CaptureCore.Service;
    }
}