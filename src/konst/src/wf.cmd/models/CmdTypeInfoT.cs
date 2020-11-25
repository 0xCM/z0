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

    public readonly struct CmdTypeInfo<T> : ICmdTypeInfo<CmdTypeInfo<T>,T>
        where T : struct, ICmdSpec<T>
    {
        public CmdId CmdId => Cmd.id<T>();

        public Type DataType => typeof(T);

        public IndexedView<FieldInfo> Fields
        {
            [MethodImpl(Inline)]
            get => DataType.DeclaredInstanceFields();
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdTypeInfo(CmdTypeInfo<T> src)
            => new CmdTypeInfo(src.DataType, src.Fields);
    }
}