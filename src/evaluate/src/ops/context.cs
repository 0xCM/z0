//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
  
    partial struct Evaluate
    {
        [MethodImpl(Inline), Op]
        public static ExecutorContext context(IPolyrand src, uint count)
            => new ExecutorContext(src,count,0);
    }
}