//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class ApiIdentityKinds
    {
        /// <summary>
        /// Produces the canonical name of a kinded operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string name(ApiKeyId k)
            => k.Format();

        /// <summary>
        /// Produces the canonical name of a kinded vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string vname(ApiKeyId k)
            => k.Format(true);

        /// <summary>
        /// Produces an identifer for a kinded numeric operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="nk">The operation numeric kind</typeparam>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity numeric(ApiKeyId k,  NumericKind nk, bool generic = false)
            => NumericOp(name(k), nk, generic);

        /// <summary>
        /// Produces an identifer for a kinded numeric operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="T">The operation numeric kind</typeparam>
        public static OpIdentity numeric<T>(ApiKeyId k, T t = default, bool generic = false)
            where T : unmanaged
                =>  NumericOp<T>(name(k),  generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <param name="nk">The vector cell kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity vectorized(ApiKeyId k, TypeWidth w, NumericKind nk, bool generic)
            =>  ApiIdentityBuilder.build(vname(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded nongeneric vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vdirect<T>(ApiKeyId k, TypeWidth w, T t = default)
            where T : unmanaged
                =>  ApiIdentityBuilder.build(vname(k), w, nkind(t), false);

        /// <summary>
        /// Produces an identifier for a kinded nongeneric vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vdirect<W,T>(ApiKeyId k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                =>  ApiIdentityBuilder.build(vname(k), w.TypeWidth, nkind(t), false);

        /// <summary>
        /// Produces an identifier for a kinded generic vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vgeneric<W,T>(ApiKeyId k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                => ApiIdentityBuilder.build(vname(k), w.TypeWidth, nkind(t), true);

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static OpIdentity sfunc<T>(ApiKeyId k, T t = default)
            => NumericOp(name(k), nkind(t));

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="nk">The operation numeric kind</param>
        public static OpIdentity sfunc(ApiKeyId k, NumericKind nk)
            => NumericOp(name(k), nk);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc(ApiKeyId k, TypeWidth w, NumericKind nk, bool generic = true)
            => ApiIdentityBuilder.build(name(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc<T>(ApiKeyId k, TypeWidth w, T t = default, bool generic = true)
            where T : unmanaged
                => ApiIdentityBuilder.build(name(k), w, nkind(t), generic);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public static OpIdentity sfunc<W,T>(ApiKeyId k, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => ApiIdentityBuilder.build(name(k), w.TypeWidth, nkind(t), generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector width</param>
        /// <param name="nk">The cell numeric kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity vsfunc(ApiKeyId k, TypeWidth w, NumericKind nk, bool generic = true)
            => ApiIdentityBuilder.build(vname(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector width</param>
        /// <param name="nk">The cell numeric kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vsfunc<T>(ApiKeyId k, TypeWidth w, T t = default, bool generic = true)
            where T : unmanaged
                => ApiIdentityBuilder.build(vname(k), w, nkind(t), generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A vector width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="W">The vector width type</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vsfunc<W,T>(ApiKeyId k, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => ApiIdentityBuilder.build(vname(k), w.TypeWidth, nkind(t), generic);
    }
}