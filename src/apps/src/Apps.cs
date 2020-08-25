//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    public readonly struct Apps
    {
        public static IAppContext context(IResolvedApi composition, IPolyrand random, ISettings settings, IAppMsgQueue queue)
            => new AppContext(composition, random, settings, queue);
    }
}