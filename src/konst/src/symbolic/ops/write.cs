//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Symbolic
    {        
        [MethodImpl(Inline), Op]
        public static ref ushort write(ref char src)
            => ref SymBits.write(ref src);

        [MethodImpl(Inline), Op]
        public static ref ushort write(ref char src, int offset)        
            => ref SymBits.write(ref src, offset);
    }
}