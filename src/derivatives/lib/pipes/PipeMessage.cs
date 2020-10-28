//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Pipes
{
    public class PipeMessage
    {
        public static PipeMessage from(string message)
        {
            string header = null;
            string body = null;
            if (!string.IsNullOrEmpty(message))
            {
                string[] parts = message.Split(new[] { NamedPipeMessages.MessageSeparator }, count: 2);
                header = parts[0];
                if (parts.Length > 1)
                    body = parts[1];
            }

            return new PipeMessage(header, body);
        }

        public string Header {get;}

        public string Body {get;}

        public PipeMessage(string header, string body)
        {
            Header = header;
            Body = body;
        }


        public override string ToString()
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(Header))
                result = Header;

            if (Body != null)
                result = result + NamedPipeMessages.MessageSeparator + Body;

            return result;
        }
    }
}