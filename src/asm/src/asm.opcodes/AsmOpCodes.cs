//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly partial struct AsmOpCodesLegacy
    {
        [MethodImpl(Inline)]
        public static DatasetFormatter<T> formatter<T>()
            where T : unmanaged, Enum
                => Table.dsformatter<T>();

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExprLegacy identity(in AsmOpCodeRowLegacy src)
            => new AsmOpCodeExprLegacy(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<AsmOpCodeRowLegacy> src, Span<AsmOpCodeExprLegacy> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = identity(skip(src,i));
        }
    }
}