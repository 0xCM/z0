//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using R = Z0.Parts;

    public abstract class t_asm<U> : UnitTest<U>
        where U : t_asm<U>
    {

        protected IApiCodeArchive CodeArchive 
            => Context.CodeArchive(
                Env.Current.LogDir + FolderName.Define("test"), 
                FolderName.Define("data"), 
                FolderName.Define(typeof(U).Name)
                );
        
        protected StreamWriter FileStreamWriter([Caller] string caller = null)
            => CodeArchive.HexPath(FileName.Define(caller)).Writer();

        protected ICodeStreamWriter HexCodeWriter([Caller] string caller = null)
        {
            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.Hex));
            return Context.CodeWriter(dstPath);
        }

        protected new IAsmContext Context;
        
        public static IPart[] DefaultResolutions 
            => new IPart[]{
                R.Blocks.Resolved, 
                R.Math.Resolved,
                R.Vectors.Resolved,
                R.GMath.Resolved,
                R.Cast.Resolved
                }
                ;        
        public t_asm()
        {
            Context = AsmContext.Create(
                ApiComposition.Assemble(DefaultResolutions), 
                AppSettings.Empty, 
                AppMessages.exchange(Queue), 
                Random, 
                AsmFormatConfig.New,
                Context.AsmFormatter(),
                Context.AsmFunctionDecoder(),
                Context.AsmWriterFactory()
                );
        }
    }
}
