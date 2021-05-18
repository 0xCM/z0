//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static BitChecks;

    using static CreditModel;
    using static CreditModel.Vendor;
    using static CreditModel.Volume;
    using static CreditModel.Chapter;
    using static CreditModel.Section;
    using static CreditModel.Topic;
    using static CreditModel.Appendix;
    using static CreditModel.ContentNumber;

    using CT = CreditModel.ContentType;

    [ApiHost]
    public class CheckCredits : AppService<CheckCredits>
    {
        public void Run()
        {
            var flow = Wf.Running();
            try
            {
                Exec(CheckCreditFields);
                Exec(CheckReferenceFields);
                Exec(CheckContentFields);
                Exec(CheckTableFields);
                var result = CheckLiterals();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(flow);
        }

        void Exec<R>(Func<R> f)
            => Wf.Status($"{f()}");


        [Op]
        BitVector64 CheckCreditFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            result |= bveq(CreditBits.vendor(Intel).Vendor, Intel, index++);
            result |= bveq(CreditBits.vendor(Amd).Vendor, Amd, index++);
            result |= bveq(CreditBits.volume(Vol1).Volume, Vol1, index++);
            result |= bveq(CreditBits.volume(Vol2A).Volume, Vol2A, index++);
            result |= bveq(CreditBits.volume(Vol2B).Volume, Vol2B, index++);
            result |= bveq(CreditBits.volume(Vol2C).Volume, Vol2C, index++);
            result |= bveq(CreditBits.chapter(Chapter3).Chapter, Chapter3, index++);
            result |= bveq(CreditBits.chapter(Chapter4).Chapter, Chapter4, index++);
            result |= bveq(CreditBits.chapter(Chapter14).Chapter, Chapter14, index++);
            result |= bveq(CreditBits.chapter(Chapter8).Chapter, Chapter8, index++);
            result |= bveq(CreditBits.appendix(AppendixA).Appendix, AppendixA, index++);
            result |= bveq(CreditBits.appendix(AppendixB).Appendix, AppendixB, index++);
            result |= bveq(CreditBits.appendix(AppendixD).Appendix, AppendixD, index++);
            result |= bveq(CreditBits.section(Section2).Section, Section2, index++);
            result |= bveq(CreditBits.section(Section3).Section, Section3, index++);
            result |= bveq(CreditBits.section(Section10).Section, Section10, index++);
            result |= bveq(CreditBits.topic(Topic4).Topic, Topic4, index++);
            result |= bveq(CreditBits.topic(Topic7).Topic, Topic7, index++);
            result |= bveq(CreditBits.topic(Topic7).Topic, Topic7, index++);
            return result;
        }

        [Op]
        BitVector64 CheckReferenceFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            var r1 = CreditBits.credit(Intel, Vol2A, Chapter3, Section4, Topic5);
            result |= bveq(r1.Vendor, Intel, index++);
            result |= bveq(r1.Volume, Vol2A, index++);
            result |= bveq(r1.Chapter, Chapter3, index++);
            result |= bveq(r1.Section, Section4, index++);
            result |= bveq(r1.Topic, Topic5, index++);
            return result;
        }

        [Op]
        BitVector64 CheckContentFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            var tr = CreditBits.table(d2, d3, d1);
            var r1 = CreditBits.credit(Intel, Vol2A, Chapter3, Section4, Topic5, tr);
            result |= bveq(r1.Vendor, Intel, index++);
            result |= bveq(r1.Volume, Vol2A, index++);
            result |= bveq(r1.Chapter, Chapter3, index++);
            result |= bveq(r1.Section, Section4, index++);
            result |= bveq(r1.Topic, Topic5, index++);
            return result;
        }

        [Op]
        BitVector64 CheckTableFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            var tr = CreditBits.table(d2, d3, d1);
            result |= bveq(tr.Level0, d2, index++);
            result |= bveq(tr.Level1, d3, index++);
            result |= bveq(tr.Level2, d1, index++);
            result |= bveq(tr.ContentType, CT.Table, index++);
            return result;
        }

        ReadOnlySpan<bit> CheckLiterals()
        {
            var index = z8;
            var src = TaggedLiterals.binary<DocField,ulong>().ToReadOnlySpan();
            var count = src.Length;
            var dst = span<bit>(count);
            Check(src,dst);
            return dst;
        }

        [Op]
        void Check(ReadOnlySpan<BinaryLiteral<ulong>> src, Span<bit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(src,i);
                var data = literal.Data;
                var text = literal.Text;
                var bits = BitSpans32.parse(text);
                var bitval = bits.Convert<ulong>();
                seek(dst,i) = gmath.eq(bitval, data);
            }
        }
    }
}