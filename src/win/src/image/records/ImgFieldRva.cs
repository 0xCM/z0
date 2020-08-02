//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImgRvaField : uint
    {   
        Rva = 0 | (16 << WidthOffset),     
        
        Name = 1 | (64 << WidthOffset),
        
        Signature = 2 | (64 << WidthOffset),         
    }

    public struct ImgFieldRva : IComparable<ImgFieldRva>
    {
        public Address32 Rva;

        public string TypeName;
        
        public string FieldName;
        
        public BinaryCode Signature;
        
        [MethodImpl(Inline)]
        public ImgFieldRva(string typeName, string name, ImgBlobRecord sig, Address32 offset)
        {
            Rva = offset;
            TypeName = typeName;
            FieldName = name;
            Signature = sig.Value;
        }            

        public int CompareTo(ImgFieldRva src)    
            => Rva.CompareTo(src.Rva);
    }
}