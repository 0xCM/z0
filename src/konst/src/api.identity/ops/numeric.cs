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
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]
        public static OpIdentity NumericOp(string opname, NumericKind k, bool generic = false)
            => ApiIdentity.build(opname, TypeWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static OpIdentity NumericOp<T>(string opname, bool generic = true)
            where T : unmanaged
                => ApiIdentity.build(opname, TypeWidth.None, nkind<T>(), generic);
    }
}