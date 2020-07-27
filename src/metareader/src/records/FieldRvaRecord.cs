//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PartRecords;

    using F = RvaRecordField;

    public enum RvaRecordField : uint
    {   
        Rva = 0 | (16 << WidthOffset),     
        
        Name = 1 | (64 << WidthOffset),
        
        Signature = 2 | (64 << WidthOffset),         
    }

    public struct FieldRvaRecord : IComparable<FieldRvaRecord>
    {
        public static IDatasetFormatter<F> formatter(FieldRvaRecord spec)
            => DatasetFormatter<F>.Default;

        public Address32 Rva;

        public string TypeName;
        
        public string FieldName;
        
        public BinaryCode Signature;
        
        public PartRecordKind Kind 
            => PartRecordKind.FieldRva;

        [MethodImpl(Inline)]
        public FieldRvaRecord(string typeName, string name, BlobRecord sig, Address32 offset)
        {
            Rva = offset;
            TypeName = typeName;
            FieldName = name;
            Signature = sig.Value;
        }            

        public void Format(IDatasetFormatter<F> dst)
        {            
            dst.Delimit(F.Rva, Rva);
            dst.Delimit(F.Name, FieldName);
            dst.Delimit(F.Signature, Signature);
            dst.EmitEol();
        }    

        public int CompareTo(FieldRvaRecord src)    
            => Rva.CompareTo(src.Rva);
    }
}