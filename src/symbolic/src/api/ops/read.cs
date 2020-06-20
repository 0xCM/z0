//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static ref readonly ushort read(in char src)        
            => ref SymBits.read(src);

        [MethodImpl(Inline), Op]
        public static ref readonly ushort read(in char src, int offset)        
            => ref SymBits.read(src,offset);
    }
}