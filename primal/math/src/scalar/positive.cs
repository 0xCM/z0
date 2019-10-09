//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class math
    {

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(sbyte x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(byte x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(short x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(ushort x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(int x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(uint x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(long x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(ulong x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(float x)
            => x > 0;

        /// <summary>
        /// Returns true if the source value is greater than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool positive(double x)
            => x > 0;
    }

}