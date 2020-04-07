//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static refs;

    partial class SFuncs
    {
        [MethodImpl(Inline)]
        public static void iter<F>(F f, int count)
            where F : ISAction<int>
        {                        
            for(var i=0; i<count; i++)
                f.Invoke(i);
        }
    }
}