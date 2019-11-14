//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static bit nonzero(sbyte src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(byte src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(short src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(ushort src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(int src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(uint src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(long src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(ulong src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(float src)
            => src != 0;
            
        [MethodImpl(Inline)]
        public static bit nonzero(double src)
            => src != 0;
    }
}