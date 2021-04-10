//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMem;

    [ApiHost]
    public readonly partial struct AsmMem
    {



    }

    [ApiHost]
    public readonly struct AsmMemModels
    {
        /// <summary>
        /// Creates a memory operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static mem<T> mem<T>(T src)
            where T : unmanaged
                => new mem<T>(src);

        [MethodImpl(Inline), Op]
        public m8 m8(Cell8 value)
            => new m8(value);

        [MethodImpl(Inline), Op]
        public m16 m16(Cell16 value)
            => new m16(value);

        [MethodImpl(Inline), Op]
        public m32 m32(Cell32 value)
            => new m32(value);

        [MethodImpl(Inline), Op]
        public m64 m64(Cell64 value)
            => new m64(value);
    }
}