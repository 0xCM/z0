//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    partial struct gcells
    {
        [MethodImpl(Inline)]
        public static Cell<T> load<T>(ReadOnlySpan<byte> src)
            where T : struct
                => load8x64<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        static Cell<T> load8x64<T>(ReadOnlySpan<byte> src)
            where T : struct
        {
            if(size<T>() == 1)
                return @as<T>(Cells.cell(src, w8));
            else if(size<T>() == 2)
                return @as<T>(Cells.cell(src, w16));
            else if(size<T>() == 4)
                return @as<T>(Cells.cell(src, w32));
            else if(size<T>() == 16)
                return @as<T>(Cells.cell(src, w64));
            else
                return load128x512<T>(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        static Cell<T> load128x512<T>(ReadOnlySpan<byte> src)
            where T : struct
        {
            if(size<T>() == 16)
                return @as<Cell128,Cell<T>>(Cells.cell(src, w128));
            else if(size<T>() == 32)
                return @as<Cell256,Cell<T>>(Cells.cell(src, w256));
            else if(size<T>() == 64)
                return @as<Cell512,Cell<T>>(Cells.cell(src, w512));
            else
                throw no<T>();
        }
    }
}