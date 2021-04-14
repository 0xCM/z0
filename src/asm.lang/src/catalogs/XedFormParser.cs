//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;
    using static XedModels;
    using static EventFactory;

    public ref struct XedFormParser
    {
        public static XedFormParser create(IWfEventSink sink)
            => new XedFormParser(sink, alloc<TextLine>(16), 8200);

        readonly Span<TextLine> LineBuffer;

        readonly Index<FormDetail> DetailTarget;

        readonly Index<FormInfo> SummaryTarget;

        readonly ResDescriptor DetailSource;

        readonly ResDescriptor SummarySource;

        readonly Symbols<AttributeKind> Attributes;

        readonly Symbols<Category> Categories;

        readonly Symbols<ChipCode> ChipCodes;

        readonly Symbols<IForm> IForms;

        readonly Symbols<IsaKind> IsaKinds;

        readonly Symbols<IClass> Classes;

        readonly Symbols<Extension> Extensions;

        readonly EventSignal Wf;

        XedFormParser(IWfEventSink sink, Span<TextLine> buffer, ushort count)
        {
            LineBuffer = buffer;
            DetailTarget = alloc<FormDetail>(count);
            SummaryTarget = alloc<FormInfo>(count);
            DetailSource = Parts.AsmCore.Assets.XedInstructionDetail();
            SummarySource = Parts.AsmCore.Assets.XedInstructionSummary();
            Attributes = Symbols.cache<AttributeKind>();
            Categories = Symbols.cache<Category>();
            ChipCodes = Symbols.cache<ChipCode>();
            IForms = Symbols.cache<IForm>();
            IsaKinds = Symbols.cache<IsaKind>();
            Classes = Symbols.cache<IClass>();
            Extensions = Symbols.cache<Extension>();
            Wf = EventSignal.create(sink, typeof(XedFormParser));
        }

        public Index<FormDetail> ParseDetails()
        {
            return DetailTarget;
        }

        public ReadOnlySpan<FormInfo> ParseSummaries()
        {
            using var reader = SummarySource.Utf8().Reader();
            var counter = 0u;
            var j = 0;
            var line = TextLine.Empty;
            var header = memory.alloc<string>(FormInfo.FieldCount);
            ref var dst = ref SummaryTarget.First;
            while(reader.ReadLine(++counter, out line))
            {
                if(line.StartsWith(CommentMarker))
                    continue;

                if(line.IsEmpty)
                    continue;

                if(counter==0)
                {
                    var outcome = ParseSummaryHeader(line,header);
                    if(!outcome)
                    {
                        Wf.Error(outcome.Message);
                        break;
                    }
                }
                else
                {
                   var info = new FormInfo();
                   var outcome = ParseSummary(line, out info);
                   if(!outcome)
                   {
                        Wf.Error(outcome.Message);
                        break;
                   }

                   seek(dst, j++) = info;
                }

                counter++;
            }

            return cover(dst, j);
        }

        void Validate(in FormInfo src)
        {

        }

        const char CommentMarker = Chars.Hash;

        const char FieldDelimiter = Chars.Space;

        static Outcome ParseSummaryHeader(TextLine src, Span<string> dst)
        {
            var parts = @readonly(src.Split(FieldDelimiter));
            var count = parts.Length;
            if(count != FormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {FormInfo.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }

        static Outcome ParseSummary(TextLine src, out FormInfo dst)
        {
            dst = default;
            var parts = @readonly(src.Split(FieldDelimiter));
            var count = parts.Length;
            if(count != FormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {FormInfo.FieldCount} as required");
            var i = 0;
            dst.Class = skip(parts,i++);
            dst.Extension = skip(parts,i++);
            dst.Category = skip(parts,i++);
            dst.Form = skip(parts,i++);
            dst.IsaSet = skip(parts,i++);
            dst.Attributes = skip(parts,i++);
            return true;
        }
    }

        /*
            [Line] [Class] [IForm] [Category] [Extension] [Chip] [Attributes]
            267 AND_LOCK AND_LOCK_MEMb_IMMb_82r4 LOGICAL BASE I86 ATTRIBUTES: BYTEOP HLE_ACQ_ABLE HLE_REL_ABLE LOCKED
            3
                0 MEM0 EXPLICIT RW IMM_CONST U8
                1 IMM0 EXPLICIT R IMM_CONST U8
                2 REG0 SUPPRESSED W NT_LOOKUP_FN INVALID RFLAGS
            268 AND_LOCK AND_LOCK_MEMv_IMMb LOGICAL BASE I86 ATTRIBUTES: HLE_ACQ_ABLE HLE_REL_ABLE LOCKED SCALABLE
            3
                0 MEM0 EXPLICIT RW IMM_CONST INT
                1 IMM0 EXPLICIT R IMM_CONST I8
                2 REG0 SUPPRESSED W NT_LOOKUP_FN INVALID RFLAGS

        */

}