// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Konst;

//     /// <summary>
//     /// Let's pretend we can make refinement types in .Net
//     /// </summary>
//     public readonly struct Refinement<E,T> : IRefinement<Refinement<E,T>,E,T>
//         where E : unmanaged, Enum, IEquatable<E>
//         where T : unmanaged
//     {
//         /// <summary>
//         /// The numeric content covered by the refining enumeration
//         /// </summary>
//         public readonly E Value;

//         /// <summary>
//         /// The numeric content
//         /// </summary>
//         public T Numeric
//         {
//             [MethodImpl(Inline)]
//             get => Enums.scalar<E,T>(Value);
//         }

//         public EnumLiteralKind ScalarKind
//         {
//             [MethodImpl(Inline)]
//             get => Enums.kind<E>();
//         }


//         [MethodImpl(Inline)]
//         public Refinement(E value)
//             => Value = value;

//         public T Data
//         {
//             [MethodImpl(Inline)]
//             get => Enums.scalar<E,T>(Value);
//         }

//         public bool Equals(Refinement<E,T> src)
//             => src.Value.Equals(Value);

//         public override bool Equals(object src)
//             => src is Refinement<E,T> r && Equals(r);

//         public string Format()
//             => Value.ToString();

//         public override string ToString()
//             => Format();

//         public override int GetHashCode()
//             => Value.GetHashCode();

//         [MethodImpl(Inline)]
//         public static bool operator ==(Refinement<E,T> x, Refinement<E,T> y)
//             => x.Equals(y);

//         [MethodImpl(Inline)]
//         public static bool operator !=(Refinement<E,T> x, Refinement<E,T> y)
//             => !x.Equals(y);

//         [MethodImpl(Inline)]
//         public static implicit operator Refinement<E,T>(E src)
//             => new Refinement<E,T>(src);

//         [MethodImpl(Inline)]
//         public static implicit operator T(Refinement<E,T> src)
//             => src.Data;

//         [MethodImpl(Inline)]
//         public static implicit operator E(Refinement<E,T> src)
//             => src.Value;
//     }
// }