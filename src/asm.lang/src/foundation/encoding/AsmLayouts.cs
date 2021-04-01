//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static LayoutComponents;

    [ApiHost]
    public readonly struct AsmLayouts
    {
        [MethodImpl(Inline), Op]
        public static AsmLayout empty()
        {
            var layout = default(AsmLayout);
            layout.Prefixes = Array.Empty<Prefix>();
            return layout;
        }

        public static void render(in AsmLayout src, ITextBuffer dst)
        {

        }
    }
}
