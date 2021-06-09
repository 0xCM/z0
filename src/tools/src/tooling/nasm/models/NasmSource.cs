// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0.Tools
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using Z0.Asm;

//     using static Root;

//     using api = Nasm;


//     public readonly struct NasmSource : ITextual
//     {
//         public bool Is64Bit {get;}

//         public Index<AsmExpr> Expressions {get;}

//         [MethodImpl(Inline)]
//         public NasmSource(Index<AsmExpr> expr, bool x64 = true)
//         {
//             Is64Bit = x64;
//             Expressions = expr;
//         }

//         public uint Save(FS.FilePath dst)
//             => api.save(this, dst);

//         public string Format()
//             => api.format(this);

//         public override string ToString()
//             => Format();

//         [MethodImpl(Inline)]
//         public static implicit operator NasmSource(Index<AsmExpr> src)
//             => new NasmSource(src);
//     }
// }