//-----------------------------------------------------------------------------
// Copyright   :  Microsoft
// License     : MIT via .Net Foundation
// Extracted from System.Reflection.MetadataReader library code
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;


    internal readonly struct FieldRVATableReader
    {
        internal readonly int NumberOfRows;
        
        readonly bool _IsFieldTableRowRefSizeSmall;
        
        readonly int _RvaOffset;
        
        readonly int _FieldOffset;
        
        internal readonly int RowSize;
        
        internal readonly MemoryBlock Block;

        internal FieldRVATableReader(
            int numberOfRows,
            bool declaredSorted,
            int fieldTableRowRefSize,
            MemoryBlock containingBlock,
            int containingBlockOffset)
        {
            this.NumberOfRows = numberOfRows;
            _IsFieldTableRowRefSizeSmall = fieldTableRowRefSize == 2;
            _RvaOffset = 0;
            _FieldOffset = _RvaOffset + sizeof(uint);
            this.RowSize = _FieldOffset + fieldTableRowRefSize;
            this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);

            if (!declaredSorted && !CheckSorted())
                Control.@throw($"Table not sorted: {TableIndex.FieldRva}");
        }

        internal int GetRva(int rowId)
        {
            int rowOffset = (rowId - 1) * this.RowSize;
            return Block.PeekInt32(rowOffset + _RvaOffset);
        }

        internal int FindFieldRvaRowId(int fieldDefRowId)
        {
            int foundRowNumber = Block.BinarySearchReference(
                this.NumberOfRows,
                this.RowSize,
                _FieldOffset,
                (uint)fieldDefRowId,
                _IsFieldTableRowRefSizeSmall);

            return foundRowNumber + 1;
        }

        private bool CheckSorted()
        {
            return this.Block.IsOrderedByReferenceAscending(this.RowSize, _FieldOffset, _IsFieldTableRowRefSizeSmall);
        }
    }
}