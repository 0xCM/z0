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

        const string Success = nameof(Success);

        const string Fail = nameof(Fail);

        public readonly bool Ok;

        public readonly Option<A> Data;

        public readonly Option<B> Error;

        [MethodImpl(Inline)]
        internal Outcome(bool ok, A data, B error)
        {
            Ok = ok;
            if(ok)
            {
                Data = some(data);
                Error = none<B>();
            }
            else
            {
                Data = none<A>();
                Error = some(error);
            }

        }

        [MethodImpl(Inline)]
        public string Format()
            => Ok ? text.format(RenderPatterns.Slot0, Data.Value) : text.format(Error.Value);
    }
}