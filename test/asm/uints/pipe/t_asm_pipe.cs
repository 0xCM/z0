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

    using static Seed;

    using K = Kinds;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        ulong[] Activations;

        public t_asm_pipe()
        {
            Activations = new ulong[(int)Mnemonic.LAST + 1];
            FakeBase = 1;
        }
        
        void OnVinserti128(Instruction i)
        {            
            Activations[(int)i.Mnemonic]++;
        }

        void OnVmovupd(Instruction i)
        {
            Activations[(int)i.Mnemonic]++;
        }

        void OnCall(Instruction i)
        {
            Activations[(int)i.Mnemonic]++;
        }

        int listcount = 0;
        
        AsmInstructionList Pipe(AsmInstructionList src)
        {        
            listcount++;
            return src;
        }

        public void check_archive()
        {            
            var paths = Paths.ForApp(PartId.Control);
            var capture = AsmCheck.CaptureArchive(paths.AppCapturePath);
            var bits = AsmCheck.UriBitsArchive(capture.CodeDir);
            var data = bits.Read(PartId.GVec);
            check_asm_pipe(data);
        }

        MemoryAddress FakeBase;

        void check_asm_pipe(IEnumerable<UriHex> src)
        {
            var decoder = UriHexDecoder.Service;
            var t1 = AsmMnemonicTrigger.Define(Mnemonic.Vinserti128, OnVinserti128);
            var t2 = AsmMnemonicTrigger.Define(Mnemonic.Vmovupd, OnVmovupd);
            var t3 = AsmCallTrigger.Define(OnCall);
            var triggers = AsmTriggerSet.Define(t1,t2,t3);
            var decoded = decoder.Decode(src).Map(x => AsmInstructionList.Create(x, LocatedCode.Define(FakeBase,x.Encoded)));
            var flow = AsmInstructionFlow.Create(decoded, triggers);
            var pipe = AsmInstructionPipe.From(Pipe); 
            var results = flow.Flow(pipe).Force();

            for(var i =0; i<(int)Mnemonic.LAST; i++)
            {
                var count = Activations[i];
                if(count != 0)                
                    Trace($"Logged {count} {(Mnemonic)i} activations");        
            }
        }

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
            var paths = Paths.ForApp(PartId.Control);
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