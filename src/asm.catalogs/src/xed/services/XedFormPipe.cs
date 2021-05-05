//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;
    using static XedModels;
    using static AsmRecords;

    public class XedFormPipe
    {
        public static XedFormPipe create(IWfRuntime wf)
            => new XedFormPipe(wf);

        readonly IWfRuntime Wf;

        readonly IEnvPaths Paths;

        readonly Symbols<IFormType> FormTypes;

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

        readonly Symbols<OperandWidthType> OpWidths;

        readonly Symbols<RegId> Registers;

        readonly Symbols<RegRole> RegRoles;

        readonly Symbols<RegClass> RegClasses;

        Index<FormPartiton> Partitions;

        Index<FormAspect> Aspects;

        public XedFormPipe(IWfRuntime wf)
        {
            Wf = wf;
            Paths = wf.Db();
            Attributes = Symbols.symbolic<AttributeKind>();
            Categories = Symbols.symbolic<Category>();
            ChipCodes = Symbols.symbolic<ChipCode>();
            FormTypes = Symbols.symbolic<IFormType>();
            IsaKinds = Symbols.symbolic<IsaKind>();
            IClasses = Symbols.symbolic<IClass>();
            Extensions = Symbols.symbolic<Extension>();
            EFlags = Symbols.symbolic<EFlag>();
            Registers = Symbols.symbolic<RegId>();
            RegRoles = Symbols.symbolic<RegRole>();
            OpKinds = Symbols.symbolic<OperandKind>();
            OpVisibility = Symbols.symbolic<OperandVisibility>();
            RegClasses = Symbols.symbolic<RegClass>();
            AddressWidths = Symbols.symbolic<AddressWidth>();
            OpWidths = Symbols.symbolic<OperandWidthType>();
            EncodingGroups = Symbols.symbolic<EncodingGroup>();
            Aspects = Index<FormAspect>.Empty;
            Partitions = Index<FormPartiton>.Empty;
        }

        AsmCatPaths CatPaths
            => new AsmCatPaths(Paths);

        public Index<XedFormAspect> EmitFormAspects()
        {
            var duplicates = root.dict<Hash32,uint>();
            var pipe = Wf.XedFormPipe();
            var aspects = pipe.ComputeFormAspects();
            var count = (uint)aspects.Length;
            var buffer = alloc<XedFormAspect>(count);
            var path = CatPaths.XedFormAspectPath();
            var formatter = Tables.formatter<XedFormAspect>();
            var emitting = Wf.EmittingTable<XedFormAspect>(path);
            using var writer = path.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
            {
                ref var record = ref seek(buffer,i);
                ref readonly var aspect = ref skip(aspects,i);
                record.Index = i;
                record.Value = aspect.Value;
                record.Hash = aspect.GetHashCode();
                if(duplicates.TryGetValue(record.Hash, out var c))
                    duplicates[record.Hash] = ++c;
                else
                    duplicates.Add(record.Hash, 0);
                writer.WriteLine(formatter.Format(record));
            }

            var perfect = !duplicates.Values.Any(x => x > 0);
            if(perfect)
            {
                Wf.Status($"Hash Perfect");
            }
            else
                Wf.Warn("Hash Imperfect");

            Wf.EmittedTable(emitting, count);
            return buffer;
        }

        public ReadOnlySpan<FormAspect> ComputeFormAspects()
        {
            if(Aspects.Length != 0)
                return Aspects;
            else
            {
                var count = FormTypes.Count;
                var forms = FormTypes.View;
                var distinct = root.hashset<FormAspect>();
                var counter = 0u;
                for(ushort i=0; i<count; i++)
                {
                    var form = skip(forms,i);
                    var parts = @readonly(form.Kind.ToString().Split(Chars.Underscore));
                    var kParts = parts.Length;
                    if(kParts < 2)
                        continue;

                    for(var j=1; j<kParts; j++)
                    {
                        if(distinct.Add(skip(parts,j)))
                            counter++;
                    }
                }

                Aspects = root.index(distinct.ToArray()).Sort();
                return Aspects;
            }
        }

        public ReadOnlySpan<FormPartiton> ComputePartitions()
        {
            if(Partitions.Length != 0)
                return Partitions;

            Partitions = alloc<FormPartiton>(FormTypes.Count);

            var count = FormTypes.Count;
            var flow = Wf.Running(Msg.PartitioningIForms.Format(count));
            var forms = FormTypes.View;

            for(ushort i=0; i<count; i++)
                Partition(i, skip(forms,i));
            Wf.Ran(flow, Msg.PartitionedIForms.Format(count));
            return Partitions;
        }

        void Partition(ushort index, IFormType src)
        {
            ref var dst = ref seek(Partitions.First, index);
            dst.Index = index;
            dst.Form = src;

            var candidates = span(src.ToString().Split(Chars.Underscore));
            if(candidates.Length <= 1)
                return;

            dst.Aspects = slice(candidates,1).ToArray();
            ref var parts = ref dst.Aspects.First;
            var count = dst.Aspects.Count;

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

        bool Match(SymExpr src, out OperandWidthType dst)
            => OpWidths.MatchKind(src, out dst);

        bool Match(SymExpr src, out RegId dst)
            => Registers.MatchKind(src, out dst);

        void Complete(ref FormPartiton partition)
        {
            var count = partition.AspectCount;
            if(count == 0)
            {
                partition.Complete = true;
            }
            else
            {
                ref var parts = ref partition.Aspects[1];
                for(var i=0; i<count; i++)
                {

                }
                partition.Complete = true;
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