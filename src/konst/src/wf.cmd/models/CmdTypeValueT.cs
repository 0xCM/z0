//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a tool invocation script
    /// </summary>
    public struct CmdTypeValue<T> : IToolCmd<T>
        where T : struct, IToolCmd<T>
    {
        public T CmdSpec {get;}

        public RecordFields Fields {get;}

        public RecordFieldValues<T> FieldValues {get;}

        public CmdTypeValue(T src)
        {
            CmdSpec = src;
            Fields = Records.fields<T>();
            FieldValues = Records.values(CmdSpec, Fields);
        }

        public ToolId ToolId
            => CmdSpec.ToolId;

        [MethodImpl(Inline)]
        public static implicit operator CmdTypeValue<T>(T src)
            => new CmdTypeValue<T>(src);
    }
}