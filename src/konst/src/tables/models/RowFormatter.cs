//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    using api = Table;

    public struct RowFormatter
    {

        readonly StringBuilder Target;

        public string Format()
            => Target.ToString();

        public override string ToString()
            => Format();
    }
}