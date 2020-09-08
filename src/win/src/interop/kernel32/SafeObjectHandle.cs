//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Windows
    {
        partial struct Kernel32
        {
            /// <summary>
            /// Represents a Win32 handle that can be closed with <see cref="CloseHandle"/>.
            /// </summary>
            public class SafeObjectHandle : SafeHandle
            {
                /// <summary>
                /// An invalid handle that may be used in place of <see cref="INVALID_HANDLE_VALUE"/>.
                /// </summary>
                public static readonly SafeObjectHandle Invalid = new SafeObjectHandle();

                /// <summary>
                /// A handle that may be used in place of <see cref="IntPtr.Zero"/>.
                /// </summary>
                public static readonly SafeObjectHandle Null = new SafeObjectHandle(IntPtr.Zero, false);

                /// <summary>
                /// Initializes a new instance of the <see cref="SafeObjectHandle"/> class.
                /// </summary>
                public SafeObjectHandle()
                    : base(INVALID_HANDLE_VALUE, true)
                {
                }

                /// <summary>
                /// Initializes a new instance of the <see cref="SafeObjectHandle"/> class.
                /// </summary>
                /// <param name="preexistingHandle">An object that represents the pre-existing handle to use.</param>
                /// <param name="ownsHandle">
                ///     <see langword="true" /> to have the native handle released when this safe handle is disposed or finalized;
                ///     <see langword="false" /> otherwise.
                /// </param>
                public SafeObjectHandle(IntPtr preexistingHandle, bool ownsHandle = true)
                    : base(INVALID_HANDLE_VALUE, ownsHandle)
                {
                    this.SetHandle(preexistingHandle);
                }

                /// <inheritdoc />
                public override bool IsInvalid => this.handle == INVALID_HANDLE_VALUE || this.handle == IntPtr.Zero;

                /// <inheritdoc />
                protected override bool ReleaseHandle() => CloseHandle(this.handle);
            }
        }
    }
}