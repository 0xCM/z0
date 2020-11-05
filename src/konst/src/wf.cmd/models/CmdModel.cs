//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct CmdModel : ICmdModel
    {
        public Type DataType {get;}

        public IndexedView<FieldInfo> Fields {get;}

        [MethodImpl(Inline)]
        public CmdModel(Type type, FieldInfo[] fields)
        {
            DataType = type;
            Fields = fields;
        }
    }
}