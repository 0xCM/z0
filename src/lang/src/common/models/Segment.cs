//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Segment
    {
        public IDataSource Source {get;}

        public Range Selection {get;}

        [MethodImpl(Inline)]
        public Segment(IDataSource source, Range selection)
        {
            Source = source;
            Selection = selection;
        }
    }
}