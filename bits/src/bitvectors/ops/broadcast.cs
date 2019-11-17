//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;

    partial class BitVector
    {


        [MethodImpl(Inline)]
        public static BitVector16 broadcast(N16 n, byte a)
        {
            var src = (uint)a;
            return (ushort)(src | (src << 8));
        }

        [MethodImpl(Inline)]
        public static BitVector32 broadcast(N32 n, byte a)
        {
            var src = (uint)a;
            return src | (src << 8) | (src << 16) | (src << 24);
        }

        [MethodImpl(Inline)]
        public static BitVector32 broadcast(N32 n, ushort a)
        {
            var src = (uint)a;
            return src | (src << 16);
        }

        [MethodImpl(Inline)]
        public static BitVector64 broadcast(N64 n, byte a)
        {
            var src = (ulong)a;
            return src | (src << 8) | (src << 16) | (src << 24) | (src << 32) | (src << 48) | (src << 56);
        }

        [MethodImpl(Inline)]
        public static BitVector64 broadcast(N64 n, ushort a)
        {
            var src = (ulong)a;
            return src | (src << 16) | (src << 32) | (src << 48);
        }

        [MethodImpl(Inline)]
        public static BitVector64 broadcast(N64 n, uint a)
        {
            var src = (ulong)a;
            return src | (src << 32);
        }

    }

}