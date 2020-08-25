//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SemanticArchive : ISemanticArchive<SemanticArchive>
    {
        public static ISemanticArchive create()
            => default(SemanticArchive);
    }
}