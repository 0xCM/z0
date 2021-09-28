//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    public class Generators : AppService<Generators>
    {
        public StringTableGen StringTable()
            => StringTableGen.create(Wf);

        public StringLiteralEmitter StringLiterals()
            => Z0.StringLiteralEmitter.create(Wf);

        public EnumGen CsEnum()
            => new EnumGen();
    }
}