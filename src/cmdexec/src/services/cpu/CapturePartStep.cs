// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;
//     using System.IO;
//     using System.Reflection;

//     using Z0.Asm;

//     using static Part;
//     using static z;

//     public readonly struct CapturePartStep
//     {
//         readonly IAsmContext Asm;

//         readonly IAsmDecoder Decoder;

//         readonly IAsmFormatter Formatter;

//         readonly ICaptureServices Services;

//         readonly IWfShell Wf;

//         readonly WfHost Host;

//         readonly string[] DataTypeMemberExclusions;

//         public CapturePartStep(IWfShell wf, IAsmContext asm, WfHost host)
//         {
//             Wf = wf;
//             Asm = asm;
//             Host = host;
//             Services = CaptureServices.create(Asm);
//             var format = AsmFormatConfig.DefaultStreamFormat;
//             Formatter = Services.Formatter(format);
//             Decoder = Services.RoutineDecoder(format);
//             DataTypeMemberExclusions = new string[4]{"ToString","GetHashCode", "Equals", "ToString"};
//             Wf.Created(Host.Id);
//         }


//         public void Dispose()
//             => Wf.Disposed(Host.Id);

//         static IMultiDiviner Diviner
//             => MultiDiviner.Service;

//         [MethodImpl(Inline)]
//         bool IsExcluded(in ApiTypeInfo type, MethodInfo method)
//         {
//             ref var x = ref first(span(DataTypeMemberExclusions));
//             var xCount = DataTypeMemberExclusions.Length;
//             for(var i=0u; i<xCount; i++)
//                 if(method.Name.Equals(skip(x,i)))
//                     return true;
//             return false;
//         }

//         public ReadOnlySpan<IdentifiedMethod> IdentifyMembers(in ApiTypeInfo src)
//         {
//             var candidates = @readonly(src.HostType.DeclaredMethods().Unignored().NonGeneric());
//             var count = candidates.Length;
//             var dst = span<IdentifiedMethod>(count);
//             var j = 0u;
//             for(var i=0; i<count; i++)
//             {
//                 ref readonly var m = ref skip(candidates,i);
//                 if(!IsExcluded(src, m))
//                     seek(dst,j++) = new IdentifiedMethod(Diviner.Identify(m),m);
//             }
//             return slice(dst,j);
//         }

//         public ApiDataTypeRoutine[] Capture(in ApiTypeInfo src, Span<byte> buffer)
//         {
//             var members = IdentifyMembers(src);
//             var count = members.Length;
//             var dst = alloc<ApiDataTypeRoutine>(count);
//             ref var target = ref first(span(dst));
//             for(var i=0u; i<count; i++)
//             {
//                 buffer.Clear();
//                 var routine = new AsmMemberRoutine();
//                 ref readonly var member = ref skip(members, i);
//                 var capture = CaptureAlt.capture(member, buffer);
//                 var decoded = Decoder.Decode(capture).Require();
//                 routine.Member = member;
//                 routine.Encoded = capture;
//                 routine.Routine = decoded;
//                 routine.Asm = Formatter.FormatFunction(decoded);
//                 seek(target,i) = new ApiDataTypeRoutine(src,member,routine);
//             }
//             return dst;
//         }

//         public ReadOnlySpan<ApiDataTypeRoutines> Capture(IPart src)
//         {
//             var buffer = span<byte>(Pow2.T14);
//             var catalog = ApiCatalogs.create(src);
//             var types = catalog.ApiTypes;
//             var count = types.Count;

//             var dst = alloc<ApiDataTypeRoutines>(count);
//             var target = span(dst);
//             ref var type = ref types.First;
//             for(var i=0u; i<count; i++)
//             {
//                 var routines = Capture(skip(type,i), buffer);
//                 seek(target,i) = new ApiDataTypeRoutines(type,routines);
//             }
//             return dst;
//         }

//         public ReadOnlySpan<AsmRoutineCode> Capture(ApiHostUri host, ReadOnlySpan<MethodInfo> src, FilePath dst)
//         {
//             var count = src.Length;
//             var code = span<ApiCaptureBlock>(count);
//             var target = span<AsmRoutineCode>(count);

//             using var writer = dst.Writer();
//             using var quick = QuickCapture.create(Asm);

//             for(var i=0u; i<count; i++)
//             {
//                 ref readonly var method = ref skip(src,i);
//                 var captured = quick.Capture(method).ValueOrDefault(ApiCaptureBlock.Empty);
//                 if(captured.IsNonEmpty)
//                 {
//                     seek(code, i) = captured;
//                     var decoded = Decoder.Decode(captured).ValueOrDefault(AsmRoutine.Empty);
//                     seek(target, i) = new AsmRoutineCode(decoded, captured);
//                     Save(captured, writer);
//                 }
//             }

//             return target;
//         }

//         void Save(ApiCaptureBlock code, StreamWriter dst)
//         {
//             var asm = Decoder.Decode(code).Require();
//             var formatted = Formatter.FormatFunction(asm);
//             dst.Write(formatted);
//         }
//     }
// }