//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class MemBlocks
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block02<T> store<T>(in Block02<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block02<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block03<T> store<T>(in Block03<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block03<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block04<T> store<T>(in Block04<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block04<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block05<T> store<T>(in Block05<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block05<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block06<T> store<T>(in Block06<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block06<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block07<T> store<T>(in Block07<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block07<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block08<T> store<T>(in Block08<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block08<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block12<T> store<T>(in Block12<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block12<T>>(dst)) = src;
            return ref src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly Block16<T> store<T>(in Block16<T> src, Span<T> dst)
            where T : unmanaged
        {
            memory.first(recover<T,Block16<T>>(dst)) = src;
            return ref src;
        }
    }
}