//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct TocEntry
        {
            public string Title;

            public Location Target;

            public Placeholder Placeholder;

            [MethodImpl(Inline)]
            public TocEntry(string title, Location dst, Placeholder ph)
            {
                Title = title;
                Target = dst;
                Placeholder = ph;
            }
        }
    }
}