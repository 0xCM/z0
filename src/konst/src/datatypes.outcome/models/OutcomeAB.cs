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

    /// <summary>
    /// Describes an operation result
    /// </summary>
    public readonly struct Outcome<A,B> : ITextual
    {
        const string  FormatPattern = "{0}: {1}";

        public bool Ok {get;}

        public Option<A> Data {get;}

        public Option<B> Message {get;}

        [MethodImpl(Inline)]
        public Outcome(bool ok, A data, B error)
        {
            Ok = ok;
            if(ok)
            {
                Data = some(data);
                Message = none<B>();
            }
            else
            {
                Data = none<A>();
                Message = some(error);
            }
        }

        [MethodImpl(Inline)]
        public string Format()
            => Ok ? text.format(RP.Slot0, Data.Value) : text.format(Message.Value);
    }
}