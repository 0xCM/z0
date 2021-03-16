//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct CheckProvider
    {
        public static CheckProvider create()
            => new CheckProvider();

        public IChecks Checks => new Checks();

        public ICheckClose CheckClose => new CheckClose();

        public ICheckNumeric CheckNumeric => new NumericClaims();

        public ICheckEquatable CheckEquatable => new CheckEquatable();

        public ICheckInvariant CheckInvariant => new CheckInvariant();

        public ICheckPrimal CheckPrimal => new CheckPrimal();

        public ICheckPrimalSeq CheckPrimalSeq => new CheckPrimalSeq();

        public ICheckSpans CheckSpans => new CheckSpans();
    }
}