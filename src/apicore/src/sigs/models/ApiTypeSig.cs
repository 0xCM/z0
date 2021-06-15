//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class ApiTypeSig : ITextual
    {
        public Name TypeName {get;}

        public Index<ApiSigMod> Modifiers {get;}

        public Index<ISigTypeParam> Parameters {get;}

        [MethodImpl(Inline)]
        public ApiTypeSig(Name name, params ISigTypeParam[] parameters)
        {
            Modifiers = Index<ApiSigMod>.Empty;
            TypeName = name;
            Parameters = parameters;
        }

        [MethodImpl(Inline)]
        public ApiTypeSig(Name name, ApiSigMod mod, params ISigTypeParam[] parameters)
        {
            Modifiers = core.array(mod);
            TypeName = name;
            Parameters = parameters;
        }

        [MethodImpl(Inline)]
        public ApiTypeSig(Name name, Index<ApiSigMod> modifiers, params ISigTypeParam[] parameters)
        {
            Modifiers = modifiers;
            TypeName = name;
            Parameters = parameters;
        }

        public uint ParameterCount
        {
            [MethodImpl(Inline)]
            get => Parameters.Count;
        }

        public bool IsParametric
        {
            [MethodImpl(Inline)]
            get => ParameterCount != 0;
        }

        public bool IsVoid
        {
            [MethodImpl(Inline)]
            get => TypeName == "void";
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => TypeName.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => TypeName.IsNonEmpty;
        }

        public string Format()
            => ApiSigRender.format(this);

        public override string ToString()
            => Format();

        public static ApiTypeSig Empty
        {
            [MethodImpl(Inline)]
            get => new ApiTypeSig(EmptyString);
        }
    }
}