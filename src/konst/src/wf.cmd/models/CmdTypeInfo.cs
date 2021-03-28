//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [Datatype]
    public readonly struct CmdTypeInfo : ICmdTypeInfo, IDataType<CmdTypeInfo>
    {
        public CmdId CmdId {get;}

        public Type DataType {get;}

        public Index<FieldInfo> Fields {get;}

        [MethodImpl(Inline)]
        public CmdTypeInfo(Type type, FieldInfo[] fields)
        {
            CmdId = CmdId.from(type);
            DataType = type;
            Fields = fields;
        }

        public uint FieldCount
        {
            [MethodImpl(Inline)]
            get => Fields.Count;
        }

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();
    }
}