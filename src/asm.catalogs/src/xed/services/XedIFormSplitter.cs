//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static XedModels;

    public ref struct XedFormSplitter
    {
        public static XedFormSplitter create(IWfRuntime sink)
            => new XedFormSplitter(sink);

        readonly IWfRuntime Wf;

        readonly Symbols<IForm> Source;

        readonly Symbols<AddressWidth> AddressWidths;

        readonly Symbols<AttributeKind> Attributes;

        readonly Symbols<Category> Categories;

        readonly Symbols<ChipCode> ChipCodes;

        readonly Symbols<IsaKind> IsaKinds;

        readonly Symbols<EncodingGroup> EncodingGroups;

        readonly Symbols<IClass> IClasses;

        readonly Symbols<Extension> Extensions;

        readonly Symbols<EFlag> EFlags;

        readonly Symbols<OperandKind> OpKinds;

        readonly Symbols<OperandVisibility> OpVisibility;

        readonly Symbols<OperandWidth> OpWidths;

        readonly Symbols<RegId> Registers;

        readonly Symbols<RegRole> RegRoles;

        readonly Symbols<RegClass> RegClasses;

        readonly Span<FormParition> Partitions;

        public XedFormSplitter(IWfRuntime wf)
        {
            Attributes = Symbols.cache<AttributeKind>();
            Categories = Symbols.cache<Category>();
            ChipCodes = Symbols.cache<ChipCode>();
            Source = Symbols.cache<IForm>();
            IsaKinds = Symbols.cache<IsaKind>();
            IClasses = Symbols.cache<IClass>();
            Extensions = Symbols.cache<Extension>();
            EFlags = Symbols.cache<EFlag>();
            Registers = Symbols.cache<RegId>();
            RegRoles = Symbols.cache<RegRole>();
            OpKinds = Symbols.cache<OperandKind>();
            OpVisibility = Symbols.cache<OperandVisibility>();
            RegClasses = Symbols.cache<RegClass>();
            AddressWidths = Symbols.cache<AddressWidth>();
            OpWidths = Symbols.cache<OperandWidth>();
            EncodingGroups = Symbols.cache<EncodingGroup>();
            Partitions = alloc<FormParition>(Source.Count);
            Wf = wf;
        }

        public ReadOnlySpan<FormParition> Run()
        {
            var count = Source.Count;
            var flow = Wf.Running(Msg.PartitioningIForms.Format(count));
            var forms = Source.View;
            for(ushort i=0; i<count; i++)
                Partition(i, skip(forms,i));
            Wf.Ran(flow, Msg.PartitionedIForms.Format(count));
            return Partitions;
        }

        void Partition(ushort index, IForm src)
        {
            ref var dst = ref seek(Partitions, index);
            dst.Index = index;
            dst.Source = src;
            dst.Parts = src.ToString().Split(Chars.Underscore);
            ref var parts = ref dst.Parts.First;
            var count = dst.Parts.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                if(i ==0)
                {
                    if(!Match(part, out dst.Class))
                    {
                        dst.Complete = false;
                        continue;
                    }
                }
                else
                {
                    Complete(ref dst);
                }
            }
        }

        bool Match(SymExpr src, out IClass dst)
            => IClasses.MatchKind(src, out dst);

        bool Match(SymExpr src, out OperandKind dst)
            => OpKinds.MatchKind(src, out dst);

        bool Match(SymExpr src, out EncodingGroup dst)
            => EncodingGroups.MatchKind(src, out dst);

        bool Match(SymExpr src, out AttributeKind dst)
            => Attributes.MatchKind(src, out dst);

        bool Match(SymExpr src, out AddressWidth dst)
            => AddressWidths.MatchKind(src, out dst);

        bool Match(SymExpr src, out OperandWidth dst)
            => OpWidths.MatchKind(src, out dst);

        bool Match(SymExpr src, out RegId dst)
            => Registers.MatchKind(src, out dst);

        void Complete(ref FormParition partition)
        {
            var count = partition.PartCount;
            if(count == 1)
                partition.Complete = true;
            else
            {
                ref var parts = ref partition.Parts[1];
                for(var i=1; i<count; i++)
                {

                }
            }
        }

    }
}

namespace Z0
{

    partial struct Msg
    {
        public static MsgPattern<Count> PartitioningIForms => "Partitioning {0} IForm identifiers";

        public static MsgPattern<Count> PartitionedIForms => "Partitoned {0} IForm identifiers";

    }

}