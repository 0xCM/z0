//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    readonly struct Msg
    {
        public static RenderPattern<Type,Type> ContractMismatch => "The source type {0} does not reify {1}";

        public static RenderPattern<string> SourceLoggerCreated => "Logger for {0} created";

        public static RenderPattern<string> SourceLoggerDisposed => "Logger for {0} disposed";

        public static RenderPattern<CmdId> DispatchingCommand => "Dispatching {0}";

        public static RenderPattern<ToolId> ToolHelpNotFound => "Tool {0} help not found";

        public static RenderPattern<FS.FilePath> FileDoesNotExist => "The file {0} does not exist";
    }
}