//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Produces the canonical name of a kinded operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string name(ApiOpId k)
            => k.Format();

        /// <summary>
        /// Produces the canonical name of a kinded vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string vname(ApiOpId k)
            => k.Format(true);

        /// <summary>
        /// Produces an identifier for a kinded vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <param name="nk">The vector cell kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity vectorized(ApiOpId k, TypeWidth w, NumericKind nk, bool generic)
            => ApiIdentify.build(vname(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded nongeneric vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vdirect<T>(ApiOpId k, TypeWidth w, T t = default)
            where T : unmanaged
                => ApiIdentify.build(vname(k), w, nk(t), false);

        /// <summary>
        /// Produces an identifier for a kinded nongeneric vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vdirect<W,T>(ApiOpId k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                =>  ApiIdentify.build(vname(k), w.TypeWidth, nk(t), false);
    }
}