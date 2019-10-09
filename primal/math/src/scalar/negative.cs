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
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool negative(sbyte x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool negative(short x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool negative(int x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool negative(long x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool negative(float x)
            => x < 0;

        /// <summary>
        /// Returns true if the source value is less than zero, false otherwise
        /// </summary>
        /// <param name="x">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bool negative(double x)
            => x < 0;
    }

}