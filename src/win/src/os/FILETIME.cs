//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;    

    /// <summary>
    /// A 64-bit representation of a file timestamp.
    /// </summary>
    /// <remarks>
    /// This type is equivalent to <see cref="System.Runtime.InteropServices.ComTypes.FILETIME"/>.
    /// We couldn't use that type directly even though it's in the portable profile because
    /// Xamarin.Android and Xamarin.iOS omit the type and it causes link failures.
    /// See https://github.com/dotnet/pinvoke/issues/232.
    /// </remarks>
    public struct FILETIME
    {
        /// <summary>
        /// Specifies the low 32 bits of the FILETIME.
        /// </summary>
        public int dwLowDateTime;

        /// <summary>
        /// Specifies the high 32 bits of the FILETIME.
        /// </summary>
        public int dwHighDateTime;

        /// <summary>
        /// Convert to <see cref="long"/> to ease interop with <see cref="System.TimeSpan"/> or <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="fileTime"> The fileTime structure to be converted to long.</param>
        public static implicit operator long(FILETIME fileTime)
        {
            return ((long)fileTime.dwHighDateTime << 32) + (uint)fileTime.dwLowDateTime;
        }
    }
}