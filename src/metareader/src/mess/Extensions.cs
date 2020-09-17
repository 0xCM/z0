//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Z0.MS;

    using static MS.HResult.FacilityCode;

    partial class XTend
    {
        public static int Search<Kind, Key>(this IReadOnlyList<Kind> list, Key key, Func<Kind, Key, int> compareTo)
        {
            int lower = 0;
            int upper = list.Count - 1;

            while (lower <= upper)
            {
                int mid = (lower + upper) >> 1;

                Kind entry = list[mid];
                int comparison = compareTo(entry, key);
                if (comparison > 0)
                {
                    upper = mid - 1;
                }
                else if (comparison < 0)
                {
                    lower = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static int Search<Kind, Key>(this Kind[] list, Key key, Func<Kind, Key, int> compareTo)
            => Search((IReadOnlyList<Kind>)list, key, compareTo);

        /// <summary>
        /// Converts an <see cref="NTSTATUS"/> to an <see cref="HResult"/>.
        /// </summary>
        /// <param name="status">The <see cref="NTSTATUS"/> to convert.</param>
        /// <returns>The <see cref="HResult"/>.</returns>
        public static HResult ToHResult(this NTSTATUS status)
        {
            // From winerror.h
            // #define HRESULT_FROM_NT(x)      ((HRESULT) ((x) | FACILITY_NT_BIT))
            return status | (int)FACILITY_NT_BIT;
        }

        /// <summary>
        /// Converts a <see cref="Win32ErrorCode"/> to an <see cref="HResult"/>.
        /// </summary>
        /// <param name="error">The <see cref="Win32ErrorCode"/> to convert.</param>
        /// <returns>The <see cref="HResult"/>.</returns>
        public static HResult ToHResult(this Win32ErrorCode error)
        {
            // From winerror.h
            //  (HRESULT)(x) <= 0 ? (HRESULT)(x) : (HRESULT) (((x) & 0x0000FFFF) | (FACILITY_WIN32 << 16) | 0x80000000)
            return error <= 0
                ? (HResult)(int)error
                : (HResult)(int)(((int)error & 0x0000ffff) | ((int)FACILITY_WIN32 /*<< 16*/) | 0x80000000);
        }

        /// <summary>
        /// Allocates an array of characters to represent the specified string, with a null terminating character as the last array element.
        /// </summary>
        /// <param name="value">The string to represent as a character array.</param>
        /// <returns>The character array with null terminator.</returns>
        public static char[] ToCharArrayWithNullTerminator(this string value)
        {
            char[] buffer = new char[value.Length + 1];
            value.CopyTo(0, buffer, 0, value.Length);
            return buffer;
        }
    }
}