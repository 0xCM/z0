//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    using static Blit.Operate;

    partial struct Blit
    {

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct g2x2<T>
            where T : unmanaged
        {
            v2<T> R0;

            v2<T> R1;

            public uint M => 2;

            public uint N => 2;
        }

    }
}