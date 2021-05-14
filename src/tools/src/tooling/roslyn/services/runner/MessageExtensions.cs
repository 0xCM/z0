//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ProjectRunner;

    static class MessageExtensions
    {
        public static T DeserializePayload<T>(this Message message)
            => JsonDataSerializer.Instance.DeserializePayload<T>(message);
    }
}