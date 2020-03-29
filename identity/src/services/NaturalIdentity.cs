//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;

    /// <summary>
    /// Exposes a basic api for natural negotiation and defines static properties
    /// that present the values of common natural numbers
    /// </summary>
    public static class NaturalIdentity
    {
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
                => Identify.Op(opname, (TypeWidth)Nats.nateval<W>(), NumericTypes.kind<T>(), generic);

    }
}