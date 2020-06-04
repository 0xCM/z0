//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class MetadataTypes
    {
        const string Delimiter = " | ";

        public readonly struct Constant : ITextual
        {
            public string Parent {get;}

            public string Type {get;}

            public BlobValue Value {get;}

            [MethodImpl(Inline)]
            internal Constant(string Parent, string Type, BlobValue Value)
            {
                this.Parent = Parent;
                this.Type = Type;
                this.Value = Value;
            }            

            public string Format()
            {
                var dst = text.build();
                dst.Append(Parent.PadRight(20));
                dst.Append(Delimiter);
                dst.Append(Type.PadRight(20));
                dst.Append(Delimiter);
                dst.Append(Value.Format());

                return dst.ToString();
            }
        }

        public readonly struct LiteralValue : ITextual
        {

            public int Offset {get;}
            
            public string Value {get;}

            public LiteralValue(int Offset, string Value)
            {
                this.Offset = Offset;
                this.Value = Value;
            }
            
            public string Format()
            {
                var dst = text.build();
                dst.Append(Offset.FormatHex(zpad:false, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Value);

                return dst.ToString();
            }
        }

        public readonly struct StringValue : ITextual
        {
            public int HeapSize {get;}

            public int Length {get;}

            public int Offset {get;}

            public string Value {get;}

            public StringValue(int HeapSize, int Offset, string Value)
            {
                this.HeapSize = HeapSize;
                this.Length = Value.Length;
                this.Offset = Offset;
                this.Value = Value;
            }
            
            public string Format()
            {
                var dst = text.build();
                dst.Append(HeapSize.FormatHex(zpad:true, specifier:true, prespec:false).PadRight(8));
                dst.Append(Delimiter);
                dst.Append(Length.ToString().PadRight(5));
                dst.Append(Delimiter);
                dst.Append(Offset.FormatHex(zpad:true, specifier:true, prespec:false).PadRight(8));
                dst.Append(Delimiter);
                dst.Append(Value);
                return dst.ToString();
            }
        }

        public readonly struct BlobValue : ITextual
        {
            public int HeapSize {get;}

            public int Offset {get;}
            
            public byte[] Value {get;}

            public BlobValue(int HeapSize, int Offset, byte[] Value)
            {
                this.HeapSize = HeapSize;
                this.Offset = Offset;
                this.Value = Value;
            }

            public string Format()
            {
                var dst = text.build();
                dst.Append(HeapSize.FormatHex(zpad:false, specifier:false).PadRight(8));
                dst.Append(Delimiter);
                dst.Append(Offset.FormatHex(zpad:false, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Value.FormatHexBytes());

                return dst.ToString();
            }
        }
        
        public readonly struct Field : ITextual
        {
            public int Rva {get;}

            public int Offset {get;}

            public LiteralValue Name {get;}

            public BlobValue Signature {get;}

            public string Attributes {get;}

            public string Marshalling {get;}

            [MethodImpl(Inline)]
            internal Field(int Rva, int Offset, LiteralValue Name, BlobValue Signature, string Attributes, string Marshalling)
            {
                this.Rva = Rva == -1 ? 0 : Rva;
                this.Offset = Offset == -1 ? 0 : Offset;
                this.Name = Name;
                this.Signature = Signature;
                this.Attributes = Attributes;
                this.Marshalling = Marshalling;
            }            
            
            public string Format()
            {
                var dst = text.build();
                dst.Append(Rva.FormatHex(zpad:true, specifier:false).PadRight(14));
                dst.Append(Delimiter);
                dst.Append(Offset.FormatHex(zpad:false, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Name.Format().PadRight(40));
                dst.Append(Delimiter);
                dst.Append(Signature.Format());
                dst.Append(Delimiter);
                dst.Append(Marshalling.PadRight(20));
                return dst.ToString();
            }
        }        
        
        public readonly struct ManifestResource : ITextual
        {
            public long Offset {get;}

            public string Name {get;}

            public string Attribute {get;}

            public string Implementation {get;}

            [MethodImpl(Inline)]
            internal ManifestResource(string Name, string Attribute, long Offset, string Implementation)
            {
                this.Name = Name;
                this.Attribute = Attribute;
                this.Offset = Offset;
                this.Implementation = Implementation;
            }            
            public string Format()
            {
                var dst = text.build();
                dst.Append(Offset.FormatHex(zpad:true, specifier:false).PadRight(6));
                dst.Append(Delimiter);
                dst.Append(Name.PadRight(20));
                dst.Append(Delimiter);
                dst.Append(Attribute.PadRight(20));
                dst.Append(Delimiter);
                dst.Append(Implementation.PadRight(20));
                return dst.ToString();
            }        
        }                    
    }
}