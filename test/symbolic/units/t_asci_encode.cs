//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Asci;

    using C = AsciCharCode;

    public class t_asci_encode : t_symbolic<t_asci_encode>
    {
        public void unpack_4()
        {
            void check(char x, AsciCharCode y)
                => Claim.eq(encode(x), y);

            var src = span(z.array('1','2','3','4'));
            var dst = span(alloc<AsciCharCode>(4));
            encode(src,dst);
            root.iter(src, dst, check);
        }

        public void test_case_01()
        {
            var tc = default(AsciTestCase01);
            var result = AsciTestCases.execute(tc);
            // using var writer = CaseWriter(FileExtensions.Csv);
            // writer.Write(result.Description);
            Claim.yea(result.Passed);
        }

        public unsafe void string_ptr()
        {
            const string Src = "dalkfaldjflakdjfkadjflajdflajdkfajlskdfjasjdflkajfasf";
            var pSrc = memory.pchar(Src);
            var a = memory.cover(pSrc, Src.Length);
            var b = memory.span(Src);
            Claim.eq(a.Length, b.Length);
            Claim.eq(a.ToString(), b.ToString());

        }

        public void test_case_02()
        {

            var a2 = Asci.define(C.A, C.Z);
            Claim.ClaimEq(a2, "AZ");

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


    }
}
