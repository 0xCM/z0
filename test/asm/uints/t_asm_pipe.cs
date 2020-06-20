//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    using K = Kinds;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        public t_asm_pipe()
        {
            FakeBase = 1;
        }
        

        public void RunPipe()
        {            
            var parts = Root.array(PartId.DVec, PartId.GVec);
            Trace($"Running pipe for parts {parts.Format()}");
            var runner = AsmPipeRunner.Create(AppPaths, AsmCheck.Archives, CasePath("AsmPipeLog"));
            var handled = runner.RunPipe(parts);
            Trace($"Collected data for {handled.Count} instruction classes");            
        }

        MemoryAddress FakeBase;

        void check_unary_ops(UriHex[] src)
        {
            var query = AsmCheck.UriBitQuery;
            foreach(var code in query.WithParameterCount(src, 1))
            {                
                if(query.AcceptsParameter(code, NumericKind.U8))
                    AsmCheck.CheckFixedMatch<Fixed8>(K.UnaryOp, code, code);
                else if(query.AcceptsParameter(code, NumericKind.U16))
                    AsmCheck.CheckFixedMatch<Fixed16>(K.UnaryOp, code, code);
                else if(query.AcceptsParameter(code, NumericKind.U32))
                    AsmCheck.CheckFixedMatch<Fixed32>(K.UnaryOp, code, code);
                else if(query.AcceptsParameter(code, NumericKind.U64))
                    AsmCheck.CheckFixedMatch<Fixed64>(K.UnaryOp, code, code);
            }
        }

        void check_math()
        {
            var dSrc = ApiHostUri.FromHost(typeof(math));
            var gSrc = ApiHostUri.FromHost(typeof(gmath));
            var id = PartId.GMath;   
            var paths = AppPaths.ForApp(PartId.Control);
            var capture = AsmCheck.CaptureArchive(paths.AppCapturePath);
            var archive = Archives.Services.UriBitsArchive(capture.CodeDir);
            var direct = archive.Read(dSrc).ToArray();
            var generic = archive.Read(gSrc).ToArray();
            var builder = Archives.Services.IndexBuilder(Api.ApiSet, Identities.Services.ApiLocator);            
            check_unary_ops(direct);        
            check_unary_ops(generic);        
        }
    }
}