//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class EbnfInstance : Grammar<EbnfInstance,AsciCharSym,EbnfRule>
    {
        public EbnfInstance(Label name)
            : base(name, lang.alphabet<AsciCharSym>())
        {

        }
    }
}