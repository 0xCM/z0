//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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
            var path = CaseFilePath(FileExtensions.Csv);
            report.Save(path).Require();            
        }

    }
}