//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Symbolic
    {        
        [MethodImpl(Inline), Op]
        public static ref readonly ushort read(in char src, int offset)                
            => ref z.read<ushort>(src, offset);
    }
}