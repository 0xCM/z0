//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static Root;
    using static VKT;

    public static class VK
    {
        /// <summary>
        /// Reifies a non-parametric vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec vk()
            => default;

        /// <summary>
        /// Reifies a non-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128 vk128()
            => default;

        /// <summary>
        /// Reifies a cell-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<T> vk128<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a non-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256 vk256()
            => default;

        /// <summary>
        /// Reifies a cell-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<T> vk256<T>(T t = default)
            where T : unmanaged
                => default;
    }

}