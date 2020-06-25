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

    public partial class SymBits
    {        
        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src)        
            => ref As.read<ushort>(src);

        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src, int offset)        
            => ref As.read<ushort>(src, offset);

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src)
            => ref Root.write<ushort>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src, int offset)        
            => ref Root.write<ushort>(ref src, offset);
    }
}