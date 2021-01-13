// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using static Konst;

//     using Z0.Asm;

//     public readonly struct WfCaptureContext : IWfCaptureContext
//     {
//         public IWfShell Wf {get;}

//         public ICaptureContext Context {get;}

//         public IWfCaptureBroker Broker {get;}

//         [MethodImpl(Inline)]
//         public WfCaptureContext(IWfShell wf, IAsmDecoder decoder, IAsmFormatter formatter, IPartCapturePaths archive)
//         {
//             Wf = wf;
//             Broker = AsmWorkflows.broker(wf);
//             Context = new CaptureContext(wf, decoder, formatter,  Broker);
//         }

//         public void Dispose()
//         {
//             Broker.Dispose();
//         }
//     }
// }