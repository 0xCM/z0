//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public readonly struct HostCaptureConfig 
    {
        [MethodImpl(Inline)]
        public static HostCaptureConfig Define(FolderPath root)
            => new HostCaptureConfig(root);

        [MethodImpl(Inline)]
        public HostCaptureConfig(FolderPath root)
        {
            this.EmissionRoot = root;
        }

        public FolderPath EmissionRoot {get;}
    }
}