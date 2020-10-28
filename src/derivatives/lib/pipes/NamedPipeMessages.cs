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

    /// <summary>
    /// Define messages used to communicate via the named-pipe in Scalar.
    /// </summary>
    public static class NamedPipeMessages
    {
        public const string UnknownRequest = "UnknownRequest";

        public const string ResponseSuffix = "Response";

        public const char MessageSeparator = '|';

        public enum CompletionState
        {
            NotCompleted,

            Success,

            Failure
        }

        public class BaseResponse<TRequest>
        {
            public const string Header = nameof(TRequest) + ResponseSuffix;

            public CompletionState State { get; set; }

            public string ErrorMessage { get; set; }

            public PipeMessage ToMessage()
            {
                return new PipeMessage(Header, JsonConvert.SerializeObject(this));
            }
        }
    }
}