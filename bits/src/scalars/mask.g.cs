//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class gbits
    {

        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extendint to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static T lomask<N,T>()
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => convert<ulong,T>(Bits.lomask<N>());

        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extendint to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static T lomask<T>(int n)
            where T : unmanaged
                => convert<ulong,T>(Bits.lomask(n));

    }

}