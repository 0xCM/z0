//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct Moniker
    {
        /// <summary>
        /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string define<T>(T t = default)
            => $"{bitsize(t)}{indicator(t)}";

        /// <summary>
        /// Produces a canonical designator of the form {op}_{bitsize[T]}{u | i | f} for an operation over a primal type
        /// </summary>
        /// <param name="name">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string define<T>(string name, T t = default)
            => $"{name}_{bitsize(t)}{indicator(t)}";

        /// <summary>
        /// Produces a canonical designator of the form {W}X{bitsize[T]}{u | i | f} for a segmented WxT type or classification
        /// </summary>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static string define<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
                => $"{w}x{define(t)}";

        /// <summary>
        /// Produces a canonical designator of the form {op}_{W}X{bitsize[T]}{u | i | f} for an operation over a segmented WxT type or classification
        /// </summary>
        /// <param name="name">The base operator name/operator classifier</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static string define<W,T>(string name, W w = default, T t = default)
            where W : unmanaged, ITypeNat
                => $"{name}_{w}x{define(t)}";

        /// <summary>
        /// The moniker text
        /// </summary>
        public readonly string Text;

        [MethodImpl(Inline)]
        internal Moniker(string text)
            => this.Text = text;

        public override string ToString()
            => Text;

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        static char indicator<T>(T t = default)
            => Primitive.floating(t) ? AsciLower.f : (Primitive.signed(t) ? AsciLower.i : AsciLower.u);

    }

}