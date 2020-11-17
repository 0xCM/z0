//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Scripts;

    /// <summary>
    /// Defines a script variable
    /// </summary>
    public struct ScriptVar : IScriptVar
    {
        /// <summary>
        /// The variable symbol
        /// </summary>
        public ScriptSymbol Symbol {get;}

        /// <summary>
        /// The variable value, possibly empty
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public ScriptVar(ScriptSymbol name, string value)
        {
            Symbol = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public ScriptVar(ScriptSymbol name)
        {
            Symbol = name;
            Value = EmptyString;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ScriptVar((ScriptSymbol symbol, string value) src)
            => new ScriptVar(src.symbol, src.value);
    }
}