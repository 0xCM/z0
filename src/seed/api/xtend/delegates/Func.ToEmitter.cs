//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class XTend
    {
        public static string ToLegalIdentifier(this OpIdentity src)
            => CodeIdMachine.Service.Manufacture(src);

        public static FileName ToLegalFileName(this OpIdentity src, FileExtension ext)
            => FileName.Define(FileIdMachine.Service.Manufacture(src), ext);        
     
        [MethodImpl(Inline)]
        public static Emitter<T> ToEmitter<T>(this System.Func<T> f)
            => Extend.emitter(f);

        [MethodImpl(Inline)]
        public static Emitter<T,C> ToEmitter<T,C>(this System.Func<T> f)
            where T : unmanaged
            where C : unmanaged
                => Extend.emitter<T,C>(f);
    }
}