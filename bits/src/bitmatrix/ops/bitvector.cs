//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {

        public static int rowstep<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return 16;
            else if(typeof(T) == typeof(uint))
                return 8;
            else if(typeof(T) == typeof(ulong))
                return 4;
            else
                throw unsupported<T>();

        }

    }
}