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
        

        
        public void capture_known_resources()
        {
            var svc = AccessorCapture.Service(Context);
            var accessors = span(svc.CaptureKnown(CasePath(FileExtensions.Asm)));
            svc.CollectAddresses(accessors,CasePath(FileExtensions.Csv));
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