//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Seed;

    public readonly struct VSvcCheck : IVSvcCheck
    {
        [MethodImpl(Inline)]
        public static IVSvcCheck Create(IVSvcCheckContext context)
            => new VSvcCheck(context);

        public IVSvcCheckContext Context {get;}
        
        [MethodImpl(Inline)]
        VSvcCheck(IVSvcCheckContext context)
        {
            Context = context;
        }
    }
}