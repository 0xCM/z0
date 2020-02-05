//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static zfunc;
    public abstract class t_asm<U> : UnitTest<U>, IDisposable
        where U : t_asm<U>
    {
        protected INativeExecBuffer AsmBuffer;

        protected IAsmContext Context;

        INativeExecBuffer[] AsmBuffers;
        
        public t_asm()
        {
            Context = AsmContext.New(ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default);
            AsmBuffer = NativeServices.ExecBuffer();
            AsmBuffers = new INativeExecBuffer[]{
                NativeServices.ExecBuffer(),
                NativeServices.ExecBuffer()
            };
        }

        public void Dispose()
        {
            AsmBuffer.Dispose();
            AsmBuffers[0].Dispose();
            AsmBuffers[1].Dispose();
        }

        protected INativeExecBuffer LeftBuffer
            => AsmBuffers[0];

        protected INativeExecBuffer RightBuffer
            => AsmBuffers[1];

        protected string Math
            => nameof(math);
        
        protected string GMath
            => nameof(gmath);

        protected AsmFormatConfig DefaultAsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        protected IAsmHexWriter HexTestWriter([Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  Context.HexWriter(dst);
        }

        protected INativeWriter NativeTestWriter([Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  NativeServices.Writer(dst);
        }

        protected IAsmFunctionWriter AsmTestWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Asm);    
            return Context.WithFormat(DefaultAsmFormat).AsmWriter(path);
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
                      
            var g = AsmBuffer.BinaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, asm.Id);
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f,asm.Untyped);

        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
            var g = AsmBuffer.UnaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, asm.Id);
        }

        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f, asm.Untyped);

        protected AsmCode ReadAsm(string catalog, string subject, OpIdentity m)
            => Context.CodeArchive(catalog,subject).Read(m).Single();

        protected AsmCode<T> ReadAsm<W,T>(string catalog, string subject, string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => Context.CodeArchive(catalog,subject).Read<T>(Identity.contracted(opname, w, NumericType.kind<T>())).Require(); 

        protected void megacheck(string name, Func<byte,byte,byte> primal, Func<byte,byte,byte> generic, HK.Numeric<byte> kind)
        {
            var w = n8;

            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, HK.Numeric<sbyte> kind)
        {
            var w = n8;

            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<ushort,ushort,ushort> primal, Func<ushort,ushort,ushort> generic, HK.Numeric<ushort> kind)
        {
            var w = n16;

            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }


        protected void megacheck(string name, Func<short,short,short> primal, Func<short,short,short> generic, HK.Numeric<short> kind)
        {
            var w = n16;

            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<uint,uint,uint> primal, Func<uint,uint,uint> generic, HK.Numeric<uint> kind)
        {
            var w = n32;

            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<int,int,int> primal, Func<int,int,int> generic, HK.Numeric<int> kind)
        {
            var w = n32;
            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math ,moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<long,long,long> primal, Func<long,long,long> generic, HK.Numeric<long> kind)
        {            
            var w = n64;
            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math ,moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<ulong,ulong,ulong> primal, Func<ulong,ulong,ulong> generic, HK.Numeric<ulong> kind)
        {            
            var w = n64;

            var moniker = Identity.operation(name, kind);                        
            var f0 = Dynop.BinOp(primal, kind);

            var f1 = Dynop.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }
    }
}
