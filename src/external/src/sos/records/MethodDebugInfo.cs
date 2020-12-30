// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace SOS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DebugInfo
    {
        public int lineNumber;

        public int ilOffset;

        public string fileName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct LocalVarInfo
    {
        public int startOffset;

        public int endOffset;

        public string name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MethodDebugInfo
    {
        public IntPtr points;

        public int size;

        public IntPtr locals;

        public int localsSize;
    }

    /// <summary>
    /// Matches the IRuntime::RuntimeConfiguration in runtime.h
    /// </summary>
    public enum RuntimeConfiguration
    {
        WindowsDesktop = 0,

        WindowsCore = 1,

        UnixCore = 2,

        OSXCore = 3
    }
}