//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class TextFile<F,C> : Document<F,C,FileLocation>
        where F : TextFile<F,C>, new()
        where C : struct, ITextual
    {

        public TextFile()
            : base(FileLocation.Empty, default(C))
        {

        }

        public TextFile(C content)
            : base(FileLocation.Empty, content)
        {

        }

        public TextFile(FileLocation src, C content)
            : base(src, content)
        {

        }
    }

    public abstract class TextFile<F> : TextFile<F,TextBlock>
        where F : TextFile<F>, new()
    {

        public TextFile()
            : base(FileLocation.Empty, TextBlock.Empty)
        {

        }

        public TextFile(TextBlock content)
            : base(FileLocation.Empty, content)
        {

        }

        public TextFile(FileLocation src, TextBlock content)
            : base(src, content)
        {

        }
    }

    public sealed class TextFile : TextFile<TextFile>
    {
        public TextFile()
            : base(FileLocation.Empty, TextBlock.Empty)
        {

        }

        public TextFile(TextBlock content)
            : base(FileLocation.Empty, content)
        {

        }

        public TextFile(FileLocation src, TextBlock content)
            : base(src, content)
        {

        }

        public override TextFile Load(FileLocation location)
            => new TextFile(location, location.Locator.ReadText());
    }
}