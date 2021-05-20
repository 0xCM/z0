//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    [Datatype]
    public readonly struct CmdTypeInfo<T> : ICmdTypeInfo<CmdTypeInfo<T>,T>
        where T : struct, ICmd<T>
    {
        public CmdId CmdId => CmdId.from<T>();

        public Type DataType => typeof(T);

        public string Format()
            => CmdId.Format();

        public override string ToString()
            => Format();

        public Index<FieldInfo> Fields
        {
            [MethodImpl(Inline)]
            get => DataType.DeclaredInstanceFields();
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdTypeInfo(CmdTypeInfo<T> src)
            => new CmdTypeInfo(src.DataType, src.Fields);
    }
}