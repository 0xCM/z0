//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using Z0.Asm.Data;

    using static Root;

    public class t_resource_capture : t_asm<t_resource_capture>
    {
        public void define_resources()
        {
             var service = HostCodeResource.Service(Archives.Services.CaptureArchiveDir, Z0.AppPaths.Default.ResourceRoot + FolderName.Define("bytes"));
             service.Emit();
        }

        
        public void mask_capture()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();

            var methods = 
                from def in MaskCases.NumericMethodDefs
                from closure in def.MakeGenericMethods(MaskCases.NumericArgs)
                select closure;

            foreach(var src in methods)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();                                
                hexout.Write(captured.HostedBits);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }    
        }

        public void resource_method_capture()
        {
            var svc = AccessorCapture.Service(Context);
            var accessors = span(svc.CaptureAccessors(CasePath(FileExtensions.Asm)));
            using var addresses = CaseWriter(FileExtensions.Csv);
            addresses.WriteLine(text.concat("Addresss".PadRight(16),  " | ", "Accessor"));
            for(var i=0; i<accessors.Length; i++)
            {
                ref readonly var accessor = ref skip(accessors, i);
                var f = accessor.Code.Function;
                var moves = AsmAnalyzer.moves(f);
                for(var j =0; j<moves.Length; j++)
                {
                    ref readonly var move = ref skip(moves,j);
                    var description = text.concat(move.Src.ToAddress(), " | ", accessor.Code.Code.OpUri);
                    addresses.WriteLine(description);
                }
            }            
        }

        public void numeric_literals()
        {

        }
        public void string_literals()
        {
            var svc = FieldCapture.Service;
            var fields = span(svc.StringLiterals(typeof(InstructionTokenPurpose)));
            svc.Emit(fields, CasePath(FileExtensions.Csv));

            for(var i=0; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var memref = field.Location;
                var address = memref.Address;
                var data = memref.Load();
                var chars = span16c(data);
                var cstr = chars.ToString();      
                var expect = field.Field.GetRawConstantValue() as string;          
                Claim.eq(expect, cstr);
            }
        }

    }
}