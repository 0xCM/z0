//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    class MsBuildResultHandler : IToolResultHandler
    {
        readonly IDbPaths Paths;

        public ToolId Tool => Toolsets.msbuild;

        void Status(TextLine src)
            => term.babble(src);

        void Found(string marker)
            => term.inform(marker);

        public MsBuildResultHandler(IDbPaths paths)
        {
            Paths = paths;
        }

        public bool Handle(TextLine src)
        {
            var content = src.Content;
            var @continue = true;

            if(content.Contains(BuildSucceededMarker))
            {
                Found(nameof(BuildSucceededMarker));
                Status(src);
                @continue = false;
            }
            else
            {
                Status(src);
            }

            return @continue;

        }

        public bool CanHandle(TextLine src)
            => src.Content.Contains(Logo);

        const string BuildSucceededMarker = "Build Succeeded";

        const string Logo = "Microsoft (R) Build Engine";
    }
}