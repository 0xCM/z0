//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        public void ShowFiles()
        {
            var @case = "bswap";

            using var log = ShowLog(Id.Format() + "." + "files", FS.Log);

            var i=0;

            log.Property(nameof(InDir), InDir);
            log.Property(nameof(OutDir), OutDir);

            var inputs = Inputs();
            var outputs = Outputs();
            var listings = Listings();

            log.Title(NasmFileKind.Input);
            i=0;
            root.iter(inputs, path => log.Row(i++, NasmFileKind.Input, path.ToUri()));

            log.Title(NasmFileKind.Output);
            i=0;
            root.iter(outputs, path => log.Row(i++, NasmFileKind.Output, path.ToUri()));
        }
    }
}