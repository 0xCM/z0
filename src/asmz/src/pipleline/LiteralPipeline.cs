//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public readonly struct SymbolicLiteral
    {
        public string Class {get;}

        public string Category {get;}

        public string Prefix {get;}

        public string Name {get;}

        public string Meaning {get;}

        public SymbolicLiteral(string @class, string category, string prefix, string label, string meaning)
        {
            Class = @class;
            Category = category;
            Prefix = prefix;
            Name = label;
            Meaning = meaning;
        }
    }

    public interface ILiteralPipe
    {
        Index<LiteralInfo> Flow(ILiteralSource src, ILiteralTarget dst);
    }

    public interface ILiteralSource
    {
        FS.FilePath Location {get;}
    }

    public interface ILiteralTarget
    {
        FS.FilePath Location {get;}
    }

    public readonly struct LiteralSource : ILiteralSource
    {
        public FS.FilePath Location {get;}

        public LiteralSource(FS.FilePath path)
        {
            Location = path;
        }
    }

    public readonly struct LiteralTarget : ILiteralTarget
    {
        public FS.FilePath Location {get;}

        public LiteralTarget(FS.FilePath path)
        {
            Location = path;
        }
    }
}
