//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Z0.Asm;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static zfunc;
    using static NKT;

    public class t_asm_checks : t_asm<t_asm_checks>
    {                   

        AsmFormatConfig AsmFormat
            => AsmFormatConfig.New.WithoutFunctionTimestamp();

        public void CheckCapture(in AsmBuffers buffers)
        {
            var name = nameof(ginx.vcimpl);         
            var width = n256;                        
            var args = NumericKind.Integers.DistinctKinds().Map(arg => arg.ToClrType().Require());
            var generic = Intrinsics.VectorizedGeneric(width,name).CloseGenericMethods(args);
            var direct = Intrinsics.VectorizedDirect(width,name);
            var selected = direct.Union(generic).ToArray();            
            var path = Capture(buffers, selected,name);
            var hex = Context.CodeReader().Read(path);
            
            var hexD = hex.Where(h => !h.Id.IsGeneric).ToDictionary(x => x.Id);
            var hexG = hex.Where(h => h.Id.IsGeneric).ToDictionary(x => x.Id);
                                        
            foreach(var k in hexG.Keys)
            {
                var gHex = hexG[k];
                var dHex = hexD[k.WithoutGeneric()];
                var pairing = pair(gHex, dHex);

                var gcell = from seg in gHex.Id.Segment(1)
                            let t = seg.SegKind
                            select t;
                var dcell = from seg in dHex.Id.Segment(1)
                            let t = seg.SegKind
                            select t;

                var dseg = dHex.Id.Segment(1);
                //Trace($"{gcell} :: {dcell}");
            }            
        }

        static void RunCapture(ICaptureService capture, IAsmFunctionDecoder decoder, in OpExtractExchange exchange, MethodInfo[] src, IAsmCodeWriter codeDst, IAsmFunctionWriter asmDst)
        {
            foreach(var method in src)
            {
                var data = capture.Capture(exchange, method.Identify(), method);
                codeDst.WriteCode(data.Code);
                var asm = decoder.DecodeFunction(data);
                asmDst.Write(asm);
            }
        }

        IAsmCodeWriter CodeWriter([Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  Context.CodeWriter(dst);
        }

        IAsmFunctionWriter FunctionWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Asm);    
            return Context.WithFormat(DefaultAsmFormat).AsmWriter(path);
        }

        FilePath Capture(in AsmBuffers buffers, MethodInfo[] methods, string subject)
        {
            using var hex = CodeWriter(subject);
            using var asm = FunctionWriter(subject);

            var decoder = Context.AsmFunctionDecoder();
            RunCapture(buffers.Capture, Context.AsmFunctionDecoder(), buffers.Exchange, methods, hex, asm);
                        
            return hex.TargetPath;            
        }


        void Run50(in AsmBuffers buffers)
        {
            var id = AssemblyId.GMath;
            var direct = Context.CodeArchive(id, nameof(math));
            var generic = Context.CodeArchive(id, nameof(gmath));

            foreach(var a in direct.Read().Where(asm => asm.ParameterCount() == 1))
            {                
                if(a.AcceptsParameter(NumericKind.U8))
                {
                    var af = a.ToFixed<Fixed8>();
                    var bf = a.ToFixed<Fixed8>();
                    CheckUnaryOp(buffers, af, bf);
                }
                if(a.AcceptsParameter(NumericKind.U32))
                {
                    var af = a.ToFixed<Fixed32>();
                    var bf = a.ToFixed<Fixed32>();
                    CheckUnaryOp(buffers, af, bf);
                }
                else if(a.AcceptsParameter(NumericKind.U64))
                {
                    var af = a.ToFixed<Fixed64>();
                    var bf = a.ToFixed<Fixed64>();
                    CheckUnaryOp(buffers, af, bf);
                }
            }
        }


        void CheckUnaryOp<F>(in AsmBuffers buffers, in FixedAsm<F> a, in FixedAsm<F> b)
            where F : unmanaged, IFixedWidth
        {            
            TraceCaller($"Checking {a.Id} == {b.Id} match");
            

            var f = buffers.LeftExec.LoadFixedUnaryOp<F>(a.Code);
            var g = buffers.RightExec.LoadFixedUnaryOp<F>(b.Code);            

            var stream = Random.FixedStream<F>();
            if(stream == null)
                Claim.fail($"random stream null!");

            var points = stream.Take(RepCount);
            iter(points, x => Claim.eq(f(x), g(x)));            

        }


        [MethodImpl(Inline)]
        static unsafe ulong ptr(ReadOnlySpan<byte> src)
            => (ulong)Unsafe.AsPointer(ref Unsafe.AsRef(in head(src)));

        public void datares_check(in AsmBuffers buffers)
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Data.Resources)
                Claim.eq(d.Location, ptr(d.GetBytes()));
        }



       
    }
}