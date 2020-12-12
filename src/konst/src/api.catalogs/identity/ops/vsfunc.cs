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
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static OpIdentity sfunc<T>(string opname, Vec512Kind<T> k)
            where T : unmanaged
                => build(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);
    }
}