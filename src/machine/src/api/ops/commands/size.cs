//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    
    partial class Commands
    {
        /// <summary>
        /// Computes the length, in bytes, of the encoded content
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static byte size(in EncodedCommand src)
            => vcell(src.Data, 15);
    }
}