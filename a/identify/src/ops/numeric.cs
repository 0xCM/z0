//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class Identify
    {
        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static NumericIdentity numeric(NumericKind nk)
            => NumericIdentity.Define(nk);

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numeric<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(typeof(T).NumericKind().Format());

        public static TypeIdentity numeric(string prefix, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.Define($"{prefix}{width}{indicator}");
        }
    }
}