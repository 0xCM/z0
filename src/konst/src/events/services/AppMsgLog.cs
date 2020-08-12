//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct AppMsgLog : IAppMsgLog
    {           
        public static IAppMsgLog create(FilePath std, FilePath err)         
            => new AppMsgLog(std, err);

        readonly FilePath DefaultTarget;
        
        readonly FilePath ErrorTarget;

        [MethodImpl(Inline)]
        internal AppMsgLog(FilePath std, FilePath err)
        {
            DefaultTarget = std;
            ErrorTarget = err;
        }

        public void Deposit(IEnumerable<IAppMsg> src)
        {
            z.insist(src);
            z.insist(!src.Any(m => m == null),"Null messages are bad");

            var errors = (from m in src where m.IsError select m.Format()).Array();        
            if(errors.Length != 0)
                ErrorTarget.Append(errors);
                                
            var standard = Format.items(src.Where(m => !m.IsError)).Array();
            if(standard.Length != 0)
                DefaultTarget.Append(standard);
        }

         public void Deposit(IAppMsg src)
         {
            var formatted = src.Format();
            if(src.IsError)
                ErrorTarget.Append(formatted);
            else
                DefaultTarget.Append(formatted);
        }
   }
}