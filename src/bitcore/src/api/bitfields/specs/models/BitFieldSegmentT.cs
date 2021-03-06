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
//     /// Defines a segment within a bitfield
//     /// </summary>
//     /// <typeparam name="T">The value type relative to which the segment is defined</typeparam>
//     public readonly struct BitSegment<T> : IBitFieldSegment<T>
//         where T : unmanaged
//     {
//         public Name Name {get;}

//         /// <summary>
//         /// The section over which the segment is defined
//         /// </summary>
//         public BitSegment<T> Section {get;}

//         [MethodImpl(Inline)]
//         public BitSegment(Name name, BitSegment<T> section)
//         {
//             Name = name;
//             Section = section;
//         }

//         /// <summary>
//         /// The segment bit-width
//         /// </summary>
//         public uint Width
//         {
//            [MethodImpl(Inline)]
//             get => Section.Width;
//         }

//         public T StartPos
//         {
//            [MethodImpl(Inline)]
//            get => Section.StartPos;
//         }

//         public T EndPos
//         {
//             [MethodImpl(Inline)]
//             get => Section.EndPos;
//         }

//         public BitSegment Untyped
//         {
//             [MethodImpl(Inline)]
//             get => new BitSegment(Name, Section.Untyped);
//         }

//         [MethodImpl(Inline)]
//         public static implicit operator BitSegment(BitSegment<T> src)
//             => src.Untyped;
//     }
// }