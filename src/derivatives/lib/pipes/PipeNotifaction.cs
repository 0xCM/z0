//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Pipes
{
    using Newtonsoft.Json;

    public static class PipeNotification
    {
        public class Request
        {
            public const string Header = nameof(PipeNotification);

            public uint Id { get; set; }

            public string Title { get; set; }

            public string Message { get; set; }

            public string NewVersion { get; set; }

            public static Request FromMessage(PipeMessage message)
                => JsonConvert.DeserializeObject<Request>(message.Body);

            public PipeMessage ToMessage()
                => new PipeMessage(Header, JsonConvert.SerializeObject(this));
        }
    }
}