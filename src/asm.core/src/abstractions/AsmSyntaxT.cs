//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public abstract class AsmSyntax<T> : IAsmSyntax
        where T : AsmSyntax<T>, new()
    {
        public static T create() => new T();

        public abstract AsmSyntaxKind Kind {get;}
    }
}