//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class OpId
    {
        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric(string opname, NumericKind k, bool generic)
            => Identity.operation(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric(string opname, NumericKind k)
            => Identity.operation(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric<T>(string opname, NumericType<T> hk = default, bool generic = true)
            where T : unmanaged
                => Identity.operation(opname, FixedWidth.None, typeof(T).NumericKind(), generic);       

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity fixedop(string opname, FixedWidth w, NumericKind nk)
            => Identity.operation(opname,w,nk,false);
    }
}