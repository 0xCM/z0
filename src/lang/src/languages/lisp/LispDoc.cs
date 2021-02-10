//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public sealed class LispDoc : Document<LispDoc,TextBlock,FS.FilePath>
    {
        public LispDoc()
            : base(FS.FilePath.Empty, TextBlock.Empty)
        {

        }

        public LispDoc(TextBlock content)
            : base(FS.FilePath.Empty, content)
        {

        }

        public LispDoc(FS.FilePath src, TextBlock content)
            : base(src, content)
        {

        }

        public override LispDoc Load(FS.FilePath location)
            => new LispDoc(location, location.ReadText());
    }
}