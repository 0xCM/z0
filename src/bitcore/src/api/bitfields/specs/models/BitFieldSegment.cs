// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Part;

//     /// <summary>
//     /// Defines a byte-parametric field segment
//     /// </summary>
//     public readonly struct BitSegment : IBitFieldSegment<uint>
//     {
//         /// <summary>
//         /// The segment name
//         /// </summary>
//         public Name Name {get;}

//         /// <summary>
//         /// The section over which the segment is defined
//         /// </summary>
//         public BitSegment<uint> Section {get;}

//         [MethodImpl(Inline)]
//         public BitSegment(Name name, BitSegment section)
//         {
//             Name = name;
//             Section = section;
//         }

//         [MethodImpl(Inline)]
//         public BitSegment(Name name, BitSegment<uint> section)
//         {
//             Name = name;
//             Section = section;
//         }

//         /// <summary>
//         /// The segment bit-width
//         /// </summary>
//         public uint Width
//         {
//             [MethodImpl(Inline)]
//             get => Section.Width;
//         }

//         public uint StartPos
//         {
//            [MethodImpl(Inline)]
//            get => Section.StartPos;
//         }

//         public uint EndPos
//         {
//             [MethodImpl(Inline)]
//             get => Section.EndPos;
//         }

//         [MethodImpl(Inline)]
//         public static implicit operator BitFieldSegment<uint>(in BitSegment src)
//             => new BitFieldSegment<uint>((Name)src.Name, src.Section);
//     }
// }