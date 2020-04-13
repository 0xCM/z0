//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
  
    partial class Kinds
    {
        /// <summary>
        /// Specifies the nonparametric v128 kind
        /// </summary>
        public static Vec128Kind v128 => default;

        /// <summary>
        /// Specifies the nonparametric v256 kind
        /// </summary>
        public static Vec256Kind v256 => default;

        /// <summary>
        /// Specifies the nonparametric v512 kind
        /// </summary>
        public static Vec512Kind v512 => default;

        /// <summary>
        /// Reifies a cell-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128Kind<T> vk128<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a cell-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256Kind<T> vk256<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a cell-parametric 512-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec512Kind<T> vk512<T>(T t = default)
            where T : unmanaged
                => default;
    }
}