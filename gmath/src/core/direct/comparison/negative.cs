//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {
        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit negative(sbyte x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit negative(short x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit negative(int x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit negative(long x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit negative(float x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bit negative(double x)
            => x < 0;
    }

}