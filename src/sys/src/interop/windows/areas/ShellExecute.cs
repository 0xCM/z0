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
        partial struct Shell32
        {
            [DllImport(Libraries.Shell32, ExactSpelling = true, CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern unsafe bool ShellExecuteExW(SHELLEXECUTEINFO* pExecInfo);           
       }
    }
}