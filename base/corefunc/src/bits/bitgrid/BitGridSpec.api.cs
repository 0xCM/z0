//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class BitGridSpec
    {
        /// <summary>
        /// Computes the number of rows required to store data for a given grid width
        /// </summary>
        /// <param name="width">The bitgrid width, i.e. number of columns</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static int rowcells<T>(int width)
            where T : unmanaged
        {
            if(bitsize<T>() >= width)
                return 1;
            var q = width / bitsize<T>();
            var r = width % bitsize<T>();
            return q + (r != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the number of rows required to store data for a given grid width
        /// </summary>
        /// <param name="width">The bitgrid width, i.e. number of columns</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static int rowcells<N,T>(N w = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            if(bitsize<T>() >= natval(w))
                return 1;

            var q = natval(w) / bitsize<T>();
            var r = natval(w) % bitsize<T>();
            return q + (r != 0 ? 1 : 0);
        }

        /// <summary>
        /// Defines a bit layout grid as determined by specified type parameters
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="rep"></param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        public static BitGridSpec<T> define<M,N,T>(M m = default, N n = default, T rep = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGridSpec<T>(bitsize<T>(), natval(m), natval(n));
    }
}