//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static CreditModel;
    using static CreditModel.Vendor;
    using static CreditModel.Volume;
    using static CreditModel.Chapter;
    using static CreditModel.Section;
    using static CreditModel.Topic;
    using static CreditModel.Appendix;
    using static CreditModel.ContentNumber;
    using static CreditModel.ContentType;

    public class t_docref : t_bits<t_docref>
    {
        public void t_component_encode()
        {
            Claim.eq(CreditBits.vendor(Intel).Vendor, Intel);
            Claim.eq(CreditBits.vendor(Amd).Vendor, Amd);
            Claim.eq(CreditBits.volume(Vol1).Volume, Vol1);
            Claim.eq(CreditBits.volume(Vol2A).Volume, Vol2A);
            Claim.eq(CreditBits.volume(Vol2B).Volume, Vol2B);
            Claim.eq(CreditBits.volume(Vol2C).Volume, Vol2C);
            Claim.eq(CreditBits.chapter(Chapter3).Chapter, Chapter3);
            Claim.eq(CreditBits.chapter(Chapter4).Chapter, Chapter4);
            Claim.eq(CreditBits.chapter(Chapter14).Chapter, Chapter14);
            Claim.eq(CreditBits.chapter(Chapter8).Chapter, Chapter8);
            Claim.eq(CreditBits.appendix(AppendixA).Appendix, AppendixA);
            Claim.eq(CreditBits.appendix(AppendixB).Appendix, AppendixB);
            Claim.eq(CreditBits.appendix(AppendixD).Appendix, AppendixD);
            Claim.eq(CreditBits.section(Section2).Section, Section2);
            Claim.eq(CreditBits.section(Section3).Section, Section3);
            Claim.eq(CreditBits.section(Section10).Section, Section10);
            Claim.eq(CreditBits.topic(Topic4).Topic, Topic4);
            Claim.eq(CreditBits.topic(Topic7).Topic, Topic7);
            Claim.eq(CreditBits.topic(Topic7).Topic, Topic7);
        }

        public void t_reference_encode()
        {
            var r1 = CreditBits.credit(Intel, Vol2A, Chapter3, Section4, Topic5);
            Claim.eq(r1.Vendor, Intel);
            Claim.eq(r1.Volume, Vol2A);
            Claim.eq(r1.Chapter, Chapter3);
            Claim.eq(r1.Section, Section4);
            Claim.eq(r1.Topic, Topic5);
        }

        public void t_reference_encode_content()
        {
            var tr = CreditBits.table(d2, d3, d1);
            var r1 = CreditBits.credit(Intel, Vol2A, Chapter3, Section4, Topic5, tr);
            Claim.eq(r1.Vendor, Intel);
            Claim.eq(r1.Volume, Vol2A);
            Claim.eq(r1.Chapter, Chapter3);
            Claim.eq(r1.Section, Section4);
            Claim.eq(r1.Topic, Topic5);
            //Claim.eq(r1.Content, tr);
        }

        public void t_tableref_encode()
        {
            var tr = CreditBits.table(d2, d3, d1);
            Claim.eq(tr.Level0, d2);
            Claim.eq(tr.Level1, d3);
            Claim.eq(tr.Level2, d1);
            Claim.eq(tr.ContentType, CreditModel.ContentType.Table);
        }

        public void t_docref_bitfield()
        {
            var tField = typeof(DocField);
            var literals = TaggedLiterals.binary<DocField,ulong>();
            for(var i=0; i<literals.Length; i++)
            {
                var literal = literals[i];
                var bits = BitSpans32.parse(literal.Text);
                var bitval = bits.Convert<ulong>();
                Claim.yea(gmath.eq(bitval, literal.Data));
            }
        }
    }
}