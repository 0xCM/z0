//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost("numeric.kinds")]
    public partial class NumericKinds
    {
        public static NK<T> from<T>()
            where T : unmanaged
                => default;
    }
}