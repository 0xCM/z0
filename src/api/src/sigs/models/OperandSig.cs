//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        public readonly struct OperandSig
        {
            public Name Name {get;}

            public TypeSig Type {get;}

            public Index<ModifierKind> Modifiers {get;}

            [MethodImpl(Inline)]
            public OperandSig(Name name, TypeSig type, Index<ModifierKind> modifiers)
            {
                Name = name;
                Type = type;
                Modifiers = modifiers;
            }

            public bool IsReturn
            {
                [MethodImpl(Inline)]
                get => Name == ReturnIndicator;
            }

            public bool IsVoid
            {
                [MethodImpl(Inline)]
                get => Type.IsVoid;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }

            public static OperandSig Empty
            {
                [MethodImpl(Inline)]
                get => new OperandSig(Name.Empty, TypeSig.Empty, sys.empty<ModifierKind>());
            }
        }
    }
}