//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.records
{
    /// <summary>
    /// Specifies a reference to an entity defined in an llvm record of specfied kind
    /// </summary>
    public abstract class EntityRef
    {
        public EntityKind Kind {get;}

        public Identifier EntityName {get;}

        public LineNumber SourceLine {get;}

        protected EntityRef(EntityKind kind, Identifier name, LineNumber line)
        {
            EntityName = name;
            SourceLine = line;
            Kind = kind;
        }
    }

    /// <summary>
    /// Specifies a reference to an entity defined in an llvm record of specfied kind
    /// </summary>
    /// <typeparam name="T">The concrete subtype</typeparam>
    public abstract class EntityRef<T> : EntityRef
        where T : EntityRef<T>
    {
        protected EntityRef(EntityKind kind, Identifier name, LineNumber line)
            : base(kind,name,line)
        {
        }
    }
}