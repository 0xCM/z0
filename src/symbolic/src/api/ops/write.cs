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
        public static ref ushort write(ref char src)
            => ref SymBits.write(ref src);

        [MethodImpl(Inline), Op]
        public static ref ushort write(ref char src, int offset)        
            => ref SymBits.write(ref src, offset);

        [MethodImpl(Inline), Op]
        public static ref byte write(ref AsciCharCode src)
            => ref Unsafe.As<AsciCharCode,byte>(ref edit(src));
    }
}