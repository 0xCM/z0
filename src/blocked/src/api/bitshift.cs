//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed; 
    using static Memories;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> bsll<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.bsll<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> bsll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.bsll<T>(w256).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> bsrl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.bsrl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> brsl<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.bsrl<T>(w256).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> xors<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.xors<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> xors<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.xors<T>(w256).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> srl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.srl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> srl<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.srl<T>(w256).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> sll<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.sll<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> sll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.sll<T>(w256).Invoke(a, count, dst);
 
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> rotl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.rotl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> rotl<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.rotl<T>(w256).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> rotr<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.rotr<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> rotr<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.rotr<T>(w256).Invoke(a, count, dst);
    }
}