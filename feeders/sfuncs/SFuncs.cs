//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.SFuncs)]

namespace Z0.Parts
{        
    public sealed class SFuncs : Part<SFuncs>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static refs;

    public static partial class SFuncs
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        public static void iter<F>(F f, int count)
            where F : ISAction<int>
        {                        
            for(var i=0; i<count; i++)
                f.Invoke(i);
        }

        [MethodImpl(Inline)]
        public static void map<F,T>(F f, in T src, ref T dst, int count)
            where F : ISUnaryOpApi<T>
        {                        
            for(var i=0; i<count; i++)
                seek(ref dst, i) = f.Invoke(skip(src, i));                
        }

    }
}
