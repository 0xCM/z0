//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    [ApiHost]
    public readonly partial struct Render
    {
        public const MessageFlair Error = MessageFlair.Red;

        public const MessageFlair Created = MessageFlair.Gray;

        public const MessageFlair Running = MessageFlair.Magenta;

        public const MessageFlair Ran = MessageFlair.Cyan;

        public const MessageFlair Finished = MessageFlair.Gray;

        public const MessageFlair Status = MessageFlair.Green;

        public const MessageFlair Initializing = MessageFlair.Gray;

        public const MessageFlair Initialized = MessageFlair.Gray;                
    }
}