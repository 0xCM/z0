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

    public readonly struct CmdDescriptor : ICmdDescriptor
    {
        public CmdId CmdId {get;}

        public Type DataType {get;}

        public IndexedView<FieldInfo> Fields {get;}

        [MethodImpl(Inline)]
        public CmdDescriptor(Type type, FieldInfo[] fields)
        {
            CmdId = Cmd.id(type);
            DataType = type;
            Fields = fields;
        }

        public uint FieldCount
        {
            [MethodImpl(Inline)]
            get => Fields.Count;
        }
    }
}