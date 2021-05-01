//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiClasses
    {
        public static string format<K>(K kind)
            where K : IApiKind
                => typeof(K).Name;
    }
}