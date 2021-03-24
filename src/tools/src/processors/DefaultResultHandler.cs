//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    class DefaultResultHandler : IToolResultHandler
    {
        readonly IEnvPaths Paths;

        public ToolId Tool => default;

        void Status(TextLine src)
            => term.babble(src);

        public DefaultResultHandler(IEnvPaths paths)
        {
            Paths = paths;
        }

        public bool Handle(TextLine src)
        {
            Status(src);
            return true;
        }

        public bool CanHandle(TextLine src)
            => true;
    }
}