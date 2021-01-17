//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;


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

    public readonly struct LispDocs
    {
        const string TestCase = @"J:\lang\lisp\acl2\books\projects\x86isa\machine\linear-memory.lisp";

        public static LispDoc load(FS.FilePath src)
            => LispDoc.load(src);
    }
}