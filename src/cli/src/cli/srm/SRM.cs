//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost]
    public unsafe partial class SRM
    {
        const string BadImageFormat = nameof(BadImageFormat);

        internal static class MetadataStreamConstants
        {
            internal const int SizeOfMetadataTableHeader = 24;
            internal const uint LargeTableRowCount = 0x00010000;
        }

        const int SmallIndexSize = 2;

        const int LargeIndexSize = 4;

        [MethodImpl(Inline), Op]
        public static bool IsDeclaredSorted(TableMask sorted, TableMask index)
            => (sorted & index) != 0;

        [MethodImpl(Inline), Op]
        public static MetadataReaderState initialize(MemorySeg src)
            => initialize(src.BaseAddress.Pointer<byte>(), src.Size);

        [MethodImpl(Inline), Op]
        public static MetadataReaderState initialize(Assembly src)
            => initialize(Clr.metadata(src));

        public static MetadataReaderState initialize(byte* metadata, int length, MetadataReaderOptions options = MetadataReaderOptions.Default)
        {
            var state = new MetadataReaderState();
            var utf8Decoder = MetadataStringDecoder.DefaultUTF8;
            var Block = block(metadata, length);
            state.RootBlock = Block;

            var headerReader = new BlobReader(Block);
            ReadMetadataHeader(ref headerReader, out var header);
            state.MetadataHeader = header;

            var _metadataKind = GetMetadataKind(header.VersionText);
            state.MetadataKind = _metadataKind;

            var streamHeaders = ReadStreamHeaders(ref headerReader);
            state.StreamHeaders = streamHeaders;

            InitializeStreamReaders(state, _metadataKind, Block, streamHeaders, out var _streamKind, out var metadataTableStream, out var pdbStream);
            state.StreamKind = _streamKind;
            state.MetadataBlock = metadataTableStream;
            state.PdbBlock = pdbStream;

            var externalTableRowCountsOpt = sys.empty<int>();
            if (pdbStream.Length > 0)
            {
                int pdbStreamOffset = (int)(pdbStream.Pointer - metadata);
                ReadStandalonePortablePdbStream(pdbStream, pdbStreamOffset, out var _debugMetadataHeader, out externalTableRowCountsOpt);
                state.DebugHeader = _debugMetadataHeader;
                state.ExternalTableRowCount = externalTableRowCountsOpt;
            }

            var tableReader = new BlobReader(metadataTableStream);
            ReadMetadataTableHeader(_streamKind, ref tableReader, out var heapSizes, out var metadataTableRowCounts, out var _sortedTables);
            state.HeapSizes = heapSizes;
            metadataTableRowCounts.CopyTo(state.TableRowCounts);
            state.SortedTables = _sortedTables;

            var metadataTableBlock = tableReader.GetMemoryBlockAt(0, tableReader.RemainingBytes);
            state.MetadataTableBlock = metadataTableBlock;

            InitializeTableReaders(state);

            return state;
        }

        static void InitializeTableReaders(MetadataReaderState state)
        {
            var rowCounts = state.TableRowCounts;

            // Compute ref sizes for tables that can have pointer tables
            var fieldRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.FieldPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Field);
            var methodRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.MethodPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.MethodDef);
            var paramRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.ParamPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Param);
            var eventRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.EventPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Event);
            var propertyRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.PropertyPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Property);

            state.PointerTableRefSizes = _PointerTableRefSizes(fieldRefSizeSorted, methodRefSizeSorted, paramRefSizeSorted,eventRefSizeSorted,propertyRefSizeSorted);

            // Compute the coded token ref sizes
            var typeDefOrRefRefSize = ComputeCodedTokenSize(TypeDefOrRefTag.LargeRowSize, rowCounts, TypeDefOrRefTag.TablesReferenced);
            var hasConstantRefSize = ComputeCodedTokenSize(HasConstantTag.LargeRowSize, rowCounts, HasConstantTag.TablesReferenced);
            var hasCustomAttributeRefSize = ComputeCodedTokenSize(HasCustomAttributeTag.LargeRowSize, rowCounts, HasCustomAttributeTag.TablesReferenced);
            var hasFieldMarshalRefSize = ComputeCodedTokenSize(HasFieldMarshalTag.LargeRowSize, rowCounts, HasFieldMarshalTag.TablesReferenced);
            var hasDeclSecurityRefSize = ComputeCodedTokenSize(HasDeclSecurityTag.LargeRowSize, rowCounts, HasDeclSecurityTag.TablesReferenced);
            var memberRefParentRefSize = ComputeCodedTokenSize(MemberRefParentTag.LargeRowSize, rowCounts, MemberRefParentTag.TablesReferenced);
            var hasSemanticsRefSize = ComputeCodedTokenSize(HasSemanticsTag.LargeRowSize, rowCounts, HasSemanticsTag.TablesReferenced);
            var methodDefOrRefRefSize = ComputeCodedTokenSize(MethodDefOrRefTag.LargeRowSize, rowCounts, MethodDefOrRefTag.TablesReferenced);
            var memberForwardedRefSize = ComputeCodedTokenSize(MemberForwardedTag.LargeRowSize, rowCounts, MemberForwardedTag.TablesReferenced);
            var implementationRefSize = ComputeCodedTokenSize(ImplementationTag.LargeRowSize, rowCounts, ImplementationTag.TablesReferenced);
            var customAttributeTypeRefSize = ComputeCodedTokenSize(CustomAttributeTypeTag.LargeRowSize, rowCounts, CustomAttributeTypeTag.TablesReferenced);
            var resolutionScopeRefSize = ComputeCodedTokenSize(ResolutionScopeTag.LargeRowSize, rowCounts, ResolutionScopeTag.TablesReferenced);
            var typeOrMethodDefRefSize = ComputeCodedTokenSize(TypeOrMethodDefTag.LargeRowSize, rowCounts, TypeOrMethodDefTag.TablesReferenced);

            var _codedTokenRefSizes = new CodedTokenRefSizes();
            _codedTokenRefSizes.TypeDefOrRefRefSize = (uint)typeDefOrRefRefSize;
            _codedTokenRefSizes.HasConstantRefSize = (uint)hasConstantRefSize;
            _codedTokenRefSizes.HasCustomAttributeRefSize = (uint)hasCustomAttributeRefSize;
            _codedTokenRefSizes.HasFieldMarshalRefSize = (uint)hasFieldMarshalRefSize;
            _codedTokenRefSizes.HasDeclSecurityRefSize = (uint)hasDeclSecurityRefSize;
            _codedTokenRefSizes.MemberRefParentRefSize = (uint)memberRefParentRefSize;
            _codedTokenRefSizes.HasSemanticsRefSize = (uint)hasSemanticsRefSize;
            _codedTokenRefSizes.MethodDefOrRefRefSize = (uint)methodDefOrRefRefSize;
            _codedTokenRefSizes.MemberForwardedRefSize = (uint)memberForwardedRefSize;
            _codedTokenRefSizes.ImplementationRefSize = (uint)implementationRefSize;
            _codedTokenRefSizes.CustomAttributeTypeRefSize = (uint)customAttributeTypeRefSize;
            _codedTokenRefSizes.ResolutionScopeRefSize = (uint)resolutionScopeRefSize;
            _codedTokenRefSizes.TypeOrMethodDefRefSize = (uint)typeOrMethodDefRefSize;
            state.CodedTokenRefSizes = _codedTokenRefSizes;

            var stringHeapRefSize = (((state.HeapSizes & HeapSizes.StringHeapLarge) == HeapSizes.StringHeapLarge) ? 4 : 2);
            var guidHeapRefSize = (((state.HeapSizes & HeapSizes.GuidHeapLarge) == HeapSizes.GuidHeapLarge) ? 4 : 2);
            var blobHeapRefSize = (((state.HeapSizes & HeapSizes.BlobHeapLarge) == HeapSizes.BlobHeapLarge) ? 4 : 2);

            var num = 0;

            var ModuleBlock = BlockFactories.ModuleTableBlock(rowCounts[0], stringHeapRefSize, guidHeapRefSize, state.MetadataTableBlock, num);
            num += ModuleBlock.Length;
            state.TableBlocks[CliTableKind.Module] = ModuleBlock;

            var TypeRefBlock = BlockFactories.TypeRefTableBlock(rowCounts[1], resolutionScopeRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            num += TypeRefBlock.Length;
            state.TableBlocks[CliTableKind.TypeRef] = TypeRefBlock;

            var TypeDefBlock = BlockFactories.TypeDefBlock(rowCounts[2], fieldRefSizeSorted, methodRefSizeSorted, typeDefOrRefRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            num += TypeDefBlock.Length;
            state.TableBlocks[CliTableKind.TypeDef] = TypeDefBlock;

            var FieldPtrBlock = BlockFactories.FieldPtrBlock(rowCounts[3], GetReferenceSize(rowCounts, TableIndex.Field), state.MetadataTableBlock, num);
            num += FieldPtrBlock.Length;
            state.TableBlocks[CliTableKind.FieldPtr] = FieldPtrBlock;

            var FieldBlock = BlockFactories.FieldBlock(rowCounts[4], stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            num += FieldBlock.Length;
            state.TableBlocks[CliTableKind.Field] = FieldBlock;

            var MethodPtrBlock = BlockFactories.MethodPtrBlock(rowCounts[5], GetReferenceSize(rowCounts, TableIndex.MethodDef), state.MetadataTableBlock, num);
            num += MethodPtrBlock.Length;
            state.TableBlocks[CliTableKind.MethodPtr] = MethodPtrBlock;

            var MethodDefBlock = BlockFactories.MethodDefBlock(rowCounts[6], paramRefSizeSorted, stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            num += MethodDefBlock.Length;
            state.TableBlocks[CliTableKind.MethodDef] = MethodDefBlock;

            // var ParamPtrTable = new ParamPtrTableReader(rowCounts[7], GetReferenceSize(rowCounts, TableIndex.Param), state.MetadataTableBlock, num);
            // num += ParamPtrTable.Block.Length;

            // var ParamTable = new ParamTableReader(rowCounts[8], stringHeapRefSize, state.MetadataTableBlock, num);
            // num += ParamTable.Block.Length;

            var InterfaceImplBlock = BlockFactories.InterfaceImplBlock(rowCounts[9], IsDeclaredSorted(state.SortedTables, TableMask.InterfaceImpl),
                GetReferenceSize(rowCounts, TableIndex.TypeDef), typeDefOrRefRefSize, state.MetadataTableBlock, num);
            num += InterfaceImplBlock.Length;
            state.TableBlocks[CliTableKind.InterfaceImpl] = InterfaceImplBlock;

            var MemberRefBlock = BlockFactories.MemberRefBlock(rowCounts[10], memberRefParentRefSize, stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            num += MemberRefBlock.Length;
            state.TableBlocks[CliTableKind.MemberRef] = MemberRefBlock;

            var ConstantBlock = BlockFactories.ConstantBlock(rowCounts[11], hasConstantRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            num += ConstantBlock.Length;
            state.TableBlocks[CliTableKind.Constant] = ConstantBlock;

            var CustomAttributeBlock = BlockFactories.CustomAttributeBlock(rowCounts[12], IsDeclaredSorted(state.SortedTables, TableMask.CustomAttribute), hasCustomAttributeRefSize, customAttributeTypeRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            num += CustomAttributeBlock.Length;
            state.TableBlocks[CliTableKind.CustomAttribute] = CustomAttributeBlock;

            // var FieldMarshalTable = new FieldMarshalTableReader(rowCounts[13], IsDeclaredSorted(TableMask.FieldMarshal), hasFieldMarshalRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += FieldMarshalTable.Block.Length;

            // var DeclSecurityTable = new DeclSecurityTableReader(rowCounts[14], IsDeclaredSorted(TableMask.DeclSecurity), hasDeclSecurityRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += DeclSecurityTable.Block.Length;

            // var ClassLayoutTable = new ClassLayoutTableReader(rowCounts[15], IsDeclaredSorted(TableMask.ClassLayout), GetReferenceSize(rowCounts, TableIndex.TypeDef), state.MetadataTableBlock, num);
            // num += ClassLayoutTable.Block.Length;

            // var FieldLayoutTable = new FieldLayoutTableReader(rowCounts[16], IsDeclaredSorted(TableMask.FieldLayout), GetReferenceSize(rowCounts, TableIndex.Field), state.MetadataTableBlock, num);
            // num += FieldLayoutTable.Block.Length;
            // var StandAloneSigTable = new StandAloneSigTableReader(rowCounts[17], blobHeapRefSize, state.MetadataTableBlock, num);
            // num += StandAloneSigTable.Block.Length;
            // var EventMapTable = new EventMapTableReader(rowCounts[18], GetReferenceSize(rowCounts, TableIndex.TypeDef), eventRefSize, state.MetadataTableBlock, num);
            // num += EventMapTable.Block.Length;
            // var EventPtrTable = new EventPtrTableReader(rowCounts[19], GetReferenceSize(rowCounts, TableIndex.Event), state.MetadataTableBlock, num);
            // num += EventPtrTable.Block.Length;
            // var EventTable = new EventTableReader(rowCounts[20], typeDefOrRefRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            // num += EventTable.Block.Length;
            // var PropertyMapTable = new PropertyMapTableReader(rowCounts[21], GetReferenceSize(rowCounts, TableIndex.TypeDef), propertyRefSize, state.MetadataTableBlock, num);
            // num += PropertyMapTable.Block.Length;
            // var PropertyPtrTable = new PropertyPtrTableReader(rowCounts[22], GetReferenceSize(rowCounts, TableIndex.Property), state.MetadataTableBlock, num);
            // num += PropertyPtrTable.Block.Length;
            // var PropertyTable = new PropertyTableReader(rowCounts[23], stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += PropertyTable.Block.Length;
            // var MethodSemanticsTable = new MethodSemanticsTableReader(rowCounts[24], IsDeclaredSorted(TableMask.MethodSemantics), GetReferenceSize(rowCounts, TableIndex.MethodDef), hasSemanticRefSize, state.MetadataTableBlock, num);
            // num += MethodSemanticsTable.Block.Length;

            var MethodImplBlock = BlockFactories.MethodImplBlock(rowCounts[25], IsDeclaredSorted(state.SortedTables, TableMask.MethodImpl),
                GetReferenceSize(rowCounts, TableIndex.TypeDef), methodDefOrRefRefSize, state.MetadataTableBlock, num);
            num += MethodImplBlock.Length;
            state.TableBlocks[CliTableKind.MethodImpl] = MethodImplBlock;

            // var ModuleRefTable = new ModuleRefTableReader(rowCounts[26], stringHeapRefSize, state.MetadataTableBlock, num);
            // num += ModuleRefTable.Block.Length;
            // var TypeSpecTable = new TypeSpecTableReader(rowCounts[27], blobHeapRefSize, state.MetadataTableBlock, num);
            // num += TypeSpecTable.Block.Length;
            // var ImplMapTable = new ImplMapTableReader(rowCounts[28], IsDeclaredSorted(TableMask.ImplMap), GetReferenceSize(rowCounts, TableIndex.ModuleRef), memberForwardedRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            // num += ImplMapTable.Block.Length;
            // var FieldRvaTable = new FieldRVATableReader(rowCounts[29], IsDeclaredSorted(TableMask.FieldRva), GetReferenceSize(rowCounts, TableIndex.Field), state.MetadataTableBlock, num);
            // num += FieldRvaTable.Block.Length;
            // var EncLogTable = new EnCLogTableReader(rowCounts[30], state.MetadataTableBlock, num, _metadataStreamKind);
            // num += EncLogTable.Block.Length;
            // var EncMapTable = new EnCMapTableReader(rowCounts[31], state.MetadataTableBlock, num);
            // num += EncMapTable.Block.Length;
            // var AssemblyTable = new AssemblyTableReader(rowCounts[32], stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += AssemblyTable.Block.Length;
            // var AssemblyProcessorTable = new AssemblyProcessorTableReader(rowCounts[33], state.MetadataTableBlock, num);
            // num += AssemblyProcessorTable.Block.Length;
            // var AssemblyOSTable = new AssemblyOSTableReader(rowCounts[34], state.MetadataTableBlock, num);
            // num += AssemblyOSTable.Block.Length;
            // var AssemblyRefTable = new AssemblyRefTableReader(rowCounts[35], stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num, _metadataKind);
            // num += AssemblyRefTable.Block.Length;
            // var AssemblyRefProcessorTable = new AssemblyRefProcessorTableReader(rowCounts[36], GetReferenceSize(rowCounts, TableIndex.AssemblyRef), state.MetadataTableBlock, num);
            // num += AssemblyRefProcessorTable.Block.Length;
            // var AssemblyRefOSTable = new AssemblyRefOSTableReader(rowCounts[37], GetReferenceSize(rowCounts, TableIndex.AssemblyRef), state.MetadataTableBlock, num);
            // num += AssemblyRefOSTable.Block.Length;
            // var FileTable = new FileTableReader(rowCounts[38], stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += FileTable.Block.Length;
            // var ExportedTypeTable = new ExportedTypeTableReader(rowCounts[39], implementationRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            // num += ExportedTypeTable.Block.Length;
            // var ManifestResourceTable = new ManifestResourceTableReader(rowCounts[40], implementationRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            // num += ManifestResourceTable.Block.Length;
            // var NestedClassTable = new NestedClassTableReader(rowCounts[41], IsDeclaredSorted(TableMask.NestedClass), GetReferenceSize(rowCounts, TableIndex.TypeDef), state.MetadataTableBlock, num);
            // num += NestedClassTable.Block.Length;
            // var GenericParamTable = new GenericParamTableReader(rowCounts[42], IsDeclaredSorted(TableMask.GenericParam), typeOrMethodDefRefSize, stringHeapRefSize, state.MetadataTableBlock, num);
            // num += GenericParamTable.Block.Length;
            // var MethodSpecTable = new MethodSpecTableReader(rowCounts[43], methodDefOrRefRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += MethodSpecTable.Block.Length;
            // var GenericParamConstraintTable = new GenericParamConstraintTableReader(rowCounts[44], IsDeclaredSorted(TableMask.GenericParamConstraint), GetReferenceSize(rowCounts, TableIndex.GenericParam), typeDefOrRefRefSize, state.MetadataTableBlock, num);
            // num += GenericParamConstraintTable.Block.Length;
            // int[] rowCounts2 = ((externalRowCountsOpt != null) ? CombineRowCounts(rowCounts, externalRowCountsOpt, TableIndex.Document) : rowCounts);
            // var referenceSize = GetReferenceSize(rowCounts2, TableIndex.MethodDef);
            // var hasCustomDebugInformationRefSize = ComputeCodedTokenSize(2048, rowCounts2, TableMask.Module | TableMask.TypeRef | TableMask.TypeDef | TableMask.Field | TableMask.MethodDef | TableMask.Param | TableMask.InterfaceImpl | TableMask.MemberRef | TableMask.DeclSecurity | TableMask.StandAloneSig | TableMask.Event | TableMask.Property | TableMask.ModuleRef | TableMask.TypeSpec | TableMask.Assembly | TableMask.AssemblyRef | TableMask.File | TableMask.ExportedType | TableMask.ManifestResource | TableMask.GenericParam | TableMask.MethodSpec | TableMask.GenericParamConstraint | TableMask.Document | TableMask.LocalScope | TableMask.LocalVariable | TableMask.LocalConstant | TableMask.ImportScope);
            // var DocumentTable = new DocumentTableReader(rowCounts[48], guidHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += DocumentTable.Block.Length;
            // var MethodDebugInformationTable = new MethodDebugInformationTableReader(rowCounts[49], GetReferenceSize(rowCounts, TableIndex.Document), blobHeapRefSize, state.MetadataTableBlock, num);
            // num += MethodDebugInformationTable.Block.Length;
            // var LocalScopeTable = new LocalScopeTableReader(rowCounts[50], IsDeclaredSorted(TableMask.LocalScope), referenceSize, GetReferenceSize(rowCounts, TableIndex.ImportScope), GetReferenceSize(rowCounts, TableIndex.LocalVariable), GetReferenceSize(rowCounts, TableIndex.LocalConstant), state.MetadataTableBlock, num);
            // num += LocalScopeTable.Block.Length;
            // var LocalVariableTable = new LocalVariableTableReader(rowCounts[51], stringHeapRefSize, state.MetadataTableBlock, num);
            // num += LocalVariableTable.Block.Length;
            // var LocalConstantTable = new LocalConstantTableReader(rowCounts[52], stringHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += LocalConstantTable.Block.Length;
            // var ImportScopeTable = new ImportScopeTableReader(rowCounts[53], GetReferenceSize(rowCounts, TableIndex.ImportScope), blobHeapRefSize, state.MetadataTableBlock, num);
            // num += ImportScopeTable.Block.Length;
            // var StateMachineMethodTable = new StateMachineMethodTableReader(rowCounts[54], IsDeclaredSorted(TableMask.StateMachineMethod), referenceSize, state.MetadataTableBlock, num);
            // num += StateMachineMethodTable.Block.Length;
            // var CustomDebugInformationTable = new CustomDebugInformationTableReader(rowCounts[55], IsDeclaredSorted(TableMask.CustomDebugInformation), hasCustomDebugInformationRefSize, guidHeapRefSize, blobHeapRefSize, state.MetadataTableBlock, num);
            // num += CustomDebugInformationTable.Block.Length;
            if (num > state.MetadataTableBlock.Length)
            {
                throw new Exception();
            }
        }
    }
}