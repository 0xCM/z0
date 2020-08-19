//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableSpec
    {
        public readonly string Namespace;

        public readonly string TypeName;

        public readonly TableFieldSpec[] Fields;

        [MethodImpl(Inline)]
        public TableSpec(string ns, string name, params TableFieldSpec[] fields)
        {
            Namespace = ns;
            TypeName = name;
            Fields = fields;
        }
    }
}