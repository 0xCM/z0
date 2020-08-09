//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;
    using static z;

    public static partial class XTend
    {
        public static string Format(this ContentKind src)
            => src.ToString().ToLower();

        public static string Format(this StructureKind src)
            => src.ToString().ToLower();
    }
    
    public enum ContentLibField : ushort
    {
        Name = 80,

        Type = 20,
                
    }
    
    public readonly struct ContentLibEntry : ITable<ContentLibField, ContentLibEntry>
    {   
        public readonly string Type;        

        public readonly string Name;                       

        [MethodImpl(Inline)]
        public ContentLibEntry(string name, string type)
        {
            Name = name;
            Type = type;
        }
                    
        public string Format()
            => text.format("{0,-16} | {1}", Type, Name);
    }
}