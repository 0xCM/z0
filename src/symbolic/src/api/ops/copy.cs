//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Symbolic
    {   
        [MethodImpl(Inline), Op]
        public static unsafe void copy(in asci16 src, ref byte dst)
            => SymBits.vstore(src.Storage, ref dst);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in asci32 src, ref byte dst)
            => SymBits.vstore(src.Storage, ref dst);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in asci64 src, ref byte dst)
            => SymBits.vstore(src.Storage, ref dst);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in asci16 src, Span<byte> dst)
            => SymBits.vstore(src.Storage, dst);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in asci32 src, Span<byte> dst)
            => SymBits.vstore(src.Storage, dst);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in asci64 src, Span<byte> dst)
            => SymBits.vstore(src.Storage, dst);            
    }
}