//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    readonly struct Msg
    {
        public static RenderPattern<Type,Type> ContractMismatch => "The source type {0} does not reify {1}";

        public static RenderPattern<string> SourceLoggerCreated => "Logger for {0} created";

        public static RenderPattern<string> SourceLoggerDisposed => "Logger for {0} disposed";

        public static RenderPattern<string> DispatchingCommand => "Dispatching {0}";

        public static RenderPattern<ToolId> ToolHelpNotFound => "Tool {0} help not found";

        public static RenderPattern<FS.FilePath> NoSuchFile => "The file {0} does not exist";

        public static RenderPattern<Assembly,utf8> NoMatchingResources => "No {0} resources found that match {1}";

        public static RenderPattern<uint,ApiHostUri,uint> IndexedHost => "{2} | {0} | {1} | Api summary accumulation";

        public static RenderPattern<uint> IndexingHosts => "Indexing {0} hosts";

        public static RenderPattern<T> Dispatching<T>()
            where T : struct, ICmdSpec<T> => "Dispatching {0}";

        public static RenderPattern<Assembly,uint> EmittingResources => "Emitting {1} {0} resources";
    }
}