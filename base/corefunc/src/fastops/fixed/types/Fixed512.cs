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

    using static zfunc;

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed512  : IFixed<Fixed512,N512>
    {
        public const int BitWidth = 512;        

        internal Fixed256 X0;

        Fixed256 X1;
        
        public FixedWidth Width
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }
    }
}