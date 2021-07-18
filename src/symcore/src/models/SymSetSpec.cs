//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a symbol sequence
    /// </summary>
    public readonly struct SymSeqSpec
    {
        readonly Index<SymSpec> _Specs;

        public Identifier Name {get;}

        public SymSpecKind DefinedParts {get;}

        [MethodImpl(Inline)]
        public SymSeqSpec(SymSpecKind parts, SymSpec[] src)
        {
            _Specs = src;
            DefinedParts = parts;
            Name = _Specs.IsEmpty ? Identifier.Empty : _Specs.First.Kind;
        }

        public Span<SymSpec> Symbols
        {
            [MethodImpl(Inline)]
            get => _Specs.Edit;
        }

        public uint SymbolCount
        {
            [MethodImpl(Inline)]
            get => _Specs.Count;
        }

    }
}