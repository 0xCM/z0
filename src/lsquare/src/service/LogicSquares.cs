//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Seed;
    using static Memories;

    public partial class LogicSquares
    {
        [MethodImpl(Inline)]
        public static Not<W,T> not<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => sfunc(w, sfunc<Not<W,T>>(), t);

        [MethodImpl(Inline)]
        public static And<W,T> and<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => sfunc(w, sfunc<And<W,T>>(), t);                
    }
}