//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

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

            log.Title(FlowDirection.Input);
            i=0;
            root.iter(inputs, path => log.Row(i++, FlowDirection.Input, path.ToUri()));

            log.Title(FlowDirection.Output);
            i=0;
            root.iter(outputs, path => log.Row(i++, FlowDirection.Output, path.ToUri()));
        }
    }
}