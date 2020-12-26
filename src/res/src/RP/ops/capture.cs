//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RP
    {
        [MethodImpl(Inline)]
        public static RenderCapture capture<T>(T src, params object[] args)
            where T : IRenderPattern
                => new RenderCapture(src, args);
   }
}
