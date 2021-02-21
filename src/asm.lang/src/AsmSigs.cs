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
        /// Defines a <see cref='AsmSigOpToken'/>
        /// </summary>
        /// <param name="index">The identifier index that serves as a surrogate key for lookups</param>
        /// <param name="name">The identifer name</param>
        /// <param name="kind">The identifier kind</param>
        [MethodImpl(Inline), Op]
        public static Token<AsmSigOpKind> token(byte index, Identifier name, AsmSigOpKind kind, string symbol)
            => Tokens.token(index, name, kind, symbol);

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
                seek(dst,i) = token(i, detail.Name, detail.LiteralValue, symbol);
            }
            return buffer;
        }

        public static SymbolTable<Token<AsmSigOpKind>> table(IWfShell wf)
        {
            var tokens = AsmSigs.tokens();
            var table = SymbolTables.create(tokens, t => t.Symbol);
            var count = tokens.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref tokens[i];
                if(token.IsNonEmpty)
                {
                    if(!table.Index(token.Symbol, out var index))
                    {
                        wf.Error($"Index for {token.Name} not found");
                    }
                    ref readonly var found = ref table.Entry(index);

                    wf.Row(found.Format());
                }
                else
                {
                    if(token.Index!=0)
                        wf.Error($"Empty token has a nonzero index!");
                }
            }
            return table;
        }
    }
}