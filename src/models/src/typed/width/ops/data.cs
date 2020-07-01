//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = DataWidth;

    partial class Widths
    {        
        /// <summary>
        /// Computes the literal data width from a parametric width
        /// </summary>
        /// <typeparam name="W">The parametric width</typeparam>
        [MethodImpl(Inline)]
        public static K data<W>(W w = default)
            where W : struct, IDataWidth
        {
            if(typeof(K) == typeof(W1))
                return K.W1;
            else if(typeof(W) == typeof(W8))
                return K.W8;
            else if(typeof(W) == typeof(W16))
                return K.W16;
            else if(typeof(W) == typeof(W32))
                return K.W32;
            else if(typeof(W) == typeof(W64))
                return K.W64;
            else 
                return data_128<W>();
        }

        [MethodImpl(Inline)]
        static K data_128<W>()
            where W : struct, IDataWidth
        {
            if(typeof(W) == typeof(W128))
                return K.W128;
            else if(typeof(W) == typeof(W256))
                return K.W256;
            else if(typeof(W) == typeof(W512))
                return K.W512;
            else if(typeof(W) == typeof(W1024))
                return K.W1024;
            else
                return 0;
        }
    }
}