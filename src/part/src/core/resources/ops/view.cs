//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Resources
    {
        /// <summary>
        /// Reveals the data represented by a <see cref='ResDescriptor'/>
        /// </summary>
        /// <param name="src">The source descriptor</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(in ResDescriptor src)
            => memory.view(src.Address, src.Size);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<T> view<T>(in ResDescriptor<T> id)
            where T : unmanaged
                => memory.view<T>(id.Address, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(in ResDescriptor<byte> id)
            => memory.view<byte>(id.Address, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> view(in ResDescriptor<char> id)
            => memory.view<char>(id.Address, id.CellCount);

        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> view(in ResDescriptor<char> res, uint i0, uint i1)
            => memory.section((char*)res.Address, i0, i1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(in ResDescriptor<byte> res, uint i0, uint i1)
            => memory.view<byte>(res.Address, (i1 - i0 + 1));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> view(in StringResRow src)
            => memory.view<char>(src.Address, src.Length);
    }
}