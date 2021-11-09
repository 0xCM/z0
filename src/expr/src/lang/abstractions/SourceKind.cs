//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class SourceKind<T>
        where T : SourceKind<T>,new()
    {
        public Label Name {get;}

        protected SourceKind(Label name)
        {
            Name = name;
        }
    }

    public sealed class FileSource : SourceKind<FileSource>
    {
        public FileSource()
            : base("files")
        {

        }

    }

    public sealed class RandomSource : SourceKind<RandomSource>
    {
        public RandomSource()
            : base("random")
        {

        }

    }

    public sealed class MemorySource : SourceKind<MemorySource>
    {
        public MemorySource()
            : base("memory")
        {

        }
    }

}