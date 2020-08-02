//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    public readonly struct CaptureServices : TCaptureServices
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static TCaptureServices create(IAsmContext context) 
            => new CaptureServices(context);

        [MethodImpl(Inline)]
        internal CaptureServices(IAsmContext context) 
            => Context = context;
    }
}