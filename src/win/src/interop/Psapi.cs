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
        public readonly partial struct PsApi
        {
            [DllImport(WinLibs.PsApi, SetLastError = true)]
            public static extern unsafe bool EnumProcesses(int[] lpidProcess, int cb, out int lpcbNeeded);

        }
    }
}