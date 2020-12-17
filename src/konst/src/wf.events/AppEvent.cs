// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Konst;

//     public readonly struct AppEvent : IAppEvent<AppEvent, string>
//     {
//         public EventId Id {get;}

//         public string Data {get;}

//         public FlairKind Flair {get;}

//         [MethodImpl(Inline)]
//         public AppEvent(EventId id, string data, FlairKind flair)
//         {
//             Id = id;
//             Data = data;
//             Flair = flair;
//         }

//         public string Format()
//             => string.Concat(Id, CharText.Colon, CharText.Space, Data);

//         public override string ToString()
//             => Format();
//     }
// }