//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static asci;

    using C = AsciCharCode;

    public class t_asci_encode : t_symbolic<t_asci_encode>
    {        
        public void unpack_4()
        {
            void check(char x, AsciCharCode y)
                => Claim.Eq(encode(x), y);
            
            var src = span(array('1','2','3','4'));
            var dst = span(alloc<AsciCharCode>(4));
            encode(src,dst);
            iter(src, dst, check);            
        }

        public void test_case_01()
        {
            var tc = default(AsciTestCase01);
            var result = AsciTestCases.execute(tc);
            using var writer = CaseWriter(FileExtensions.Csv);
            writer.Write(result.Description);
            Claim.yea(result.Success);
        }

        public void test_case_02()
        {

            var a2 = asci.init(C.A, C.Z);
            Claim.eq(a2, "AZ");

            //var tc = AsciTestCase02.Create(c0);
            
            // var a2d = asci.chars(tc.A2);
            // var a2c = asci.codes((sbyte)c0, (sbyte)asci2.Size);
            // Claim.yea(asci.eq(a2d,a2c));

            // var a4d = asci.chars(tc.A4);
            // var a4c = asci.codes((sbyte)c0, (sbyte)asci4.Size);
            // Claim.yea(asci.eq(a4d,a4c));
            
            // var a8d = asci.chars(tc.A8);
            // var a8c = asci.codes((sbyte)c0, (sbyte)asci8.Size);
            // Claim.yea(asci.eq(a8d,a8c));

            // var a16d = asci.chars(tc.A16);
            // var a16c = asci.codes((sbyte)c0, (sbyte)asci16.Size);
            // Claim.yea(asci.eq(a16d,a16c));

            // var a32d = asci.chars(tc.A32);
            // var a32c = asci.codes((sbyte)c0,(sbyte)asci32.Size);
            // Claim.yea(asci.eq(a32d,a32c));

            // var a64d = asci.chars(tc.A64);
            // var a64c = asci.codes((sbyte)c0, (sbyte)asci64.Size);
            // Claim.yea(asci.eq(a64d,a64c));        
        }

        public void res_HexKind()
        {
            var res = AsciResourceSet.create<Hex8Kind,asci4>();
            for(var i=0; i<res.EntryCount; i++)
            {                
                var expect = asci.encode(n4, text.concat('x', As.uint8(i).FormatHex(true, false)));
                ref readonly var actual = ref res[i];
                Claim.Eq(expect,actual);                        
            }
        }
    }
}
