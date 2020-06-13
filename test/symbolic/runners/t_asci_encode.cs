//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public class t_asci_encode : UnitTest<t_asci_encode>
    {        
        public void test_case_01()
        {
            var tc = default(AsciTestCase01);
            var result = AsciTestCases.execute(tc);
            Trace(result.Description);
            Claim.yea(result.Success);
        }


        public void test_case_02()
        {
            var tc = AsciTestCase02.Create();
            var a2 = Symbolic.decode(tc.A2);
            var a4 = Symbolic.decode(tc.A4);
            var a8 = Symbolic.decode(tc.A8);
            //var a16 = Symbolic.decode(tc.A16);
            var a32 = Symbolic.decode(tc.A32);

            Trace(a2.Format());
            Trace(a4.Format());
            Trace(a8.Format());
            //Trace(a16.Format());
            Trace(a32.Format());

            // var a32 = Symbolic.decode(tc.A32);
            // var a64 = Symbolic.decode(tc.A64);

        }

        void res_HexKind()
        {
            var svc = AsciResourceSet.Service;
            var res = svc.HexKindNames();
            for(var i=0; i<res.EntryCount; i++)
            {
                ref readonly var entry = ref res[i];
                Trace(entry.Format());
            }

        }
    }
}
