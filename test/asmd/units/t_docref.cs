//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Vendor;
    using static Volume;
    using static Chapter;
    using static Section;
    using static Topic;
    using static Appendix;
    using static ContentNumber;
    using static ContentType;

    public class t_docref : t_asmd<t_docref>
    { 
        
        public void t_component_encode()
        {
            Claim.eq(References.vendor(Intel).Vendor, Intel);
            Claim.eq(References.vendor(Amd).Vendor, Amd);
            Claim.eq(References.volume(Vol1).Volume, Vol1);
            Claim.eq(References.volume(Vol2A).Volume, Vol2A);
            Claim.eq(References.volume(Vol2B).Volume, Vol2B);
            Claim.eq(References.volume(Vol2C).Volume, Vol2C);
            Claim.eq(References.chapter(Chapter3).Chapter, Chapter3);
            Claim.eq(References.chapter(Chapter4).Chapter, Chapter4);
            Claim.eq(References.chapter(Chapter14).Chapter, Chapter14);
            Claim.eq(References.chapter(Chapter8).Chapter, Chapter8);
            Claim.eq(References.appendix(AppendixA).Appendix, AppendixA);
            Claim.eq(References.appendix(AppendixB).Appendix, AppendixB);
            Claim.eq(References.appendix(AppendixD).Appendix, AppendixD);            
            Claim.eq(References.section(Section2).Section, Section2);
            Claim.eq(References.section(Section3).Section, Section3);
            Claim.eq(References.section(Section10).Section, Section10);
            Claim.eq(References.topic(Topic4).Topic, Topic4);
            Claim.eq(References.topic(Topic7).Topic, Topic7);
            Claim.eq(References.topic(Topic7).Topic, Topic7);
        }

        public void t_reference_encode()
        {
            var r1 = References.define(Intel, Vol2A, Chapter3, Section4, Topic5);
            Claim.eq(r1.Vendor, Intel);
            Claim.eq(r1.Volume, Vol2A);
            Claim.eq(r1.Chapter, Chapter3);
            Claim.eq(r1.Section, Section4);
            Claim.eq(r1.Topic, Topic5);
        }

        public void t_reference_encode_content()
        {
            var tr = References.table(d2, d3, d1);
            var r1 = References.define(Intel, Vol2A, Chapter3, Section4, Topic5, tr);
            Claim.eq(r1.Vendor, Intel);
            Claim.eq(r1.Volume, Vol2A);
            Claim.eq(r1.Chapter, Chapter3);
            Claim.eq(r1.Section, Section4);
            Claim.eq(r1.Topic, Topic5);
            //Claim.eq(r1.Content, tr);
        }

        public void t_tableref_encode()
        {
            var tr = References.table(d2, d3, d1);
            Claim.eq(tr.Level0, d2);
            Claim.eq(tr.Level1, d3);
            Claim.eq(tr.Level2, d1);
            Claim.eq(tr.ContentType, Table);                     
        }

        public void t_docref_bitfield()
        {
            var tField = typeof(DocField);
            var literals = Enums.binlits<DocField,ulong>().ToArray();
            for(var i=0; i<literals.Length; i++)
            {
                var literal = literals[i];
                var bits = BitSpans.parse(literal.Text);
                var bitval = bits.Convert<ulong>();                
                Claim.yea(gmath.eq(bitval, literal.Value));
            }
        }
    }
}