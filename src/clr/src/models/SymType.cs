//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SymType
    {
        readonly public Type Definition;

        readonly Index<string> _Alias;

        public string Group {get;}

        [MethodImpl(Inline)]
        internal SymType(Type def, string group, string[] alias)
        {
            Definition = def;
            Group = group;
            _Alias = alias;
        }

        [MethodImpl(Inline)]
        internal SymType(Type def,string group)
        {
            Definition = def;
            Group = group;
            _Alias = sys.empty<string>();
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        public ReadOnlySpan<string> Alias
        {
            [MethodImpl(Inline)]
            get => _Alias.View;
        }
    }
}