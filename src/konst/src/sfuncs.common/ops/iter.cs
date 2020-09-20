//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SFx
    {
        [MethodImpl(Inline), Op]
        public static void iter<F>(F f, int count)
            where F : IAction<int>
        {
            for(var i=0; i<count; i++)
                f.Invoke(i);
        }
    }
}