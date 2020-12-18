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
    /// Defines a script variable
    /// </summary>
    public struct CmdScriptVar : ICmdVar
    {
        /// <summary>
        /// The variable symbol
        /// </summary>
        public CmdVarSymbol Symbol {get;}

        /// <summary>
        /// The variable value, possibly empty
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdScriptVar(CmdVarSymbol name, string value)
        {
            Symbol = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public CmdScriptVar(CmdVarSymbol name)
        {
            Symbol = name;
            Value = EmptyString;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdScriptVar((CmdVarSymbol symbol, string value) src)
            => new CmdScriptVar(src.symbol, src.value);
    }
}