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

    public readonly struct CmdDescriptor<T> : ICmdDescriptor<CmdDescriptor<T>,T>
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
        public static implicit operator CmdDescriptor(CmdDescriptor<T> src)
            => new CmdDescriptor(src.DataType, src.Fields);
    }
}