//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata/src/System/Reflection/Metadata/MetadataReader.cs
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static core;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost]
    public unsafe partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static StringHandle StringHandleFromOffset(int heapOffset)
            => memory.@as<uint,StringHandle>(StringHandleType.String | (uint)heapOffset);

        [MethodImpl(Inline), Op]
        public static unsafe MemoryBlock block(byte* pSrc, int length)
            => new MemoryBlock(pSrc,length);

        bool IsMinimalDelta;

        private int GetReferenceSize(int[] rowCounts, TableIndex index)
        {
            if ((long)rowCounts[(uint)index] >= 65536L || IsMinimalDelta)
            {
                return 4;
            }
            return 2;
        }

        int ComputeCodedTokenSize(int largeRowSize, int[] rowCounts, TableMask tablesReferenced)
        {
            if (IsMinimalDelta)
            {
                return 4;
            }
            bool flag = true;
            ulong num = (ulong)tablesReferenced;
            for (int i = 0; i < MetadataTokens.TableCount; i++)
            {
                if ((num & 1) != 0L)
                {
                    flag = flag && rowCounts[i] < largeRowSize;
                }
                num >>= 1;
            }
            if (!flag)
            {
                return 4;
            }
            return 2;
        }

        static MemoryBlock InterfaceImplBlock(int numberOfRows, bool declaredSorted, int typeDefTableRowRefSize, int typeDefOrRefRefSize,
            MemoryBlock containingBlock, int containingBlockOffset)
        {
            var NumberOfRows = numberOfRows;
            var _IsTypeDefTableRowRefSizeSmall = typeDefTableRowRefSize == 2;
            var _IsTypeDefOrRefRefSizeSmall = typeDefOrRefRefSize == 2;
            var _ClassOffset = 0;
            var _InterfaceOffset = _ClassOffset + typeDefTableRowRefSize;
            var RowSize = _InterfaceOffset + typeDefOrRefRefSize;
            var Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            return Block;
        }

        static MemoryBlock TypeDefBlock(int numberOfRows,int fieldRefSize,int methodRefSize,int typeDefOrRefRefSize,int stringHeapRefSize,
            MemoryBlock containingBlock, int containingBlockOffset)
        {
            var NumberOfRows = numberOfRows;
            var _IsFieldRefSizeSmall = fieldRefSize == 2;
            var _IsMethodRefSizeSmall = methodRefSize == 2;
            var _IsTypeDefOrRefRefSizeSmall = typeDefOrRefRefSize == 2;
            var _IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
            var _FlagsOffset = 0;
            var _NameOffset = _FlagsOffset + sizeof(uint);
            var _NamespaceOffset = _NameOffset + stringHeapRefSize;
            var _ExtendsOffset = _NamespaceOffset + stringHeapRefSize;
            var _FieldListOffset = _ExtendsOffset + typeDefOrRefRefSize;
            var _MethodListOffset = _FieldListOffset + fieldRefSize;
            var RowSize = _MethodListOffset + methodRefSize;
            var Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            return Block;
        }

        static MemoryBlock TypeRefTableBlock(int numberOfRows, int resolutionScopeRefSize, int stringHeapRefSize, MemoryBlock containingBlock,int containingBlockOffset)
        {
            var NumberOfRows = numberOfRows;
            var _IsResolutionScopeRefSizeSmall = resolutionScopeRefSize == 2;
            var _IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
            var _ResolutionScopeOffset = 0;
            var _NameOffset = _ResolutionScopeOffset + resolutionScopeRefSize;
            var _NamespaceOffset = _NameOffset + stringHeapRefSize;
            var RowSize = _NamespaceOffset + stringHeapRefSize;
            return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
        }

        static MemoryBlock ModuleTableBlock(int numberOfRows, int stringHeapRefSize, int guidHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset)
        {
            var NumberOfRows = numberOfRows;
            var _IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
            var _IsGUIDHeapRefSizeSmall = guidHeapRefSize == 2;
            var _GenerationOffset = 0;
            var _NameOffset = _GenerationOffset + sizeof(ushort);
            var _MVIdOffset = _NameOffset + stringHeapRefSize;
            var _EnCIdOffset = _MVIdOffset + guidHeapRefSize;
            var _EnCBaseIdOffset = _EnCIdOffset + guidHeapRefSize;
            var RowSize = _EnCBaseIdOffset + guidHeapRefSize;
            return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
        }

        internal static class MetadataStreamConstants
        {
            internal const int SizeOfMetadataTableHeader = 24;
            internal const uint LargeTableRowCount = 0x00010000;
        }
        const int SmallIndexSize = 2;

        const int LargeIndexSize = 4;

        TableMask _sortedTables => Header.Tables;

        CliHeader Header;

        unsafe void Init(MemoryBlock src)
        {
            var tableReader = new BlobReader(src.Pointer, src.Length);

            ReadMetadataTableHeader(ref tableReader, out Header);
        }

        MetadataStreamKind _metadataStreamKind;

        Outcome ReadMetadataTableHeader(ref BlobReader reader, out CliHeader dst)
        {
            dst = default;
            if (reader.RemainingBytes < MetadataStreamConstants.SizeOfMetadataTableHeader)
                return false;

            // reserved (shall be ignored):
            reader.ReadUInt32();

            // major version (shall be ignored):
            reader.ReadByte();

            // minor version (shall be ignored):
            reader.ReadByte();

            // heap sizes:
            dst.HeapSizes = (HeapSizes)reader.ReadByte();

            // reserved (shall be ignored):
            reader.ReadByte();

            var presentTables = reader.ReadUInt64();
            dst.Tables = (TableMask)reader.ReadUInt64();

            // According to ECMA-335, MajorVersion and MinorVersion have fixed values and,
            // based on recommendation in 24.1 Fixed fields: When writing these fields it
            // is best that they be set to the value indicated, on reading they should be ignored.
            // We will not be checking version values. We will continue checking that the set of
            // present tables is within the set we understand.

            var validTables = (ulong)(TableMask.TypeSystemTables | TableMask.DebugTables);

            if ((presentTables & ~validTables) != 0)
                return false;

            dst.RowCounts = ReadMetadataTableRowCounts(ref reader, presentTables);

            if ((dst.HeapSizes & HeapSizes.ExtraData) == HeapSizes.ExtraData)
            {
                // Skip "extra data" used by some obfuscators. Although it is not mentioned in the CLI spec,
                // it is honored by the native metadata reader.
                reader.ReadUInt32();
            }
            return true;
        }

        /// <summary>
        /// Reads stream headers described in ECMA-335 24.2.2 Stream header
        /// </summary>
        static CliStreamHeader[] ReadStreamHeaders(ref BlobReader memReader)
        {
            // storage header:
            memReader.ReadUInt16();
            int streamCount = memReader.ReadInt16();

            var streamHeaders = new CliStreamHeader[streamCount];
            for (int i = 0; i < streamHeaders.Length; i++)
            {
                if (memReader.RemainingBytes < COR20Constants.MinimumSizeofStreamHeader)
                    return sys.empty<CliStreamHeader>();

                streamHeaders[i].Offset = memReader.ReadUInt32();
                streamHeaders[i].Size = memReader.ReadUInt32();
                //streamHeaders[i].Name = memReader.ReadUtf8NullTerminated();
                // bool aligned = memReader.TryAlign(4);

                // if (!aligned || memReader.RemainingBytes == 0)
                // {
                //     return sys.empty<CliStreamHeader>();
                // }
            }

            return streamHeaders;
        }

        static uint[] ReadMetadataTableRowCounts(ref BlobReader memReader, ulong presentTableMask)
        {
            var currentTableBit = 1ul;
            var buffer = new uint[MetadataTokens.TableCount];
            ref var dst = ref first(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                if ((presentTableMask & currentTableBit) != 0)
                {
                    if (memReader.RemainingBytes < sizeof(uint))
                        return sys.empty<uint>();

                    var rowCount = memReader.ReadUInt32();
                    if (rowCount > TokenTypeIds.RIDMask)
                        return sys.empty<uint>();

                    seek(dst, i) = (uint)rowCount;
                }

                currentTableBit <<= 1;
            }

            return buffer;
        }

        private bool IsDeclaredSorted(TableMask index)
        {
            return (_sortedTables & index) != 0;
        }

        void InitializeTableReaders(MemoryBlock metadataTablesMemoryBlock, HeapSizes heapSizes, int[] rowCounts, int[] externalRowCountsOpt)
        {
            var TableRowCounts = rowCounts;

            // Compute ref sizes for tables that can have pointer tables
            int fieldRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.FieldPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Field);
            int methodRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.MethodPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.MethodDef);
            int paramRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.ParamPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Param);
            int eventRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.EventPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Event);
            int propertyRefSizeSorted = GetReferenceSize(rowCounts, TableIndex.PropertyPtr) > SmallIndexSize ? LargeIndexSize : GetReferenceSize(rowCounts, TableIndex.Property);

            // Compute the coded token ref sizes
            int typeDefOrRefRefSize = ComputeCodedTokenSize(TypeDefOrRefTag.LargeRowSize, rowCounts, TypeDefOrRefTag.TablesReferenced);
            int hasConstantRefSize = ComputeCodedTokenSize(HasConstantTag.LargeRowSize, rowCounts, HasConstantTag.TablesReferenced);
            int hasCustomAttributeRefSize = ComputeCodedTokenSize(HasCustomAttributeTag.LargeRowSize, rowCounts, HasCustomAttributeTag.TablesReferenced);
            int hasFieldMarshalRefSize = ComputeCodedTokenSize(HasFieldMarshalTag.LargeRowSize, rowCounts, HasFieldMarshalTag.TablesReferenced);
            // int hasDeclSecurityRefSize = ComputeCodedTokenSize(HasDeclSecurityTag.LargeRowSize, rowCounts, HasDeclSecurityTag.TablesReferenced);
            // int memberRefParentRefSize = ComputeCodedTokenSize(MemberRefParentTag.LargeRowSize, rowCounts, MemberRefParentTag.TablesReferenced);
            // int hasSemanticsRefSize = ComputeCodedTokenSize(HasSemanticsTag.LargeRowSize, rowCounts, HasSemanticsTag.TablesReferenced);
            // int methodDefOrRefRefSize = ComputeCodedTokenSize(MethodDefOrRefTag.LargeRowSize, rowCounts, MethodDefOrRefTag.TablesReferenced);
            // int memberForwardedRefSize = ComputeCodedTokenSize(MemberForwardedTag.LargeRowSize, rowCounts, MemberForwardedTag.TablesReferenced);
            int implementationRefSize = ComputeCodedTokenSize(ImplementationTag.LargeRowSize, rowCounts, ImplementationTag.TablesReferenced);
            // int customAttributeTypeRefSize = ComputeCodedTokenSize(CustomAttributeTypeTag.LargeRowSize, rowCounts, CustomAttributeTypeTag.TablesReferenced);
            int resolutionScopeRefSize = ComputeCodedTokenSize(ResolutionScopeTag.LargeRowSize, rowCounts, ResolutionScopeTag.TablesReferenced);
            // int typeOrMethodDefRefSize = ComputeCodedTokenSize(TypeOrMethodDefTag.LargeRowSize, rowCounts, TypeOrMethodDefTag.TablesReferenced);

            int stringHeapRefSize = (((heapSizes & HeapSizes.StringHeapLarge) == HeapSizes.StringHeapLarge) ? 4 : 2);
            int guidHeapRefSize = (((heapSizes & HeapSizes.GuidHeapLarge) == HeapSizes.GuidHeapLarge) ? 4 : 2);
            int blobHeapRefSize = (((heapSizes & HeapSizes.BlobHeapLarge) == HeapSizes.BlobHeapLarge) ? 4 : 2);
            int num = 0;
            var _ModuleTableBlock = SRM.ModuleTableBlock(rowCounts[0], stringHeapRefSize, guidHeapRefSize, metadataTablesMemoryBlock, num);
            num += _ModuleTableBlock.Length;
            var _TypeRefTableBlock = SRM.TypeRefTableBlock(rowCounts[1], resolutionScopeRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            num += _TypeRefTableBlock.Length;
            var _TypeDefBlock = TypeDefBlock(rowCounts[2], fieldRefSizeSorted, methodRefSizeSorted, typeDefOrRefRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            num += _TypeDefBlock.Length;
            // var FieldPtrTable = new FieldPtrTableReader(rowCounts[3], GetReferenceSize(rowCounts, TableIndex.Field), metadataTablesMemoryBlock, num);
            // num += FieldPtrTable.Block.Length;
            // var FieldTable = new FieldTableReader(rowCounts[4], stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += FieldTable.Block.Length;
            // var MethodPtrTable = new MethodPtrTableReader(rowCounts[5], GetReferenceSize(rowCounts, TableIndex.MethodDef), metadataTablesMemoryBlock, num);
            // num += MethodPtrTable.Block.Length;
            // var MethodDefTable = new MethodTableReader(rowCounts[6], paramRefSize, stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += MethodDefTable.Block.Length;
            // var ParamPtrTable = new ParamPtrTableReader(rowCounts[7], GetReferenceSize(rowCounts, TableIndex.Param), metadataTablesMemoryBlock, num);
            // num += ParamPtrTable.Block.Length;
            // var ParamTable = new ParamTableReader(rowCounts[8], stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ParamTable.Block.Length;
            var _InterfaceImplBlock = SRM.InterfaceImplBlock(rowCounts[9], IsDeclaredSorted(TableMask.InterfaceImpl), GetReferenceSize(rowCounts, TableIndex.TypeDef), typeDefOrRefRefSize, metadataTablesMemoryBlock, num);
            num += _InterfaceImplBlock.Length;
            // var MemberRefTable = new MemberRefTableReader(rowCounts[10], memberRefParentRefSize, stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += MemberRefTable.Block.Length;
            // var ConstantTable = new ConstantTableReader(rowCounts[11], IsDeclaredSorted(TableMask.Constant), hasConstantRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ConstantTable.Block.Length;
            // var CustomAttributeTable = new CustomAttributeTableReader(rowCounts[12], IsDeclaredSorted(TableMask.CustomAttribute), hasCustomAttributeRefSize, customAttributeTypeRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += CustomAttributeTable.Block.Length;
            // var FieldMarshalTable = new FieldMarshalTableReader(rowCounts[13], IsDeclaredSorted(TableMask.FieldMarshal), hasFieldMarshalRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += FieldMarshalTable.Block.Length;
            // var DeclSecurityTable = new DeclSecurityTableReader(rowCounts[14], IsDeclaredSorted(TableMask.DeclSecurity), hasDeclSecurityRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += DeclSecurityTable.Block.Length;
            // var ClassLayoutTable = new ClassLayoutTableReader(rowCounts[15], IsDeclaredSorted(TableMask.ClassLayout), GetReferenceSize(rowCounts, TableIndex.TypeDef), metadataTablesMemoryBlock, num);
            // num += ClassLayoutTable.Block.Length;
            // var FieldLayoutTable = new FieldLayoutTableReader(rowCounts[16], IsDeclaredSorted(TableMask.FieldLayout), GetReferenceSize(rowCounts, TableIndex.Field), metadataTablesMemoryBlock, num);
            // num += FieldLayoutTable.Block.Length;
            // var StandAloneSigTable = new StandAloneSigTableReader(rowCounts[17], blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += StandAloneSigTable.Block.Length;
            // var EventMapTable = new EventMapTableReader(rowCounts[18], GetReferenceSize(rowCounts, TableIndex.TypeDef), eventRefSize, metadataTablesMemoryBlock, num);
            // num += EventMapTable.Block.Length;
            // var EventPtrTable = new EventPtrTableReader(rowCounts[19], GetReferenceSize(rowCounts, TableIndex.Event), metadataTablesMemoryBlock, num);
            // num += EventPtrTable.Block.Length;
            // var EventTable = new EventTableReader(rowCounts[20], typeDefOrRefRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += EventTable.Block.Length;
            // var PropertyMapTable = new PropertyMapTableReader(rowCounts[21], GetReferenceSize(rowCounts, TableIndex.TypeDef), propertyRefSize, metadataTablesMemoryBlock, num);
            // num += PropertyMapTable.Block.Length;
            // var PropertyPtrTable = new PropertyPtrTableReader(rowCounts[22], GetReferenceSize(rowCounts, TableIndex.Property), metadataTablesMemoryBlock, num);
            // num += PropertyPtrTable.Block.Length;
            // var PropertyTable = new PropertyTableReader(rowCounts[23], stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += PropertyTable.Block.Length;
            // var MethodSemanticsTable = new MethodSemanticsTableReader(rowCounts[24], IsDeclaredSorted(TableMask.MethodSemantics), GetReferenceSize(rowCounts, TableIndex.MethodDef), hasSemanticRefSize, metadataTablesMemoryBlock, num);
            // num += MethodSemanticsTable.Block.Length;
            // var MethodImplTable = new MethodImplTableReader(rowCounts[25], IsDeclaredSorted(TableMask.MethodImpl), GetReferenceSize(rowCounts, TableIndex.TypeDef), methodDefOrRefRefSize, metadataTablesMemoryBlock, num);
            // num += MethodImplTable.Block.Length;
            // var ModuleRefTable = new ModuleRefTableReader(rowCounts[26], stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ModuleRefTable.Block.Length;
            // var TypeSpecTable = new TypeSpecTableReader(rowCounts[27], blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += TypeSpecTable.Block.Length;
            // var ImplMapTable = new ImplMapTableReader(rowCounts[28], IsDeclaredSorted(TableMask.ImplMap), GetReferenceSize(rowCounts, TableIndex.ModuleRef), memberForwardedRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ImplMapTable.Block.Length;
            // var FieldRvaTable = new FieldRVATableReader(rowCounts[29], IsDeclaredSorted(TableMask.FieldRva), GetReferenceSize(rowCounts, TableIndex.Field), metadataTablesMemoryBlock, num);
            // num += FieldRvaTable.Block.Length;
            // var EncLogTable = new EnCLogTableReader(rowCounts[30], metadataTablesMemoryBlock, num, _metadataStreamKind);
            // num += EncLogTable.Block.Length;
            // var EncMapTable = new EnCMapTableReader(rowCounts[31], metadataTablesMemoryBlock, num);
            // num += EncMapTable.Block.Length;
            // var AssemblyTable = new AssemblyTableReader(rowCounts[32], stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += AssemblyTable.Block.Length;
            // var AssemblyProcessorTable = new AssemblyProcessorTableReader(rowCounts[33], metadataTablesMemoryBlock, num);
            // num += AssemblyProcessorTable.Block.Length;
            // var AssemblyOSTable = new AssemblyOSTableReader(rowCounts[34], metadataTablesMemoryBlock, num);
            // num += AssemblyOSTable.Block.Length;
            // var AssemblyRefTable = new AssemblyRefTableReader(rowCounts[35], stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num, _metadataKind);
            // num += AssemblyRefTable.Block.Length;
            // var AssemblyRefProcessorTable = new AssemblyRefProcessorTableReader(rowCounts[36], GetReferenceSize(rowCounts, TableIndex.AssemblyRef), metadataTablesMemoryBlock, num);
            // num += AssemblyRefProcessorTable.Block.Length;
            // var AssemblyRefOSTable = new AssemblyRefOSTableReader(rowCounts[37], GetReferenceSize(rowCounts, TableIndex.AssemblyRef), metadataTablesMemoryBlock, num);
            // num += AssemblyRefOSTable.Block.Length;
            // var FileTable = new FileTableReader(rowCounts[38], stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += FileTable.Block.Length;
            // var ExportedTypeTable = new ExportedTypeTableReader(rowCounts[39], implementationRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ExportedTypeTable.Block.Length;
            // var ManifestResourceTable = new ManifestResourceTableReader(rowCounts[40], implementationRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ManifestResourceTable.Block.Length;
            // var NestedClassTable = new NestedClassTableReader(rowCounts[41], IsDeclaredSorted(TableMask.NestedClass), GetReferenceSize(rowCounts, TableIndex.TypeDef), metadataTablesMemoryBlock, num);
            // num += NestedClassTable.Block.Length;
            // var GenericParamTable = new GenericParamTableReader(rowCounts[42], IsDeclaredSorted(TableMask.GenericParam), typeOrMethodDefRefSize, stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += GenericParamTable.Block.Length;
            // var MethodSpecTable = new MethodSpecTableReader(rowCounts[43], methodDefOrRefRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += MethodSpecTable.Block.Length;
            // var GenericParamConstraintTable = new GenericParamConstraintTableReader(rowCounts[44], IsDeclaredSorted(TableMask.GenericParamConstraint), GetReferenceSize(rowCounts, TableIndex.GenericParam), typeDefOrRefRefSize, metadataTablesMemoryBlock, num);
            // num += GenericParamConstraintTable.Block.Length;
            // int[] rowCounts2 = ((externalRowCountsOpt != null) ? CombineRowCounts(rowCounts, externalRowCountsOpt, TableIndex.Document) : rowCounts);
            // int referenceSize = GetReferenceSize(rowCounts2, TableIndex.MethodDef);
            // int hasCustomDebugInformationRefSize = ComputeCodedTokenSize(2048, rowCounts2, TableMask.Module | TableMask.TypeRef | TableMask.TypeDef | TableMask.Field | TableMask.MethodDef | TableMask.Param | TableMask.InterfaceImpl | TableMask.MemberRef | TableMask.DeclSecurity | TableMask.StandAloneSig | TableMask.Event | TableMask.Property | TableMask.ModuleRef | TableMask.TypeSpec | TableMask.Assembly | TableMask.AssemblyRef | TableMask.File | TableMask.ExportedType | TableMask.ManifestResource | TableMask.GenericParam | TableMask.MethodSpec | TableMask.GenericParamConstraint | TableMask.Document | TableMask.LocalScope | TableMask.LocalVariable | TableMask.LocalConstant | TableMask.ImportScope);
            // var DocumentTable = new DocumentTableReader(rowCounts[48], guidHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += DocumentTable.Block.Length;
            // var MethodDebugInformationTable = new MethodDebugInformationTableReader(rowCounts[49], GetReferenceSize(rowCounts, TableIndex.Document), blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += MethodDebugInformationTable.Block.Length;
            // var LocalScopeTable = new LocalScopeTableReader(rowCounts[50], IsDeclaredSorted(TableMask.LocalScope), referenceSize, GetReferenceSize(rowCounts, TableIndex.ImportScope), GetReferenceSize(rowCounts, TableIndex.LocalVariable), GetReferenceSize(rowCounts, TableIndex.LocalConstant), metadataTablesMemoryBlock, num);
            // num += LocalScopeTable.Block.Length;
            // var LocalVariableTable = new LocalVariableTableReader(rowCounts[51], stringHeapRefSize, metadataTablesMemoryBlock, num);
            // num += LocalVariableTable.Block.Length;
            // var LocalConstantTable = new LocalConstantTableReader(rowCounts[52], stringHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += LocalConstantTable.Block.Length;
            // var ImportScopeTable = new ImportScopeTableReader(rowCounts[53], GetReferenceSize(rowCounts, TableIndex.ImportScope), blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += ImportScopeTable.Block.Length;
            // var StateMachineMethodTable = new StateMachineMethodTableReader(rowCounts[54], IsDeclaredSorted(TableMask.StateMachineMethod), referenceSize, metadataTablesMemoryBlock, num);
            // num += StateMachineMethodTable.Block.Length;
            // var CustomDebugInformationTable = new CustomDebugInformationTableReader(rowCounts[55], IsDeclaredSorted(TableMask.CustomDebugInformation), hasCustomDebugInformationRefSize, guidHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
            // num += CustomDebugInformationTable.Block.Length;
            if (num > metadataTablesMemoryBlock.Length)
            {
                throw new Exception();
            }
        }

    }
}