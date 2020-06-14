//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm.Data;
    using static Seed;
    using static Control;



    public class t_resource_check : t_asm<t_resource_check>
    {
        public void check_no_copy()
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Z0.Data.Resources)
                Claim.eq(d.RuntimeAddress, d.Address);

        }

        public void check_report()
        {
            var report = ResourceReport.Create(Z0.Data.Resources);
            var path = CasePath(FileExtensions.Csv);
            report.Save(path).Require();            
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