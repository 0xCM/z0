//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a tool invocation script
    /// </summary>
    public struct ToolCmd<T> : IToolCmd<T>
        where T : struct, IToolCmd<T>
    {
        public T CmdSpec {get;}

        public FieldValues<T> FieldValues {get;}

        public ToolCmd(T src, FieldValues<T> values)
        {
            CmdSpec = src;
            FieldValues = values;
        }

        public ToolId ToolId
            => CmdSpec.ToolId;

        [MethodImpl(Inline)]
        public static implicit operator ToolCmd<T>(T src)
            => new ToolCmd<T>(src, Records.values(src, typeof(T).DeclaredInstanceFields()));
    }
}