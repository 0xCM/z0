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
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc<T>(ApiKeyId k, TypeWidth w, T t = default, bool generic = true)
            where T : unmanaged
                => ApiIdentify.build(name(k), w, NumericKinds.kind<T>(), generic);

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
                => ApiIdentify.build(name(k), w.TypeWidth, NumericKinds.kind<T>(), generic);

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static OpIdentity sfunc<T>(ApiKeyId k, T t = default)
            => NumericOp(name(k), NumericKinds.kind<T>());

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
            => build(name(k), w, nk, generic);

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static OpIdentity sfunc<W,T>(string opname, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => build(opname, (TypeWidth)TypeNats.value<W>(), NumericKinds.kind<T>(), generic);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static OpIdentity sfunc<T>(string opname)
            => NumericOp(opname, typeof(T).NumericKind());
    }
}