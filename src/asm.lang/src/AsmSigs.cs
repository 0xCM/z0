//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;
    using static memory;

    [ApiHost]
    public readonly struct AsmSigs
    {
        /// <summary>
        /// Defines a <see cref='SigOperand'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static SigOperand sigop(string src)
            => new SigOperand(src);

        /// <summary>
        /// Creates a <see cref='AsmSigOpToken'/> index
        /// </summary>
        /// <param name="k">An identifier representative</param>
        [Op]
        public static Index<Token<AsmSigOpKind>> tokens()
        {
            var details = Enums.details<AsmSigOpKind,ushort>().View;
            var count = AsmSigOpKindFacets.IdentifierCount + 1;
            var buffer = alloc<Token<AsmSigOpKind>>(count);
            ref var dst = ref first(buffer);
            for(byte i=1; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var symbol = detail.Field.Tag<SymbolAttribute>().MapValueOrDefault(a => a.Symbol, EmptyString);
                seek(dst,i) = Tokens.token(i, detail.Name, detail.LiteralValue, symbol);
            }
            return buffer;
        }

        public static SymbolTable<AsmSigOpKind> table()
            => AsmSigs.tokens().ToSymbolTable();
    }
}