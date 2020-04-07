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
        public static void map<F,T>(F f, in T src, ref T dst, int count)
            where F : ISUnaryOpApi<T>
        {                        
            for(var i=0; i<count; i++)
                seek(ref dst, i) = f.Invoke(skip(src, i));                
        }
    }
}