//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Core;
    
    partial class XTend
    {
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this int src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ulong src)
            => BitConverter.GetBytes(src);
    }
}