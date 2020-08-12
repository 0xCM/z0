//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    using Z0.MS;

    public readonly struct FieldModel
    {
        public FieldModel(ClrElementType type, FieldData data)
        {
            ElementType = type;
            Data = data;
        }
        
        public readonly ClrElementType ElementType;        
        
        public readonly FieldData Data;

        public uint Token 
            =>  Data.FieldToken;

        public uint Offset 
            => Data.Offset;

        public ulong TypeMethodTable 
            => Data.TypeMethodTable;

        public ulong NextField 
            => Data.NextField;

        public bool IsContextLocal 
            => Data.IsContextLocal != 0;
        
        public bool IsStatic 
            => Data.IsStatic != 0;
        
        public bool IsThreadLocal 
            => Data.IsThreadLocal != 0;
    }
}