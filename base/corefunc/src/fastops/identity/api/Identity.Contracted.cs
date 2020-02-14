//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class Identity
    {
        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity contracted<T>(string opname, T t = default)
            => operation(opname,typeof(T).NumericKind());

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity contracted<W,T>(string opname, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => operation(opname,(FixedWidth)nateval<W>(), Numeric.kind<T>(), generic);
                
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
                => contracted(opname,w, Numeric.kind<T>(), generic);

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
                => contracted(opname, w, Numeric.kind<T>(), generic);
    }
}