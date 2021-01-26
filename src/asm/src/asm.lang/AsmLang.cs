//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmLang  : ILanguage<AsmLang>
    {
        const NumericKind Closure = UnsignedInts;

        public Name Id => "asm";

        [MethodImpl(Inline), Op]
        public static AsmStatement statement(string src)
            => new AsmStatement(src.Trim());

        [MethodImpl(Inline), Op]
        public static AsmDisplacement dx(ulong value, AsmDisplacementSize size)
            => new AsmDisplacement(value, (AsmDisplacementSize)size);

        /// <summary>
        /// Generalizes a <see cref='IAsmOperand{T}'/> reification
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static AsmOp<T> operand<T>(T src)
            where T : unmanaged, IAsmOperand<T>
                => new AsmOp<T>(src.Position, src);

        /// <summary>
        /// Creates a memory operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemOp<T> mem<T>(byte pos, T src)
            where T : unmanaged, IMemOp
                => new MemOp<T>(pos, src);

        [MethodImpl(Inline), Op]
        public static AsmTokenLookup lookup(in AsmTokenIndex index)
            => new AsmTokenLookup(index);

        [MethodImpl(Inline), Op]
        public static string definition(in AsmTokenLookup tokens, AsmTokenKind id)
            => tokens.Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public static string meaning(in AsmTokenLookup tokens, AsmTokenKind id)
            => tokens.Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public static ref readonly TokenRecord token(in AsmTokenLookup tokens, AsmTokenKind id)
            => ref tokens.Models[(int)id];

        [MethodImpl(Inline), Op]
        public static string identifier(in AsmTokenLookup tokens, AsmTokenKind id)
            => tokens.Identity[id];
    }
}