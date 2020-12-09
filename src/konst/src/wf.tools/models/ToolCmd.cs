//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a tool invocation script
    /// </summary>
    public struct ToolCmd<T> : IToolCmd<T>
        where T : struct, IToolCmd<T>
    {
        public T CmdSpec {get;}

        public RecordFieldValues<T> FieldValues {get;}

        public ToolCmd(T src, RecordFieldValues<T> values)
        {
            CmdSpec = src;
            FieldValues = values;
        }

        public ToolId ToolId
            => CmdSpec.ToolId;

        [MethodImpl(Inline)]
        public static implicit operator ToolCmd<T>(T src)
            => Tooling.cmd(src);
    }
}