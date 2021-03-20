//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct JsonDataPacket
    {
        public string ContentType;

        public object Content;

        public JsonDataPacket(object content)
        {
            Content = content ?? "!!empty!!";
            ContentType = (content?.GetType() ?? typeof(string)).FullName;
        }
    }
}