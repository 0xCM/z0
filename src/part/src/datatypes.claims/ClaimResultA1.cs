//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ClaimResult<A0,A1>
    {
        public Name Identifier;

        public readonly ClaimOperator Claim;

        public OutputValue<A0> Arg0;

        public OutputValue<A1> Arg1;

        public bit Success;

        public TextBlock Message;

        [MethodImpl(Inline)]
        public ClaimResult(string identifier, ClaimKind claim, bool success, string message, A0 a, A1 b)
        {
            Identifier = identifier;
            Claim = claim;
            Success = success;
            Message = message;
            Arg0 = a;
            Arg1 = b;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Identifier, Claim, Success, Message, Arg0, Arg1);

        public override string ToString()
            => Format();
    }
}