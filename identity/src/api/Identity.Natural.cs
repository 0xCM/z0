//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class Identity
    {
                
        /// <summary>
        /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity contracted<T>(string opname, N128 w, bool generic = true)
            where T : unmanaged
                => NaturalIdentity.contracted(opname,w, Numeric.kind<T>(), generic);

        /// <summary>
        /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity contracted<T>(string opname, N256 w, bool generic = true)
            where T : unmanaged
                => NaturalIdentity.contracted(opname, w, Numeric.kind<T>(), generic);
    }
}