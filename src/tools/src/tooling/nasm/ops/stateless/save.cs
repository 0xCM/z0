// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0.Tools
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Root;
//     using static core;

//     partial class Nasm
//     {
//         public static uint save(NasmSource src, FS.FilePath dst)
//         {
//             var counter = 0u;
//             var expressions = src.Expressions.View;
//             var count = expressions.Length;

//             using var writer = dst.Writer();
//             if(src.Is64Bit)
//             {
//                 writer.WriteLine("bits 64");
//                 counter++;
//             }

//             for(var i=0; i<count; i++, counter++)
//                 writer.WriteLine(skip(expressions,i));
//             return counter;
//         }
//     }
// }