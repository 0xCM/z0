//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct ClaimResult<A>
    {
        public Name Identifier;

        public readonly ClaimOperator Claim;

        public OutputValue<A> Arg0;

        public bit Success;

        public TextBlock Message;

        [MethodImpl(Inline)]
        public ClaimResult(string identifier, ClaimKind claim, bool success, string message, A a)
        {
            Identifier = identifier;
            Claim = claim;
            Arg0 = a;
            Success = success;
            Message = message;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Identifier, Claim, Success, Message, Arg0);

        public override string ToString()
            => Format();
    }
}