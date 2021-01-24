//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public sealed class LispDoc : Document<LispDoc,TextBlock,FileLocation>
    {
        public LispDoc()
            : base(FileLocation.Empty, TextBlock.Empty)
        {

        }

        public LispDoc(TextBlock content)
            : base(FileLocation.Empty, content)
        {

        }

        public LispDoc(FileLocation src, TextBlock content)
            : base(src, content)
        {

        }

        public override LispDoc Load(FileLocation location)
            => new LispDoc(location, location.Locator.ReadText());
    }
}