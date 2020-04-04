//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using K = VectorWidth;

    partial class Widths
    {        
        [MethodImpl(Inline)]
        public static VectorWidth vector<W>(W w = default)
            where W : struct, IVectorWidth
        {            
            if(typeof(W) == typeof(W128))
                return K.W128;
            else if(typeof(W) == typeof(W256))
                return K.W256;
            else if(typeof(W) == typeof(W512))
                return K.W512;
            else
                return 0;
        }
    }
}