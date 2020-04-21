//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Seed;

    partial class Identify
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
                => Identify.Op(opname, (TypeWidth)TypeNats.value<W>(), NumericKinds.kind<T>(), generic);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(string opname)
            => Identify.NumericOp(opname, typeof(T).NumericKind());

        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(IOpKind kind)
            => Identify.NumericOp(kind.KindId.ToString(), typeof(T).NumericKind());

        [MethodImpl(Inline)]   
        public static OpIdentity vfunc<T>(IOpKind kind, W128 w, bool generic = true)
            => Identify.Op(kind.KindId.ToString(), w.TypeWidth, NumericKinds.kind<T>(), generic);

        [MethodImpl(Inline)]   
        public static OpIdentity vfunc<T>(IOpKind kind, W256 w, bool generic = true)
            => Identify.Op(kind.KindId.ToString(), w.TypeWidth, NumericKinds.kind<T>(), generic);

        [MethodImpl(Inline)]   
        public static OpIdentity vfunc<T>(IOpKind kind, W512 w, bool generic = true)
            => Identify.Op(kind.KindId.ToString(), w.TypeWidth, NumericKinds.kind<T>(), generic);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(string opname, Vec128Kind<T> k)
            where T : unmanaged
                => Identify.Op(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(string opname, Vec256Kind<T> k)
            where T : unmanaged
                => Identify.Op(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);        
    }
}