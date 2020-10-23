//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct ClaimResult<A0,A1,A2>
    {
        public utf8 Identifier;

        public readonly ClaimOperator Claim;

        public OutputValue<A0> Arg0;

        public OutputValue<A1> Arg1;

        public OutputValue<A2> Arg2;

        public bit Success;

        public utf8 Message;

        [MethodImpl(Inline)]
        public ClaimResult(string identifier, ClaimKind claim, bool success, string message, A0 a0, A1 a1, A2 a2)
        {
            Identifier = identifier;
            Claim = claim;
            Arg0 = a0;
            Arg1 = a1;
            Arg2 = a2;
            Success = success;
            Message = message;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Identifier, Claim, Success, Message, Arg0, Arg1, Arg2);

        public override string ToString()
            => Format();
    }
}