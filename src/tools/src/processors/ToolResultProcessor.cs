//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    class ToolResultProcessor : IToolResultProcessor
    {
        readonly IEnvPaths Paths;

        public FS.FilePath ScriptPath {get;}

        IToolResultHandler CurrentHandler;

        IToolResultHandler DefaultHandler;

        Index<IToolResultHandler> KnownHandlers;

        public ToolResultProcessor(IEnvPaths paths, FS.FilePath script)
        {
            Paths = paths;
            ScriptPath = script;
            DefaultHandler = new DefaultResultHandler(Paths);
            CurrentHandler = DefaultHandler;
            KnownHandlers = sys.alloc<IToolResultHandler>(2);
            KnownHandlers[0] = new MsBuildResultHandler(Paths);
            KnownHandlers[1] = new RobocopyResultHandler(Paths);
        }

        void Switch(IToolResultHandler handler)
        {
            CurrentHandler = handler;
            term.inform($"Beginning {CurrentHandler.Tool} result processing");
        }

        void Revert()
        {
            CurrentHandler = DefaultHandler;
        }

        bool Handle(TextLine src)
            => CurrentHandler.Handle(src);

        public TextLine Process(TextLine src)
        {
            if(!Handle(src))
            {
                Revert();
            }

            foreach(var handler in KnownHandlers)
            {
                if(handler.CanHandle(src))
                {
                    Switch(handler);
                    break;
                }
            }

            return src;
        }
    }
}