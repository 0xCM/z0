//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static z;

    using P = Z0.Parts;
        
    class App : AppShell<App,IAppContext>
    {                        
        public CorrelationToken Ct;

        public App()
            : base(WfBuilder.app())
        {
            Ct = CorrelationToken.define(PartId.Machine);
        }
        
        void ReadRes()
        {
            var map = MemoryFile.resbytes();
            var @base = map.BaseAddress;
            var data = map.Read(@base, 16);
            var info = map.FileInfo;
            term.print(info.Length);

            term.print(@base);
            term.print(data.Length);
            term.print(new BinaryCode(data.ToArray()));
        }
        
        public override void RunShell(params string[] args)
            => Control.run(Context,args);

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}