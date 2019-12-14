//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitGridX
    {
        /// <summary>
        /// Interchanges span elements i and j
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="i">An index of a span element</param>
        /// <param name="j">An index of a span element</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static void Swap<T>(this Span<T> src, int i, int j)
            where T : unmanaged
        {
            if(i==j)
                return;
            
            ref var data = ref head(src);
            var a = seek(ref data, i);
            seek(ref data, i) = skip(in data, j);
            seek(ref data, j) = a;
        }

        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> ToBitGrid(this Perm8 src)
            => BitGrid.perm(src);

        [MethodImpl(Inline)]
        public static BitGrid32<uint> ToBitGrid(this NatPerm<N8> perm)
            => BitGrid.perm(perm);

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> ToBitGrid(this Perm16 src)
            => BitGrid.perm(src);

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> ToBitGrid(this NatPerm<N16> src)
            => BitGrid.perm(src);


        [MethodImpl(Inline)]
        public static Perm16 ToPerm16(this BitGrid64<N16,N4,ulong> src)
            => BitGrid.perm(src);
    }
}