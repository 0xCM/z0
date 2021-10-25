//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.records
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum EntityKind
    {
        None,

        Def,

        Class
    }

    public readonly struct EntityRefs
    {
        public static EntityRef def(Identifier name, LineNumber line)
            => new DefRef(name,line);

        public static EntityRef @class(Identifier name, LineNumber line)
            => new ClassRef(name,line);
    }

    /// <summary>
    /// Defines a reference to a definition
    /// </summary>
    public sealed class DefRef : EntityRef<DefRef>
    {
        public Identifier Name;

        public LineNumber RecordLine;

        [MethodImpl(Inline)]
        public DefRef(Identifier name, LineNumber line)
            : base(EntityKind.Def, name, line)
        {
            Name = name;
            RecordLine = line;
        }
    }

    /// <summary>
    /// Defines a reference to a definition
    /// </summary>
    public sealed class ClassRef : EntityRef<ClassRef>
    {
        public Identifier Name;

        public LineNumber RecordLine;

        [MethodImpl(Inline)]
        public ClassRef(Identifier name, LineNumber line)
            : base(EntityKind.Class, name, line)
        {
            Name = name;
            RecordLine = line;
        }
    }
}