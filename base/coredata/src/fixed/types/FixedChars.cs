//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    [StructLayout(LayoutKind.Sequential)]
    public struct Char2
    {
        internal char C0;

        char C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char4
    {
        internal Char2 C0;

        Char2 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char8
    {
        internal Char4 C0;

        Char4 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char16
    {
        internal Char8 C0;

        Char8 C1;        
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Char32
    {
        internal Char16 C0;

        Char16 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char64
    {
        internal Char32 C0;

        Char32 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char128
    {
        internal Char64 C0;

        Char64 C1;        
    }
}