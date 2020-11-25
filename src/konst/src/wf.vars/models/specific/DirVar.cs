//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct CmdVarTypes
    {
        public struct DirVar : ICmdVar<FS.FolderPath>
        {
            public CmdVarSymbol Symbol {get;}

            public FS.FolderPath Value {get;}

            [MethodImpl(Inline)]
            public DirVar(CmdVarSymbol name, FS.FolderPath value)
            {
                Symbol = name;
                Value = value;
            }

            [MethodImpl(Inline)]
            public DirVar(CmdVarSymbol name)
            {
                Symbol = name;
                Value = FS.FolderPath.Empty;
            }

            [MethodImpl(Inline)]
            public static implicit operator DirVar((CmdVarSymbol symbol, FS.FolderPath value) src)
                => new DirVar(src.symbol, src.value);

            [MethodImpl(Inline)]
            public static implicit operator CmdScriptVar(DirVar src)
                => new DirVar(src.Symbol, src.Value);
        }
    }
}