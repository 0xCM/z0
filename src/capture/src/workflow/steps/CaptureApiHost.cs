// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;

//     using Z0.Asm;

//     using static Konst;

//     [WfHost]
//     public sealed class CaptureApiHost : WfHost<CaptureApiHost>
//     {
//         IApiHost Api;

//         IAsmContext Asm;

//         public static WfHost create(IAsmContext asm, IApiHost api)
//         {
//             var host = new CaptureApiHost();
//             host.Asm = asm;
//             host.Api = api;
//             return host;
//         }

//         protected override void Execute(IWfShell wf)
//         {
//             using var step = new CaptureApiHostStep(wf, this, Asm, Api);
//             step.Run();
//         }
//     }

//     readonly ref struct CaptureApiHostStep
//     {
//         readonly IWfShell Wf;

//         readonly WfHost Host;

//         readonly IApiHost Api;

//         readonly IAsmContext Asm;

//         [MethodImpl(Inline)]
//         public CaptureApiHostStep(IWfShell wf, WfHost host, IAsmContext asm, IApiHost api)
//         {
//             Host = host;
//             Wf = wf.WithHost(Host);
//             Asm = asm;
//             Api = api;
//             Wf.Created();
//         }

//         public void Dispose()
//         {
//             Wf.Disposed();
//         }

//         public void Run()
//         {
//             using var flow = Wf.Running(Api.Name);

//             try
//             {
//                 using var extract = new ExtractHostMembersStep(Wf, Host, Api);
//                 extract.Run();
//                 using var emit = new EmitCaptureArtifactsStep(Wf, Host, Asm, Api.Uri, extract.Extracts);
//                 emit.Run();
//             }
//             catch(Exception e)
//             {
//                 Wf.Error(e);
//             }
//         }
//     }
// }