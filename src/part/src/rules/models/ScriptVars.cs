//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public struct ScriptVars : IScriptVars<ScriptVars>
    {
        readonly Index<ScriptVar> Data;

        [MethodImpl(Inline)]
        internal ScriptVars(ScriptVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Index<IScriptVar> Members()
            => Data.Cast<IScriptVar>();

        public string Format()
        {
            var dst = text.build();
            foreach(var member in Data)
                dst.AppendLine(member.Format());
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}