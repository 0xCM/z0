//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CallerTarget : IArrow<CallerTarget, OpUri, MemoryAddress>
    {
        [MethodImpl(Inline)]
        public static CallerTarget Define(OpUri src, MemoryAddress dst)
            => new CallerTarget(src, dst);
        
        [MethodImpl(Inline)]
        CallerTarget(OpUri src, MemoryAddress dst)
        {
            this.Src = src;
            this.Dst = dst;
            this.Identifier = Arrows.connect(src,dst).Format();
        }

        public OpUri Src {get;}

        public MemoryAddress Dst {get;}

        public string Identifier {get;}
    }

    
}