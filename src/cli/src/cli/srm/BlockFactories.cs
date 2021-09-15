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

    using static Root;
    using static core;
    using static CliRows;

    partial class SRM
    {
        [ApiHost("srm.blockfactories")]
        public readonly struct BlockFactories
        {
            [MethodImpl(Inline), Op]
            public static MemoryBlock<T> block<T>(MemoryBlock src)
                where T : unmanaged, ICliRecord<T>
                    => src;

            [Op]
            public static MemoryBlock<FieldPtrRow> FieldPtrBlock(int numberOfRows, int fieldTableRowRefSize,
                MemoryBlock containingBlock, int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsFieldTableRowRefSizeSmall = fieldTableRowRefSize == 2;
                var _FieldOffset = 0;
                var RowSize = _FieldOffset + fieldTableRowRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            [Op]
            public static MemoryBlock<InterfaceImplRow> InterfaceImplBlock(int numberOfRows, bool declaredSorted, int typeDefTableRowRefSize, int typeDefOrRefRefSize,
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

            [Op]
            public static MemoryBlock<TypeDefRow> TypeDefBlock(int numberOfRows,int fieldRefSize,int methodRefSize,int typeDefOrRefRefSize,int stringHeapRefSize,
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

            [Op]
            public static MemoryBlock<TypeRefRow> TypeRefTableBlock(int numberOfRows, int resolutionScopeRefSize, int stringHeapRefSize,
                MemoryBlock containingBlock,int containingBlockOffset)
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

            [Op]
            public static MemoryBlock<ModuleRefRow> ModuleTableBlock(int numberOfRows, int stringHeapRefSize, int guidHeapRefSize,
                MemoryBlock containingBlock, int containingBlockOffset)
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

            [Op]
            public static MemoryBlock<MethodImplRow> MethodImplBlock(int numberOfRows,bool declaredSorted, int typeDefTableRowRefSize, int methodDefOrRefRefSize,
                MemoryBlock containingBlock, int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsTypeDefTableRowRefSizeSmall = typeDefTableRowRefSize == 2;
                var _IsMethodDefOrRefRefSizeSmall = methodDefOrRefRefSize == 2;
                var _ClassOffset = 0;
                var _MethodBodyOffset = _ClassOffset + typeDefTableRowRefSize;
                var _MethodDeclarationOffset = _MethodBodyOffset + methodDefOrRefRefSize;
                var RowSize = _MethodDeclarationOffset + methodDefOrRefRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            [Op]
            public static MemoryBlock<FieldDefRow> FieldBlock(int numberOfRows, int stringHeapRefSize, int blobHeapRefSize,
                MemoryBlock containingBlock,int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
                var _IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
                var _FlagsOffset = 0;
                var _NameOffset = _FlagsOffset + sizeof(ushort);
                var _SignatureOffset = _NameOffset + stringHeapRefSize;
                var RowSize = _SignatureOffset + blobHeapRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            [Op]
            public static MemoryBlock<MethodPtrRow> MethodPtrBlock(int numberOfRows, int methodTableRowRefSize,
                MemoryBlock containingBlock, int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsMethodTableRowRefSizeSmall = methodTableRowRefSize == 2;
                var _MethodOffset = 0;
                var RowSize = _MethodOffset + methodTableRowRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            [Op]
            public static MemoryBlock<MethodDefRow> MethodDefBlock(int numberOfRows, int paramRefSize, int stringHeapRefSize, int blobHeapRefSize,
                MemoryBlock containingBlock, int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsParamRefSizeSmall = paramRefSize == 2;
                var _IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
                var _IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
                var _RvaOffset = 0;
                var _ImplFlagsOffset = _RvaOffset + sizeof(uint);
                var _FlagsOffset = _ImplFlagsOffset + sizeof(ushort);
                var _NameOffset = _FlagsOffset + sizeof(ushort);
                var _SignatureOffset = _NameOffset + stringHeapRefSize;
                var _ParamListOffset = _SignatureOffset + blobHeapRefSize;
                var RowSize = _ParamListOffset + paramRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            [Op]
            public static MemoryBlock<MemberRefRow> MemberRefBlock(int numberOfRows, int memberRefParentRefSize, int stringHeapRefSize, int blobHeapRefSize,
                MemoryBlock containingBlock,int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsMemberRefParentRefSizeSmall = memberRefParentRefSize == 2;
                var _IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
                var _IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
                var _ClassOffset = 0;
                var _NameOffset = _ClassOffset + memberRefParentRefSize;
                var _SignatureOffset = _NameOffset + stringHeapRefSize;
                var RowSize = _SignatureOffset + blobHeapRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            [Op]
            public static MemoryBlock<ConstantRow> ConstantBlock(int numberOfRows, int hasConstantRefSize, int blobHeapRefSize,
                MemoryBlock containingBlock,int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsHasConstantRefSizeSmall = hasConstantRefSize == 2;
                var _IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
                var _TypeOffset = 0;
                var _ParentOffset = _TypeOffset + sizeof(byte) + 1; // Alignment here (+1)...
                var _ValueOffset = _ParentOffset + hasConstantRefSize;
                var RowSize = _ValueOffset + blobHeapRefSize;
                return containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
            }

            public static MemoryBlock CustomAttributeBlock(int numberOfRows, bool declaredSorted, int hasCustomAttributeRefSize, int customAttributeTypeRefSize,
                int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset)
            {
                var NumberOfRows = numberOfRows;
                var _IsHasCustomAttributeRefSizeSmall = hasCustomAttributeRefSize == 2;
                var _IsCustomAttributeTypeRefSizeSmall = customAttributeTypeRefSize == 2;
                var _IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
                var _ParentOffset = 0;
                var _TypeOffset = _ParentOffset + hasCustomAttributeRefSize;
                var _ValueOffset = _TypeOffset + customAttributeTypeRefSize;
                var RowSize = _ValueOffset + blobHeapRefSize;
                var Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
                int[]? PtrTable = null;

                bool CheckSorted()
                {
                    return Block.IsOrderedByReferenceAscending(RowSize, _ParentOffset, _IsHasCustomAttributeRefSizeSmall);
                }

                if (!declaredSorted && !CheckSorted())
                {
                    PtrTable = Block.BuildPtrTable(numberOfRows, RowSize, _ParentOffset, _IsHasCustomAttributeRefSizeSmall);
                }
                return Block;
            }
        }
    }
}