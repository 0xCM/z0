//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Seed;

    public readonly struct Capture
    {
        public static ICaptureServices Services 
            => default(AsmWorkflows);

        public static ICaptureService Service 
            => new CaptureService();                     
    }
}