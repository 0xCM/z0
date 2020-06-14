//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


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
            var c0 = AsciCharCode.Bang;
            var tc = AsciTestCase02.Create(c0);
            
            var a2d = asci.chars(tc.A2);
            var a2c = asci.codes((sbyte)c0, (sbyte)asci2.Size);
            Claim.yea(Symbolic.eq(a2d,a2c));

            var a4d = asci.chars(tc.A4);
            var a4c = asci.codes((sbyte)c0, (sbyte)asci4.Size);
            Claim.yea(Symbolic.eq(a4d,a4c));
            
            var a8d = asci.chars(tc.A8);
            var a8c = asci.codes((sbyte)c0, (sbyte)asci8.Size);
            Claim.yea(Symbolic.eq(a8d,a8c));

            var a16d = asci.chars(tc.A16);
            var a16c = asci.codes((sbyte)c0, (sbyte)asci16.Size);
            Claim.yea(Symbolic.eq(a16d,a16c));

            var a32d = asci.chars(tc.A32);
            var a32c = asci.codes((sbyte)c0,(sbyte)asci32.Size);
            Claim.yea(Symbolic.eq(a32d,a32c));

            var a64d = asci.chars(tc.A64);
            var a64c = asci.codes((sbyte)c0, (sbyte)asci64.Size);
            Claim.yea(Symbolic.eq(a64d,a64c));        
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
