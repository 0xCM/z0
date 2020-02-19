//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class CSharpSource : SourceCode<CSharpSource>
    {
        public CSharpSource()
            : base(string.Empty)
        {}

        public CSharpSource(string Text)
            : base(Text)
        {

        }

        public const string FileHeader = 
@"//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------";
    }
}