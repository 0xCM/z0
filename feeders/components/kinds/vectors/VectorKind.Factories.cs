//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public static class VK
    {
        /// <summary>
        /// Reifies a non-parametric vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static VectorTypeKind vk()
            => default;

        /// <summary>
        /// Reifies a non-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128Kind vk128()
            => default;

        /// <summary>
        /// Reifies a cell-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128Kind<T> vk128<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a non-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256Kind vk256()
            => default;

        /// <summary>
        /// Reifies a cell-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256Kind<T> vk256<T>(T t = default)
            where T : unmanaged
                => default;
    }
}