//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    using P = Z0.Parts;

    class Artistry : AppShell<Artistry,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(array(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return Apps.context(resolved, random, settings, exchange);
        }
        

        public Artistry()
            : base(CreateAppContext())
        {
        }

        IResolvedApi Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
       
        IArtistryContext CreateArtistryContext(IAsmContext root, PartId[] code)
            => ArtistryContext.Create(root, code);

        public override void RunShell(params string[] args)
        {            
            var parts = PartIdParser.Service.ParseValid(args);  
            var context = CreateArtistryContext(AsmContext.create(Context), parts);  
            new Art(context).Display();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}