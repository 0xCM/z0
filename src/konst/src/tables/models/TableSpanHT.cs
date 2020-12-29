// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Konst;
//     using static z;

//     public readonly struct TableSpan<H,T> : ITableSpan<TableSpan<H,T>, T>
//         where T : struct
//         where H : struct, ITableSpan<H,T>
//     {
//         readonly H Host;

//         [MethodImpl(Inline)]
//         public static implicit operator TableSpan<H,T>(H src)
//             => new TableSpan<H,T>(src);

//         [MethodImpl(Inline)]
//         public static implicit operator T[](TableSpan<H,T> src)
//             => src.Storage;

//         [MethodImpl(Inline)]
//         public static implicit operator TableSpan<T>(TableSpan<H,T> src)
//             => src.Table;

//         [MethodImpl(Inline)]
//         public TableSpan(H src)
//             => Host = src;

//         public T[] Storage
//         {
//             [MethodImpl(Inline)]
//             get => Host.Storage;
//         }

//         public Span<T> Edit
//         {
//             [MethodImpl(Inline)]
//             get => Host.Edit;
//         }

//         public ReadOnlySpan<T> View
//         {
//             [MethodImpl(Inline)]
//             get => Host.View;
//         }

//         public Count Count
//         {
//             [MethodImpl(Inline)]
//             get => Host.Count;
//         }

//         public int Length
//         {
//             [MethodImpl(Inline)]
//             get => Host.Length;
//         }

//         public bool IsEmpty
//         {
//             [MethodImpl(Inline)]
//             get => Host.IsEmpty;
//         }

//         public bool IsNonEmpty
//         {
//             [MethodImpl(Inline)]
//             get => Host.IsNonEmpty;
//         }

//         public ref T this[long index]
//         {
//             [MethodImpl(Inline)]
//             get => ref Host[index];
//         }

//         public ref T this[ulong index]
//         {
//             [MethodImpl(Inline)]
//             get => ref Host[index];
//         }

//         public TableSpan<T> Table
//         {
//             [MethodImpl(Inline)]
//             get => Host.Storage;
//         }

//         [MethodImpl(Inline)]
//         public void Iter(Action<T> f)
//         {
//             var count = Count;
//             ref readonly var src = ref first(View);
//             for(var i=0; i<count; i++)
//                 f(skip(src,i));
//         }

//         [MethodImpl(Inline)]
//         public TableSpan<H,T> Refresh(T[] src)
//             => Host.Refresh(src);

//         public static TableSpan<H,T> Empty
//             => new TableSpan<H,T>(new H());
//     }
// }