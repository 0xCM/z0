// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Reflection;
//     using System.Linq;
//     using System.Runtime.CompilerServices;

//     using static Root;
    
//     readonly struct AsmCaptureService : IAsmCaptureService
//     {
//         public IAsmContext Context {get;}

//         readonly IAsmOpExtractor Ops;

//         [MethodImpl(Inline)]
//         public static IAsmCaptureService Create(IAsmContext context, IAsmOpExtractor control)
//             => new AsmCaptureService(context, control);

//         [MethodImpl(Inline)]
//         AsmCaptureService(IAsmContext context, IAsmOpExtractor control)
//         {
//             Context = context;
//             Ops = control;            
//         }

//         public AsmOpExtract Capture(in AsmCaptureExchange exchange, OpIdentity id, DynamicDelegate src)
//             => Ops.Extract(in exchange, id, src);

//         public AsmOpExtract Capture(in AsmCaptureExchange exchange, OpIdentity id, MethodInfo src)
//             => Ops.Extract(in exchange, id, src);

//         public AsmOpExtract Capture(in AsmCaptureExchange exchange, OpIdentity id, Delegate src)
//             => Ops.Extract(in exchange, id, src);

//         public AsmOpExtract Capture(in AsmCaptureExchange exchange, MethodInfo src, params Type[] args)
//         {
//             if(src.IsOpenGeneric())
//             {
//                 var target = src.Reify(args);
//                 return Ops.Extract(in exchange, target.Identify(), target);
//             }
//             else
//                 return Ops.Extract(in exchange, src.Identify(), src);                
//         }

//     }
// }