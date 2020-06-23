//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static CreditTypes;
    using static CreditTypes.Vendor;
    using static CreditTypes.Volume;
    using static CreditTypes.Chapter;
    using static CreditTypes.Section;
    using static CreditTypes.Topic;
    using static CreditTypes.Appendix;
    using static CreditTypes.ContentNumber;
    using static CreditTypes.ContentType;

    public class t_docref : t_asmd<t_docref>
    { 
        
        public void t_component_encode()
        {
            Claim.Eq(Credits.vendor(Intel).Vendor, Intel);
            Claim.Eq(Credits.vendor(Amd).Vendor, Amd);
            Claim.Eq(Credits.volume(Vol1).Volume, Vol1);
            Claim.Eq(Credits.volume(Vol2A).Volume, Vol2A);
            Claim.Eq(Credits.volume(Vol2B).Volume, Vol2B);
            Claim.Eq(Credits.volume(Vol2C).Volume, Vol2C);
            Claim.Eq(Credits.chapter(Chapter3).Chapter, Chapter3);
            Claim.Eq(Credits.chapter(Chapter4).Chapter, Chapter4);
            Claim.Eq(Credits.chapter(Chapter14).Chapter, Chapter14);
            Claim.Eq(Credits.chapter(Chapter8).Chapter, Chapter8);
            Claim.Eq(Credits.appendix(AppendixA).Appendix, AppendixA);
            Claim.Eq(Credits.appendix(AppendixB).Appendix, AppendixB);
            Claim.Eq(Credits.appendix(AppendixD).Appendix, AppendixD);            
            Claim.Eq(Credits.section(Section2).Section, Section2);
            Claim.Eq(Credits.section(Section3).Section, Section3);
            Claim.Eq(Credits.section(Section10).Section, Section10);
            Claim.Eq(Credits.topic(Topic4).Topic, Topic4);
            Claim.Eq(Credits.topic(Topic7).Topic, Topic7);
            Claim.Eq(Credits.topic(Topic7).Topic, Topic7);
        }

        public void t_reference_encode()
        {
            var r1 = Credits.define(Intel, Vol2A, Chapter3, Section4, Topic5);
            Claim.Eq(r1.Vendor, Intel);
            Claim.Eq(r1.Volume, Vol2A);
            Claim.Eq(r1.Chapter, Chapter3);
            Claim.Eq(r1.Section, Section4);
            Claim.Eq(r1.Topic, Topic5);
        }

        public void t_reference_encode_content()
        {
            var tr = Credits.table(d2, d3, d1);
            var r1 = Credits.define(Intel, Vol2A, Chapter3, Section4, Topic5, tr);
            Claim.Eq(r1.Vendor, Intel);
            Claim.Eq(r1.Volume, Vol2A);
            Claim.Eq(r1.Chapter, Chapter3);
            Claim.Eq(r1.Section, Section4);
            Claim.Eq(r1.Topic, Topic5);
            //Claim.eq(r1.Content, tr);
        }

        public void t_tableref_encode()
        {
            var tr = Credits.table(d2, d3, d1);
            Claim.Eq(tr.Level0, d2);
            Claim.Eq(tr.Level1, d3);
            Claim.Eq(tr.Level2, d1);
            Claim.Eq(tr.ContentType, Table);                     
        }

        public void t_docref_bitfield()
        {
            var tField = typeof(DocField);
            var literals = Enums.BinaryLiterals<DocField,ulong>().ToArray();
            for(var i=0; i<literals.Length; i++)
            {
                var literal = literals[i];
                var bits = BitSpans.parse(literal.Text);
                var bitval = bits.Convert<ulong>();                
                Claim.yea(gmath.eq(bitval, literal.Data));
            }
        }
    }
}