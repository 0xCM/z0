//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    using D = Z0;

    [ApiHost(ApiNames.XSFx, true)]
    public static partial class XSFx
    {

    }

    /// <summary>
    /// Defines surrogate api - a facility for defining structural functions over delegates
    /// </summary>
    [ApiHost(ApiNames.SFxSurrogates, true)]
    public partial class Surrogates
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines a delegate-predicated structural emitter
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Emitter<T> emitter<T>(D.Emitter<T> f, string name, T t = default)
            => new Emitter<T>(f,name);

        /// <summary>
        /// Defines a delegate-predicated structural operator
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp<T> unary<T>(D.UnaryOp<T> f, string name, T t = default)
            => new UnaryOp<T>(f,name);

        /// <summary>
        /// Defines a delegate-predicated structural operator
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp<T> binary<T>(D.BinaryOp<T> f, string name, T t = default)
            => new BinaryOp<T>(f, name);

        /// <summary>
        /// Defines a delegate-predicated structural operator
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TernaryOp<T> ternary<T>(D.TernaryOp<T> f, string name, T t = default)
            => new TernaryOp<T>(f,name);

        /// <summary>
        /// Defines a delegate-predicated structural predicate
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryPredicate<T> predicate<T>(D.UnaryPredicate<T> f, string name, T t = default)
            => new UnaryPredicate<T>(f,name);

        /// <summary>
        /// Defines a delegate-predicated structural predicate
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryPredicate<T> predicate<T>(D.BinaryPredicate<T> f, string name, T t = default)
            => new BinaryPredicate<T>(f,name);

        /// <summary>
        /// Defines an identified structural emitter predicated on a delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="id">The sfunc identity</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The emission type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Emitter<T> emitter<T>(D.Emitter<T> f, OpIdentity id, T t = default)
            => new Emitter<T>(f,id);

        /// <summary>
        /// Defines a delegate-predicated structural operator with identity
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="id">The sfunc identity</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp<T> unary<T>(D.UnaryOp<T> f, OpIdentity id, T t = default)
            => new UnaryOp<T>(f,id);

        /// <summary>
        /// Defines a delegate-predicated structural operator with identity
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="id">The sfunc identity</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp<T> binary<T>(D.BinaryOp<T> f, OpIdentity id, T t = default)
            => new BinaryOp<T>(f,id);

        /// <summary>
        /// Defines a delegate-predicated structural operator with identity
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="id">The sfunc identity</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TernaryOp<T> ternary<T>(D.TernaryOp<T> f, OpIdentity id, T t = default)
            => new TernaryOp<T>(f,id);

        /// <summary>
        /// Defines a delegate-predicated structural predicate with identity
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="id">The sfunc identity</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryPredicate<T> predicate<T>(D.UnaryPredicate<T> f, OpIdentity id, T t = default)
            => new UnaryPredicate<T>(f,id);

        /// <summary>
        /// Defines a delegate-predicated structural predicate with identity
        /// </summary>
        /// <param name="f">The source delegate</param>
        /// <param name="id">The sfunc identity</param>
        /// <param name="t">An operand type representative to aid type inference</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryPredicate<T> predicate<T>(D.BinaryPredicate<T> f, OpIdentity id, T t = default)
            => new BinaryPredicate<T>(f,id);
    }
}