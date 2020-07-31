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

    public readonly struct ContentInfo
    {   
        [MethodImpl(Inline)]
        public ContentInfo(ContentKind kind, uint count, string name, bool structured)
        {
            Kind = kind;
            Size = count;
            Name = name;
            IsStructured = structured;
        }
        
        public readonly ContentKind Kind;        
                
        public readonly uint Size;        
        
        public readonly string Name;       

        public readonly bool IsStructured;
        
        const string Unstructured = nameof(Unstructured);

        const string Structured = nameof(Structured);

        string Form 
            => IsStructured ? Structured.PadRight(12) : Unstructured.PadRight(12);
        
        public string Format()
            => $"{Form} | {Kind.Format().PadRight(12)} | {Size.ToString().PadRight(8)} | {Name.PadRight(60)}";
    }
}