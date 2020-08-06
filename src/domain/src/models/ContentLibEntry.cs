//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class XTend
    {
        public static string Format(this ContentKind src)
            => src.ToString().ToLower();

        public static string Format(this StructureKind src)
            => src.ToString().ToLower();
    }
    
    public enum ContentLibField : ushort
    {
        Kind = 20,
        
        Structure = 20,

        Size = 16,
        
        Name = 80,
    }
    
    public readonly struct ContentLibEntry
    {   
        [MethodImpl(Inline)]
        public ContentLibEntry(ContentKind kind, StructureKind structure, uint count, string name)
        {
            Kind = kind;
            Structure = structure;
            Size = count;
            Name = name;
        }
        
        public readonly ContentKind Kind;        
                
        public readonly StructureKind Structure;
        
        public readonly uint Size;        
        
        public readonly string Name;       

        bool IsStructured => Structure != 0;
        
        const string Unstructured = nameof(Unstructured);

        const string Structured = nameof(Structured);

        string Form 
            => IsStructured ? Structured.PadRight(12) : Unstructured.PadRight(12);
        
        public string Format()
            => $"{Form} | {Kind.Format().PadRight(12)} | {Size.ToString().PadRight(8)} | {Name.PadRight(60)}";
    }
}