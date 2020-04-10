//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Seed;
    using static Memories;

    public class AsmContext : IAsmContext 
    {            
        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        [MethodImpl(Inline)]
        public static IAsmContext Create(IApiComposition assemblies, IAppSettings settings, IAppMsgExchange exchange, IPolyrand random, AsmFormatConfig format)
            => new AsmContext(assemblies,settings, exchange,random,format);

        AsmContext(IApiComposition composition, IAppSettings settings, IAppMsgExchange exchange, IPolyrand random, AsmFormatConfig format)
        {
            Next += BlackHole;
            ApiSet = Z0.ApiSet.Create(composition);
            Messaging = exchange;
            Settings = settings;
            Messaging.Next += Relay;            
            Random = random;
            AsmFormat = format;
            Settings = settings;
            Paths = AppPathProvider.Create(Assembly.GetEntryAssembly().Id(), Env.Current.LogDir);  
        }

        public event Action<AppMsg> Next;

        public IPolyrand Random {get;}

        IAppMsgExchange Messaging {get;}
        
        public IAppSettings Settings {get;}

        public AsmFormatConfig AsmFormat {get;}

        public IApiSet ApiSet {get;}

        public IAppPaths Paths {get;}

        void BlackHole(AppMsg msg) {}

        void Relay(AppMsg msg)
            => Next(msg);
              
        public void Notify(AppMsg msg)
            => Messaging.Notify(msg);

        public void Notify(string msg, AppMsgKind? severity = null)
            => Messaging.Notify(msg, severity);

        public IReadOnlyList<AppMsg> Dequeue()
            => Messaging.Dequeue();

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => Messaging.Flush(e);

        public void Emit(FilePath dst) 
            => Messaging.Emit(dst);
    }   
}