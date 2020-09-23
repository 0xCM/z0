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
        [MethodImpl(Inline)]
        static NumericKind nkind<T>(T t = default)
            => NumericKinds.kind<T>();

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
        /// Produces an identifier for a kinded generic vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vgeneric<W,T>(ApiKeyId k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                => ApiIdentity.build(vname(k), w.TypeWidth, nkind(t), true);

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static OpIdentity sfunc<T>(ApiKeyId k, T t = default)
            => ApiIdentity.NumericOp(name(k), nkind(t));

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="nk">The operation numeric kind</param>
        public static OpIdentity sfunc(ApiKeyId k, NumericKind nk)
            => ApiIdentity.NumericOp(name(k), nk);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc(ApiKeyId k, TypeWidth w, NumericKind nk, bool generic = true)
            => ApiIdentity.build(name(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc<T>(ApiKeyId k, TypeWidth w, T t = default, bool generic = true)
            where T : unmanaged
                => ApiIdentity.build(name(k), w, nkind(t), generic);

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
                => ApiIdentity.build(name(k), w.TypeWidth, nkind(t), generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector width</param>
        /// <param name="nk">The cell numeric kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity vsfunc(ApiKeyId k, TypeWidth w, NumericKind nk, bool generic = true)
            => ApiIdentity.build(vname(k), w, nk, generic);

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
                => ApiIdentity.build(vname(k), w, nkind(t), generic);

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
                => ApiIdentity.build(vname(k), w.TypeWidth, nkind(t), generic);
    }
}