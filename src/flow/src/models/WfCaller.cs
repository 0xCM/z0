//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum WfCallerField : ushort
    {
        Part,

        Name,

        File,

        FileLine
    }
    
    [Table]
    public readonly struct WfCaller : ITextual, ITable<WfCallerField,WfCaller>
    {        
        public readonly PartId Part;
        
        public readonly string Name;
        
        public readonly string File; 

        public readonly uint FileLine;

        [MethodImpl(Inline)]
        public WfCaller(PartId part, string name, string file, int line)
        {
            Part = part;
            Name = name;
            File = file;
            FileLine = (uint)line;
        }

        [MethodImpl(Inline)]
        public WfCaller(PartId part, string name, string file, uint line)
        {
            Part = part;
            Name = name;
            File = file;
            FileLine = line;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} | {1} | {2} | {3}", Part.Format(), Name, FileLine, File);
    }
}