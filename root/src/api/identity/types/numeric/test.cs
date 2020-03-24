//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Numeric
    {
        /// <summary>
        /// Returns true if the primal source type is signed, false otherwise
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bool signed<T>()
            where T : unmanaged
                => NumericTypes.signed<T>();

        /// <summary>
        /// Returns true if the specified type is an unsigned primal integral type
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bool unsigned<T>()
            where T : unmanaged
                => NumericTypes.unsigned<T>();

        /// <summary>
        /// Returns true if the spedified type is a 32-bit or 64-bit floating point
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static bool floating<T>()
            where T : unmanaged
                => NumericTypes.floating<T>();

        [MethodImpl(Inline), Op]
        public static bool signed(object value)
            => NumericTypes.signed(value);
        
        [MethodImpl(Inline), Op]
        public static bool unsigned(object value)
            => NumericTypes.unsigned(value);
        
        [MethodImpl(Inline), Op]
        public static bool floating(object value)
            => NumericTypes.floating(value);

    }
}