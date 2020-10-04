//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static OpIdentity sfunc<T>(string opname, Vec128Kind<T> k)
            where T : unmanaged
                => build(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static OpIdentity sfunc<T>(string opname, Vec256Kind<T> k)
            where T : unmanaged
                => build(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector width</param>
        /// <param name="nk">The cell numeric kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity vsfunc(ApiKeyId k, TypeWidth w, NumericKind nk, bool generic = true)
            => build(vname(k), w, nk, generic);

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
                => build(vname(k), w, NumericKinds.kind<T>(), generic);

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
                => build(vname(k), w.TypeWidth, NumericKinds.kind<T>(), generic);
    }
}