//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 UnaryOp64(Fixed64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 UnaryOp128(Fixed128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 UnaryOp256(Fixed256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 BinaryOp64(Fixed64 a, Fixed64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 BinaryOp128(Fixed128 a, Fixed128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 BinaryOp256(Fixed256 a, Fixed256 b);

    public struct Fixed64
    {
        internal ulong X0;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed128
    {
        internal ulong X0;

        ulong X1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed256
    {
        internal Fixed128 X0;

        Fixed128 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed512
    {
        internal Fixed256 X0;

        Fixed256 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed1024
    {
        internal Fixed512 X0;

        Fixed512 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed2048
    {
        internal Fixed1024 X0;

        Fixed1024 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed4096
    {
        internal Fixed2048 X0;

        Fixed2048 X1;
        
    }

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

    public static class FixedContainers
    {

    }
}