//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    partial struct ProjectRunner
    {
        public class Message
        {
            public string MessageType {get; set;}

            public JToken Payload {get; set;}

            public override string ToString()
            {
                return "(" + MessageType + ") -> " + ((Payload == null) ? "null" : Payload.ToString(Formatting.Indented));
            }
        }
    }
}