//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class PromptInputParser<C>
        where C : ProcessCommand<C>, new()
    {
        readonly PromptInputSyntax syntax;

        public PromptInputParser()
        {
            syntax = (PromptInputSyntax)typeof(C).GetField(nameof(syntax)).GetValue(null);
        }

        public C Parse(string input)
            => (C)Activator.CreateInstance(typeof(C), input);
    }
}