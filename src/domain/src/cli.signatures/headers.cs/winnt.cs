//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    public readonly partial struct Win
    {
        public readonly struct Nt
        {

            public struct IMAGE_DATA_DIRECTORY
            {
                uint VirtualAddress;

                uint Size;
            }
        }
    }
}