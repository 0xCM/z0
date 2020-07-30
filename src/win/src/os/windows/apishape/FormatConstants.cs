//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Windows
    {
        const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;

        const int FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;

        const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;

        const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;

        const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;

        const int ERROR_INSUFFICIENT_BUFFER = 0x7A;

    }
}