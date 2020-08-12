//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    [Table("https://msdn.microsoft.com/en-us/library/windows/desktop/aa380518.aspx")]
    public struct UNICODE_STRING
    {
        /// <summary>
        /// Length in bytes, not including the null terminator, if any.
        /// </summary>
        public ushort Length;

        /// <summary>
        /// Max size of the buffer in bytes
        /// </summary>
        public ushort MaximumLength;

        public IntPtr Buffer;
    }
}