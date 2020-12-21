//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines formatting specifications for a cell
    /// </summary>
    public readonly struct CellFormatSpec
    {
        public RenderPattern<dynamic> Pattern {get;}

        public ushort LeftPad {get;}

        public ushort RightPad {get;}

        [MethodImpl(Inline)]
        public CellFormatSpec(string pattern, ushort lpad, ushort rpad)
        {
            LeftPad = lpad;
            RightPad = rpad;
            Pattern  = pattern;
        }
    }
}