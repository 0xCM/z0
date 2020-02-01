//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static zfunc;

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed1024 : IFixed<Fixed1024,N1024>
    {
        public const int BitWidth = 1024;        

        internal Fixed512 X0;

        Fixed512 X1;
        
        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }
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
}