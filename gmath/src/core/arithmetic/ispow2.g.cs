//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline), ZFunc(PrimalKind.Integral)]
        public static bit ispow2<T>(T src)
            where T : unmanaged
                => math.ispow2(convert<T,ulong>(src));
    }

}