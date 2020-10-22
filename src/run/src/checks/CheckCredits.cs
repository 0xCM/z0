//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static Checks;

    using static CreditTypes;
    using static CreditTypes.Vendor;
    using static CreditTypes.Volume;
    using static CreditTypes.Chapter;
    using static CreditTypes.Section;
    using static CreditTypes.Topic;
    using static CreditTypes.Appendix;
    using static CreditTypes.ContentNumber;

    using CT = CreditTypes.ContentType;
    using Step = CheckCreditsHost;

    [ApiHost]
    public ref struct CheckCredits
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public CheckCredits(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();
            try
            {
                Exec(CheckCreditFields, default(Step));
                Exec(CheckReferenceFields, default(Step));
                Exec(CheckContentFields, default(Step));
                Exec(CheckTableFields, default(Step));
                var result = CheckLiterals();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();

        }

        void Exec<C,R>(Func<R> f, C step = default)
            where C : IWfStep<C>, new()
            where R : ITextual
        {
            var fx = new WfFunc<C,R>(f.Method.Name);
            Wf.Status(fx, f());
        }

        void Status<C,R>(WfFunc<C> fx, R src)
            where C : struct, IWfStep<C>
            where R : ITextual
        {
            Wf.Status(src.Format());
        }

        [Op]
        static BitVector64 CheckCreditFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            result |= bveq(Credits.vendor(Intel).Vendor, Intel, index++);
            result |= bveq(Credits.vendor(Amd).Vendor, Amd, index++);
            result |= bveq(Credits.volume(Vol1).Volume, Vol1, index++);
            result |= bveq(Credits.volume(Vol2A).Volume, Vol2A, index++);
            result |= bveq(Credits.volume(Vol2B).Volume, Vol2B, index++);
            result |= bveq(Credits.volume(Vol2C).Volume, Vol2C, index++);
            result |= bveq(Credits.chapter(Chapter3).Chapter, Chapter3, index++);
            result |= bveq(Credits.chapter(Chapter4).Chapter, Chapter4, index++);
            result |= bveq(Credits.chapter(Chapter14).Chapter, Chapter14, index++);
            result |= bveq(Credits.chapter(Chapter8).Chapter, Chapter8, index++);
            result |= bveq(Credits.appendix(AppendixA).Appendix, AppendixA, index++);
            result |= bveq(Credits.appendix(AppendixB).Appendix, AppendixB, index++);
            result |= bveq(Credits.appendix(AppendixD).Appendix, AppendixD, index++);
            result |= bveq(Credits.section(Section2).Section, Section2, index++);
            result |= bveq(Credits.section(Section3).Section, Section3, index++);
            result |= bveq(Credits.section(Section10).Section, Section10, index++);
            result |= bveq(Credits.topic(Topic4).Topic, Topic4, index++);
            result |= bveq(Credits.topic(Topic7).Topic, Topic7, index++);
            result |= bveq(Credits.topic(Topic7).Topic, Topic7, index++);
            return result;
        }

        [Op]
        static BitVector64 CheckReferenceFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            var r1 = Credits.define(Intel, Vol2A, Chapter3, Section4, Topic5);
            result |= bveq(r1.Vendor, Intel, index++);
            result |= bveq(r1.Volume, Vol2A, index++);
            result |= bveq(r1.Chapter, Chapter3, index++);
            result |= bveq(r1.Section, Section4, index++);
            result |= bveq(r1.Topic, Topic5, index++);
            return result;
        }

        [Op]
        static BitVector64 CheckContentFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            var tr = Credits.table(d2, d3, d1);
            var r1 = Credits.define(Intel, Vol2A, Chapter3, Section4, Topic5, tr);
            result |= bveq(r1.Vendor, Intel, index++);
            result |= bveq(r1.Volume, Vol2A, index++);
            result |= bveq(r1.Chapter, Chapter3, index++);
            result |= bveq(r1.Section, Section4, index++);
            result |= bveq(r1.Topic, Topic5, index++);
            return result;
        }

        [Op]
        static BitVector64 CheckTableFields()
        {
            var result = BitVector64.Zero;
            var index = z8;
            var tr = Credits.table(d2, d3, d1);
            result |= bveq(tr.Level0, d2, index++);
            result |= bveq(tr.Level1, d3, index++);
            result |= bveq(tr.Level2, d1, index++);
            result |= bveq(tr.ContentType, CT.Table, index++);
            return result;
        }

        [Op]
        static ReadOnlySpan<Hex1> CheckLiterals()
        {
            var index = z8;
            var src = Enums.BinaryLiterals<DocField,ulong>().ToReadOnlySpan();
            var count = src.Length;
            var dst = span<Hex1>(count);
            Check(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        static void Check(ReadOnlySpan<BinaryLiteral<ulong>> src, Span<Hex1> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(src,i);
                var data = literal.Data;
                var text = literal.Text;
                var bits = BitSpans.parse(text);
                var bitval = bits.Convert<ulong>();
                seek(dst,i) = gmath.eq(bitval, data);
            }
        }
    }
}